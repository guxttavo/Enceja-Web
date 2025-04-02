FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Backend/Escola.API/Escola.API.csproj", "Backend/Escola.API/"]
COPY ["Backend/Escola.Domain/Escola.Domain.csproj", "Backend/Escola.Domain/"]
COPY ["Backend/Escola.Infrastructure/Escola.Infrastructure.csproj", "Backend/Escola.Infrastructure/"]
COPY ["Backend/Escola.Application/Escola.Application.csproj", "Backend/Escola.Application/"]

RUN dotnet restore "./Backend/Escola.API/Escola.API.csproj"
COPY . .
WORKDIR "/src/Backend/Escola.API"
RUN dotnet build "./Escola.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Escola.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Escola.API.dll"]