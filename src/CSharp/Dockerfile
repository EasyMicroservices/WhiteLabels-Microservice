# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS Build
WORKDIR /source
COPY . .
RUN dotnet restore EasyMicroservices.WhiteLabelsMicroservice-net6.0.sln
RUN dotnet build EasyMicroservices.WhiteLabelsMicroservice-net6.0.sln --no-restore
RUN dotnet test EasyMicroservices.WhiteLabelsMicroservice-net6.0.sln --no-build --verbosity normal -f net6.0
RUN dotnet publish EasyMicroservices.WhiteLabelsMicroservice-net6.0.sln -c release -o /app --no-restore

# Serve Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS Serve
WORKDIR /app
COPY --from=Build /app ./

EXPOSE 5000

ENTRYPOINT ["dotnet", "EasyMicroservices.WhiteLabelsMicroservice.WebApi.dll"]