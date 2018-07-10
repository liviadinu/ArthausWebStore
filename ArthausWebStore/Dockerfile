FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 53294
EXPOSE 44389

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY ArthausWebStore/ArthausWebStore.csproj ArthausWebStore/
RUN dotnet restore ArthausWebStore/ArthausWebStore.csproj
COPY . .
WORKDIR /src/ArthausWebStore
RUN dotnet build ArthausWebStore.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ArthausWebStore.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ArthausWebStore.dll"]
