var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("demodatabase");

builder.AddProject<Projects.Template_Setup_WebApi>("template-setup-webapi")
    .WithReference(postgres)
    .WaitFor(postgres);

builder.Build().Run();
