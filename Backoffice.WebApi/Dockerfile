#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Backoffice.WebApi/Backoffice.WebApi.csproj", "Backoffice.WebApi/"]
COPY ["Backoffice.Application/Backoffice.Application.csproj", "Backoffice.Application/"]
COPY ["Backoffice.Adapters.Database/Backoffice.Adapters.QueryDatabase.csproj", "Backoffice.Adapters.Database/"]
RUN dotnet restore "Backoffice.WebApi/Backoffice.WebApi.csproj"
COPY . .
WORKDIR "/src/Backoffice.WebApi"
RUN dotnet build "Backoffice.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Backoffice.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Backoffice.WebApi.dll"]
