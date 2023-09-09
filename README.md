# Receitaws .NET API Client

[![Test CI](https://github.com/TheLe0/receitaws-api-client/actions/workflows/tests.yml/badge.svg)](https://github.com/TheLe0/receitaws-api-client/actions/workflows/tests.yml)

This is a .NET client implementation of the [receitaws](https://www.receitaws.com.br/) api that gives you data of brazilian companies and enterprises.

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

```csharp
var company = await client.LegalEntity.FindByCnpj(cnpj, days);
```

>Note: This endpoint is not free, is going to discount of your avaliable quote quantity.
