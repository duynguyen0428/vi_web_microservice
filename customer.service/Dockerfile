# # # Build env
# FROM microsoft/dotnet:sdk
# WORKDIR /app

# #build
# COPY *.csproj ./
# RUN dotnet restore
# RUN dotnet publish -c Release -o ./bin/release


# # Copy everything else and build
# COPY . ./



# WORKDIR /app
# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app
COPY ./bin/release .
ENTRYPOINT ["dotnet", "customer.service.dll"]