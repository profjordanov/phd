#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Manager.Auth/Manager.Auth.csproj", "Manager.Auth/"]
RUN dotnet restore "Manager.Auth/Manager.Auth.csproj"
COPY . .
WORKDIR "/src/Manager.Auth"
RUN dotnet build "Manager.Auth.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Manager.Auth.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Manager.Auth.dll"]