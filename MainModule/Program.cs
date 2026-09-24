using MainModule.BuildPipeline;
using MainModule.Documentation;
using MainModule.Security;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureServices();
builder.AddServices();
builder.ConfigureSecretSecurityKey();

var app = builder.Build();
app.UseCors();
app.UseOpenApi();
app.UseHttpsRedirection();
app.AddEndpoints();
app.Run();
