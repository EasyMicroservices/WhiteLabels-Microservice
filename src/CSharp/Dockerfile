# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS Build
WORKDIR /source
COPY . .
RUN dotnet restore EasyMicroservices.WhiteLabelsMicroservice.sln
RUN dotnet build EasyMicroservices.WhiteLabelsMicroservice.sln --no-restore
RUN dotnet test EasyMicroservices.WhiteLabelsMicroservice.sln --no-build --verbosity normal -f net7.0
RUN dotnet publish EasyMicroservices.WhiteLabelsMicroservice.sln -c release -o /app --no-restore

# Serve Stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS Serve
WORKDIR /app
COPY --from=Build /app ./

EXPOSE 5000

ENTRYPOINT ["dotnet", "EasyMicroservices.WhiteLabelsMicroservice.WebApi.dll"]