using KansaiExplore.Data;
using KansaiExplore.Data.Shared;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using OpenTelemetry.Trace;
using System.Diagnostics;

namespace SpotWorkerService;

public class Worker(IServiceProvider serviceProvider, IHostApplicationLifetime hostApplicationLifetime) : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    public const string ActivitySourceName = "Migrations";
    private static readonly ActivitySource activitySource = new(ActivitySourceName);
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var activity = activitySource.StartActivity("Migrating database", ActivityKind.Client);
        try
        {
            using var scope = serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();

            await EnsureDatabaseAsync(dbContext, stoppingToken);
            await RunMigrationAsync(dbContext, stoppingToken);
            await SendDataAsync(dbContext, stoppingToken);
        } catch(Exception ex)
        {
            activity?.RecordException(ex);
            throw;
        }
        hostApplicationLifetime.StopApplication();
    }

    private static async Task EnsureDatabaseAsync(DataContext dbContext, CancellationToken cancellation)
    {
        var dbCreator = dbContext.GetService<IRelationalDatabaseCreator>();

        var strategy = dbContext.Database.CreateExecutionStrategy();
        await strategy.ExecuteAsync(async () =>
        {
            // Create the database if it does not exist.
            // Do this first so there is then a database to start a transaction against.
            if (!await dbCreator.ExistsAsync(cancellation))
            {
                await dbCreator.CreateAsync(cancellation);
            }
        });
    }

    private static async Task RunMigrationAsync(DataContext dbcontext, CancellationToken cancellationToken)
    {
        var strategy = dbcontext.Database.CreateExecutionStrategy();
        await strategy.ExecuteAsync(async () =>
        {
            await using var transactiion = await dbcontext.Database.BeginTransactionAsync(cancellationToken);
            await dbcontext.Database.MigrateAsync(cancellationToken);
            await transactiion.CommitAsync(cancellationToken);
        });
    }

    private static async Task SendDataAsync(DataContext dbContext, CancellationToken cancellationToken)
    {
        NicheSpot spot = new()
        {
            Id = Guid.NewGuid(), 
            Choordinates = "test", CreatedAt = DateTimeOffset.UtcNow, CreatedBy = Guid.NewGuid(), MediaUrl = "test", SpotDescription = "Kyoto Research Park", SpotName = "KRP"
        };

        var strategy = dbContext.Database.CreateExecutionStrategy();
        await strategy.ExecuteAsync(async () =>
        {
            await using var transaction = await dbContext.Database.BeginTransactionAsync(cancellationToken);
            await dbContext.kansaispot.AddAsync(spot, cancellationToken);
            await dbContext.SaveChangesAsync(cancellationToken);
            await transaction.CommitAsync(cancellationToken);
        });
    }
}
