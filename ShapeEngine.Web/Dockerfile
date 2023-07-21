FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ShapeEngine.Web/ShapeEngine.Web.csproj", "ShapeEngine.Web/"]
COPY ["ShapeEngine.Domain/ShapeEngine.Domain.csproj", "ShapeEngine.Domain/"]
COPY ["ShapeEngine.Data/ShapeEngine.Data.csproj", "ShapeEngine.Data/"]
RUN dotnet restore "ShapeEngine.Web/ShapeEngine.Web.csproj"
COPY . .
WORKDIR "/src/ShapeEngine.Web"
RUN dotnet build "ShapeEngine.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ShapeEngine.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShapeEngine.Web.dll"]
