FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["jhuzkie/jhuzkie.csproj", "jhuzkie/"]
RUN dotnet restore "jhuzkie/jhuzkie.csproj"
COPY . .
WORKDIR "/src/jhuzkie"
RUN dotnet build "jhuzkie.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "jhuzkie.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "jhuzkie.dll"]
