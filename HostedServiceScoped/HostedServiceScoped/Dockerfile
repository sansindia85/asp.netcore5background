#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:5.0-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["HostedServiceScoped/HostedServiceScoped.csproj", "HostedServiceScoped/"]
RUN dotnet restore "HostedServiceScoped/HostedServiceScoped.csproj"
COPY . .
WORKDIR "/src/HostedServiceScoped"
RUN dotnet build "HostedServiceScoped.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HostedServiceScoped.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HostedServiceScoped.dll"]