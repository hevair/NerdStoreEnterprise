#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Services/NerdStoreEnterprise.Pedido.API/NerdStoreEnterprise.Pedido.API.csproj", "src/Services/NerdStoreEnterprise.Pedido.API/"]
RUN dotnet restore "src/Services/NerdStoreEnterprise.Pedido.API/NerdStoreEnterprise.Pedido.API.csproj"
COPY . .
WORKDIR "/src/src/Services/NerdStoreEnterprise.Pedido.API"
RUN dotnet build "NerdStoreEnterprise.Pedido.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NerdStoreEnterprise.Pedido.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NerdStoreEnterprise.Pedido.API.dll"]