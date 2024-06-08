#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Api.Application/application.csproj", "Api.Application/"]
COPY ["Api.Domain/Domain.csproj", "Api.Domain/"]
COPY ["Api.Service/Service.csproj", "Api.Service/"]
COPY ["Api.Data/Data.csproj", "Api.Data/"]
COPY ["Api.CrossCutting/CrossCutting.csproj", "Api.CrossCutting/"]
RUN dotnet restore "./Api.Application/application.csproj"
COPY . .
WORKDIR "/src/Api.Application"
RUN dotnet build "./application.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./application.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "application.dll"]