FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["NashtechPractical.AssetManagement.WebAPI/NashtechPractical.AssetManagement.WebAPI.csproj", "NashtechPractical.AssetManagement.WebAPI/"]
RUN dotnet restore "NashtechPractical.AssetManagement.WebAPI/NashtechPractical.AssetManagement.WebAPI.csproj"
COPY . .
WORKDIR "/src/NashtechPractical.AssetManagement.WebAPI"
RUN dotnet build "NashtechPractical.AssetManagement.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "NashtechPractical.AssetManagement.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NashtechPractical.AssetManagement.WebAPI.dll"]
