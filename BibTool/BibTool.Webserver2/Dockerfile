FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BibTool.Webserver2/BibTool.Webserver2.csproj", "BibTool.Webserver2/"]
RUN dotnet restore "BibTool.Webserver2/BibTool.Webserver2.csproj"
COPY . .
WORKDIR "/src/BibTool.Webserver2"
RUN dotnet build "BibTool.Webserver2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BibTool.Webserver2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BibTool.Webserver2.dll"]
