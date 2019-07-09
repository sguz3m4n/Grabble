FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["GrabbleAPI/GrabbleAPI.csproj", "GrabbleAPI/"]
RUN dotnet restore "GrabbleAPI/GrabbleAPI.csproj"
COPY . .
WORKDIR "/src/GrabbleAPI"
RUN dotnet build "GrabbleAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "GrabbleAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "GrabbleAPI.dll"]