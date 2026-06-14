FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /src

COPY . .

RUN dotnet restore "dashboard-service.csproj"
RUN dotnet publish "dashboard-service.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:9.0

WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8083

ENTRYPOINT ["dotnet", "dashboard-service.dll"]