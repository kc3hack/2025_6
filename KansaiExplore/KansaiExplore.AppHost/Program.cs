
var builder = DistributedApplication.CreateBuilder(args);
var sql = builder.AddPostgres("db").AddDatabase("kansaispot");
builder.AddProject<Projects.KansaiExplore>("kansaiexplore")
    .WithReference(sql);
builder.AddProject<Projects.SpotWorkerService>("spotworkerservice");
builder.AddProject<Projects.SpotWorkerService>("migrations")
    .WithReference(sql);
builder.Build().Run();
