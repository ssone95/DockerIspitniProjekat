#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
RUN apt-get update && apt-get install -y iputils-ping

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["BlazorUI/BlazorUI.csproj", "BlazorUI/"]
COPY ["Domain/Domain.csproj", "Domain/"]
RUN dotnet restore "BlazorUI/BlazorUI.csproj"
COPY . .
WORKDIR "/src/BlazorUI"
RUN dotnet build "BlazorUI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorUI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorUI.dll"]