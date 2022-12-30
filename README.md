# GoodToCode dotnet-library

This repository includes simple, low-dependency libraries for dotnet. The primary use is for examples of common design patterns, utilities and infrastructure concerns in dotnet development.

## design-patterns 
[![Build Status](https://dev.azure.com/GoodToCode/GoodToCode.com/_apis/build/status/gtg-rg-templates-microservices?branchName=main)](https://dev.azure.com/GoodToCode/GoodToCode.com/_build/latest?definitionId=85&branchName=main)
Design Patterns library for common patterns used in development of Microservices.


## Repo Contents
Path | Contents | Description
--- | --- | ---
design-patterns | src, nuget | Desing patterns for Microservice development. Cqrs, Ddd and Repository patterns.
dotnet-aspnet | src, nuget | ASP.NET middleware handlers, filters
.azure | Azure ARM json | Azure Infrastructure as Code required to host the items in this repo.
.azure-devops | Azure Devops Pipelines yml | Azure DevOps Pipelines that build, test and deploy /.azure/.json and /.csproj

## Prerequisites
You will need the following tools:
* [Visual Studio Code or 2022](https://www.visualstudio.com/downloads/)
* [.NET 6.0 or above](https://www.microsoft.com/net/download/dotnet-core/6.0)

## Contact
* [GitHub Repo](https://www.github.com/goodtocode/dotnet-library)
* [@goodtocode](https://www.twitter.com/goodtocode)
* [github.com/goodtocode](https://www.github.com/goodtocode)

## Clean Architecture
Clean Architecture is promoted by Microsoft on their .NET application architecture guide page. The e-book written by Steve "ardalis" Smith ([@ardalis](https://github.com/ardalis)) is beautifully written and well explains the beauty and benefits of using Clean Architecture. For more details, please see [**Architect Modern Web Applications with ASP.NET Core and Azure**](https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/).

## Architectures and Patterns
All .NET solutions adhere to the following:
* DDD + Onion Architecture
* CQRS Pattern
* Repository Pattern
### dotnet-microservices
* Microservice Architecture

## Technologies
* .NET 6
* EF Core 6
* Azure Functions 4
* Durable Task Framework 2
* SQL Server
* CosmosDb
* Open API

# Give a star
:star: If you enjoy this project, or are using this project to start your exciting new project, or are just forking it to play, please give it a star. Much appreciated! :star: 