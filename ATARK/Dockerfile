#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WevApi/WebApi.csproj", "WevApi/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Domen/Domen.csproj", "Domen/"]
COPY ["Trackers/Trackers.csproj", "Trackers/"]
COPY ["Persistence/Persistence.csproj", "Persistence/"]
RUN dotnet restore "WevApi/WebApi.csproj"
COPY . .
WORKDIR "/src/WevApi"
RUN dotnet build "WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApi.dll"]