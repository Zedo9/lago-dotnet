# Lago .Net Client

A .NET Standard 2.1 SDK wrapper built with Refit for Lago API.

## Installation

Via Nuget

```sh
# Package Manager
Install-Package Lago.NET.Client

# dotnet
dotnet add package Lago.NET.Client
```

## Usage

### Directly creating an instance of LagoClient

```csharp
using Lago.NET.Client;

ILagoClient lagoClient = LagoClientFactory.Create("apiKey");
// Or : LagoClientFactory.Create("apiKey", "https://api.getlago.com");

BillableMetricInput billableMetricInput = new();
BillableMetric result = await lagoClient.BillableMetrics.CreateAsync(billableMetricInput);
```

### Registering ILagoClient in your DI container using the provided extension method

```csharp
// startup.cs / program.cs
using Lago.NET.Client.Extensions.DependencyInjection;

services.AddLagoClient((httpClient) => {
    /* Custom httpClient configuration */},
    "apiKey",
    "https://api.getlago.com" );
```

```csharp
// CustomService.cs
using Lago.NET.Client;

public CustomService
{
  private readonly ILagoClient _lagoClient;

  public CustomService(ILagoClient lagoClient)
  {
    _lagoClient = lagoClient;
  }
}
```

## License

Lago .NET client is distributed under the [MIT](LICENSE) license.
