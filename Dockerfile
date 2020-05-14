FROM microsoft/dotnet:3.1-sdk as base
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=base /app/out .
ENTRYPOINT ["dotnet", "Backoffice.WebApi.dll"]