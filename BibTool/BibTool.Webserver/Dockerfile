FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BibTool.Webserver/BibTool.Webserver.csproj", "BibTool.Webserver/"]
RUN dotnet restore "BibTool.Webserver/BibTool.Webserver.csproj"
COPY . .
WORKDIR "/src/BibTool.Webserver"
RUN dotnet build "BibTool.Webserver.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BibTool.Webserver.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BibTool.Webserver.dll"]
