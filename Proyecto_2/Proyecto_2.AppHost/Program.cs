var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Proyecto_2_ApiService>("apiservice");

builder.AddProject<Projects.Proyecto_2_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.AddProject<Projects.Proyecto_2>("proyecto-2");

builder.Build().Run();
