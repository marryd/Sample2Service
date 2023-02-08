using Database.Configuration;
using Kpp;
using Payers.Facade;
using Payers.Ports;
using Payers.UseCases;
using PayerSystem;
using Potatoes.Facade;
using Potatoes.Ports;
using Potatoes.UseCases;

var builder = WebApplication.CreateBuilder(args);


//apps
builder.Services.AddScoped<IPayerApp, PayerApp>();
builder.Services.AddScoped<IPotatoApp, PotatoApp>();

// uc
builder.Services.AddScoped<PayerUseCase>();
builder.Services.AddScoped<PotatoUseCase>();

// ports

builder.Services.AddScoped<IPayerSystem, PayerClient>();

// db
builder.Services.AddPayersDataStore();
builder.Services.AddPotatoesDataStore();

//kpp
builder.Services.AddHttpClient<ICostSystem, KppClient>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
