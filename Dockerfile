FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app
COPY . .
RUN dotnet restore "src/Birds.sln"
RUN dotnet build "src/Server/Birds.Server.csproj" -c Release -o /app/build

# Run tests here

FROM build AS publish
RUN dotnet publish "src/Server/Birds.Server.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Birds.dll"]
