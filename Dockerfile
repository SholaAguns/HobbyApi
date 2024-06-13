# Use the official ASP.NET Core runtime image as a base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 80


# Use the official .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["HobbyApi.csproj", "."]
RUN dotnet restore "./HobbyApi.csproj"

# Copy the rest of the application code
COPY . .

# Build the application
RUN dotnet build "HobbyApi.csproj" -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish "HobbyApi.csproj" -c Release -o /app/publish

# Final stage: Copy the published app and set the entrypoint
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HobbyApi.dll"]
