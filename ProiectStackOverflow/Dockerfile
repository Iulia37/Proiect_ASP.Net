FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
ENV PORT=8080
ENV ASPNETCORE_URLS=http://+:8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ProiectStackOverflow.csproj", "./"]
RUN dotnet restore "ProiectStackOverflow.csproj"
COPY . .
RUN dotnet build "ProiectStackOverflow.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProiectStackOverflow.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProiectStackOverflow.dll"]