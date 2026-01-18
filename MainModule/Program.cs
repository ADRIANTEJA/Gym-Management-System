using DataAccess.Models;
using MainModule.BuildPipeline;

var builder = WebApplication.CreateBuilder(args);

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.AddServices();

var app = builder.Build();

app.UseCors();

app.UseOpenApi();

app.Run();
