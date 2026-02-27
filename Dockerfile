# Use the official .NET 9 SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copy the solution and project files
COPY *.sln .
COPY *.csproj .

# Restore dependencies
RUN dotnet restore

# Copy the rest of the application source code
COPY . .

# Publish the application for release
RUN dotnet publish -c Release -o out

# Use the official .NET 9 ASP.NET runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

# Copy the published application from the build stage
COPY --from=build /app/out .

# Expose port 8080
EXPOSE 8080

# Set the entry point for the application
ENTRYPOINT ["dotnet", "module-4-mvc-net-core.dll"]
