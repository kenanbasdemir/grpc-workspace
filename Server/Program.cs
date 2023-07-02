using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Server.Services;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("https://+:5001");

builder.Services.AddGrpc();

var app = builder.Build();

app.MapGrpcService<ChatService>();

app.Run();