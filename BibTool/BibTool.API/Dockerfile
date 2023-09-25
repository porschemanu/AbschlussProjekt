FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BibTool.API/BibTool.API.csproj", "BibTool.API/"]
RUN dotnet restore "BibTool.API/BibTool.API.csproj"
COPY . .
WORKDIR "/src/BibTool.API"
RUN dotnet build "BibTool.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BibTool.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BibTool.API.dll"]
