FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app
COPY . .
RUN dotnet restore "src/Birds.sln"
RUN dotnet build "src/Server/Birds.Server.csproj" -c Release -o /app/build

# Run tests here

FROM build AS publish
RUN dotnet publish "src/Server/Birds.Server.csproj" -c Release -o /app/publish

FROM base as final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Birds.dll"]
