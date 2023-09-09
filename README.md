# Receitaws .NET API Client

[![Test CI](https://github.com/TheLe0/receitaws-api-client/actions/workflows/tests.yml/badge.svg)](https://github.com/TheLe0/receitaws-api-client/actions/workflows/tests.yml)

This is a .NET client implementation of the [receitaws](https://www.receitaws.com.br/) api that gives you data of brazilian companies and enterprises.

You can use the receitaws's API for free, some endpoints doesnt need authentication, and the ones that does you can register on their website for free. You just need to login on the account, go to the API section and generate a token to use.

## Packages

   | Package | Version | Downloads | Workflow |
   |---------|---------|-----------|----------|
   | [Receitaws.API.Client](https://www.nuget.org/packages/Receitaws.API.Client/) | [![NuGet Version](https://img.shields.io/nuget/v/Receitaws.API.Client.svg)](https://www.nuget.org/packages/Receitaws.API.Client/ "NuGet Version")| [![NuGet Downloads](https://img.shields.io/nuget/dt/Receitaws.API.Client.svg)](https://www.nuget.org/packages/Receitaws.API.Client/ "NuGet Downloads") | [![Deploy](https://github.com/TheLe0/receitaws-api-client/actions/workflows/deploy_nuget_api_client.yml/badge.svg)](https://github.com/TheLe0/receitaws-api-client/actions/workflows/deploy_nuget_api_client.yml) |
   | [Receitaws.API.Client.DependencyInjection](https://www.nuget.org/packages/Receitaws.API.Client.DependencyInjection/) | ![NuGet Version](https://img.shields.io/nuget/v/Receitaws.API.Client.DependencyInjection.svg) | [![NuGet Downloads](https://img.shields.io/nuget/dt/Receitaws.API.Client.DependencyInjection.svg)](https://www.nuget.org/packages/Receitaws.API.Client.DependencyInjection/ "NuGet Downloads") | [![Deploy](https://github.com/TheLe0/receitaws-api-client/actions/workflows/deploy_nuget_api_client_di.yml/badge.svg)](https://github.com/TheLe0/receitaws-api-client/actions/workflows/deploy_nuget_api_client_di.yml) |

## Endpoints

1. [FindByCnpj](https://github.com/TheLe0/receitaws-api-client/blob/d26a3361123c60b8c4cfc79011ccea2949b24f19/src/Receitaws.API.Client/Implementation/LegalEntity.cs#L16C32-L16C42): Find a company by its CNPJ number;

```csharp
var company = await client.LegalEntity.FindByCnpj(cnpj);
```

2. [FindByCnpj with precision](https://github.com/TheLe0/receitaws-api-client/blob/d26a3361123c60b8c4cfc79011ccea2949b24f19/src/Receitaws.API.Client/Implementation/LegalEntity.cs#L23): Find a company by its CNPJ number with days precision of the data;

>Note: You must be authenticated to use this endpoint

```csharp
var company = await client.LegalEntity.FindByCnpj(cnpj, days);
```

>Note: This endpoint is not free, is going to discount of your avaliable quote quantity.

3. [GetAccountProfile](https://github.com/TheLe0/receitaws-api-client/blob/5fc21871ae8635eb7e287277d15ce26e9165f6dc/src/Receitaws.API.Client/Implementation/Account.cs#L16C39-L16C56): Get informations about your receitaws's account, basically the quotes remaining quantity.

>Note: You must be authenticated to use this endpoint

```csharp
var accountProfile = await client.Account.GetAccountProfile();
```

4. [GetAccountHistoricReport](https://github.com/TheLe0/receitaws-api-client/blob/5fc21871ae8635eb7e287277d15ce26e9165f6dc/src/Receitaws.API.Client/Implementation/Account.cs#L25): Get a historic report of the APIs calls that used your quotes, the calls that costed quotes.

>Note: You must be authenticated to use this endpoint

 ```csharp
var accountHistoricReport = await client.Account.GetAccountHistoricReport();
```

## Configuration

This Api integration is ver simple, there is no authentication/authorization requirements, you can use it with almost no configurations.

You can instanciate this client in three different ways:

1. Using default configs: This uses the default [baseUrl](https://github.com/TheLe0/receitaws-api-client/blob/5fc21871ae8635eb7e287277d15ce26e9165f6dc/src/Receitaws.API.Client/Resources/Routes.resx#L120), [timeout](https://github.com/TheLe0/receitaws-api-client/blob/5fc21871ae8635eb7e287277d15ce26e9165f6dc/src/Receitaws.API.Client/Resources/Configurations.resx#L121) and [Throw on any error flag](https://github.com/TheLe0/receitaws-api-client/blob/5fc21871ae8635eb7e287277d15ce26e9165f6dc/src/Receitaws.API.Client/Resources/Configurations.resx#L124).

>Note: This default setup is without token, so you can only access the method <b>FindByCnpj</b> because is the only >one that doesnt need authentication.

```csharp
var client = new Receitaws();
```

or by dependency injection:

```csharp
services.AddReceitawsApiClient();
```

2. Only configurating the token:

```csharp
var client = new Receitaws(token);
```

or by dependency injection:

```csharp
services.AddReceitawsApiClient(token);
```

3. And setup manually all configurations with your preferences:

```csharp
var configs = new ReceitawsApiClientConfiguration 
{
    Token  = "YOUR_API_TOKEN",
    BaseUrl = baseUrl,
    MaxTimeout = 10000,
    ThrowOnAnyError = false
};

var client = new Receitaws(configs);
```

or by dependency injection:

```csharp
var configs = new ReceitawsApiClientConfiguration 
{
    Token  = "YOUR_API_TOKEN",
    BaseUrl = baseUrl,
    MaxTimeout = 10000,
    ThrowOnAnyError = false
};

services.AddReceitawsApiClient(configs);
```
