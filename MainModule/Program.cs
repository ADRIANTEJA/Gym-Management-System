using MainModule.BuildPipeline;
using MainModule.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.AddServices();

var app = builder.Build();

app.UseCors();

app.UseOpenApi();

app.UseHttpsRedirection();

app.AddEndpoints();

app.Run();
