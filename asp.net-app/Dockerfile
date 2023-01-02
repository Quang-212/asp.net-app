#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["asp.net-app.csproj", "./"]
RUN dotnet restore "asp.net-app.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "asp.net-app.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "asp.net-app.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "asp.net-app.dll"]