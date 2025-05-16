FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 7670
EXPOSE 7671

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["*.sln", "../"]
COPY ["NashtechPractical.AssetManagement.WebAPI/*.csproj", "./NashtechPractical.AssetManagement.WebAPI/"]
COPY ["NashtechPractical.AssetManagement.Application/*.csproj", " ./NashtechPractical.AssetManagement.Application/"]
COPY ["NashtechPractical.AssetManagement.Core/*.csproj", " ./NashtechPractical.AssetManagement.Core/"]
COPY ["NashtechPractical.AssetManagement.Infrastructure/*.csproj", " ./NashtechPractical.AssetManagement.Infrastructure/"]
COPY ["NashtechPractical.AssetManagement.Shared/*.csproj", " ./NashtechPractical.AssetManagement.Shared/"]

RUN dotnet restore "NashtechPractical.AssetManagement.WebAPI/NashtechPractical.AssetManagement.WebAPI.csproj"
RUN dotnet restore "NashtechPractical.AssetManagement.sln"
COPY . .

# Build
WORKDIR "/app/NashtechPractical.AssetManagement.WebAPI"
RUN dotnet build "NashtechPractical.AssetManagement.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "NashtechPractical.AssetManagement.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false --no-restore

# Runtime
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NashtechPractical.AssetManagement.WebAPI.dll"]
