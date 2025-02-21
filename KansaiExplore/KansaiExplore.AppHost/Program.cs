var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.KansaiExplore>("kansaiexplore");

builder.Build().Run();
