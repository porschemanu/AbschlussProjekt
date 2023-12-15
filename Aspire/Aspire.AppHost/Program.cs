var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Aspire_WebApp>("Aspire.WebApp");
builder.AddProject<Projects.Aspire_WebApi>("Aspire.WebApi");

builder.Build().Run();
