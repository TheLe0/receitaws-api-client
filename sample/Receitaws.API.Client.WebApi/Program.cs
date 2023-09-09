using Receitaws.API.Client.WebApi.Common;
using Receitaws.API.Client.WebApi.Route;
using Receitaws.API.Client.Configuration;
using Receitaws.API.Client.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var receitawsConfig = builder.Configuration
    .Parse<ReceitawsApiClientConfiguration>("Receitaws");

builder.Services.AddReceitawsApiClient(receitawsConfig);

//var token = builder.Configuration.GetValue<string>("Receitaws:Token");
//builder.Services.AddReceitawsApiClient(token);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.AddLegalEntityEndpoints();
app.AddAccountEndpoints();

app.Run();
