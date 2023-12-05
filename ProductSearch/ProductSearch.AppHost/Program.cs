var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.ProductSearch_ApiService>("apiservice");

builder.AddProject<Projects.ProductSearch_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();
