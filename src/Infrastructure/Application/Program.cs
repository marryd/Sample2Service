using Contracts;
using Database.Configuration;
using Kpp;
using Payers.Application;
using Payers.UseCases;
using Potatoes.Application;
using Potatoes.UseCases;

var builder = WebApplication.CreateBuilder(args);


//apps
builder.Services.AddScoped<PayerApp>();
builder.Services.AddScoped<PotatoApp>();

// uc
builder.Services.AddScoped<PayerUseCase>();
builder.Services.AddScoped<PotatoUseCase>();

// db
builder.Services.AddPayersDataStore();
builder.Services.AddPotatoesDataStore();

//kpp
builder.Services.AddHttpClient<ICostSystem, KppClient>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
