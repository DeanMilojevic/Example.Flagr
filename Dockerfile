FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app
COPY Example.Flagr.sln ./
COPY ./src ./src
COPY ./tests ./tests

RUN dotnet restore Example.Flagr.sln
RUN dotnet publish src/Example.Api/Example.Api.csproj --framework netcoreapp3.1 -c Release -o out /p:Version=1.0.0

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "Example.Api.dll"]