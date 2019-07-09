FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["GrabbleProductAPI/GrabbleProductAPI.csproj", "GrabbleProductAPI/"]
RUN dotnet restore "GrabbleProductAPI/GrabbleProductAPI.csproj"
COPY . .
WORKDIR "/src/GrabbleProductAPI"
RUN dotnet build "GrabbleProductAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "GrabbleProductAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "GrabbleProductAPI.dll"]