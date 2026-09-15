using MainModule.BuildPipeline;
using MainModule.Debug;
using MainModule.Security;

var builder = WebApplication.CreateBuilder(args);

builder.AddServices();
builder.ConfigureSecretSecurityKey();

var app = builder.Build();
app.UseCors();
app.UseOpenApi();
app.UseHttpsRedirection();
app.AddEndpoints();
app.Run();
