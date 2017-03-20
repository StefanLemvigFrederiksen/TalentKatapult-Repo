# Setup SDK and Dir
FROM microsoft/dotnet
WORKDIR /dotnetapp

# Copy content and setup packages for the tests
COPY . ./
RUN dotnet restore ./Number.Test

# Run the tests 
RUN dotnet test ./Number.Test/Number.Test.csproj