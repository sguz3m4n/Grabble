# Grabble

A crowd sourced courier platform

## Project Layout

- Grabble.Order.Api
- Grabble.Item.Api
- Grabble.Service
- Grabble.Data
- Grabble.Repository
- Grabble.Order.Api

## Setup

The project can be setup and run in development as follows

```shell
export ASPNETCORE_ENVIRONMENT="Development"
```

```shell
set ASPNETCORE_ENVIRONMENT="Development"
```

```shell
$env:ASPNETCORE_ENVIRONMENT="Development"
```

```bash
dotnet restore
dotnet build
```

To run the order api

```bash
dotnet run --project Grabble.Order.Api
dotnet run --project Grabble.Item.Api
```

## Contributing
