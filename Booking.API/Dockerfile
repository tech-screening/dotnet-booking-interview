FROM mcr.microsoft.com/dotnet/sdk:9.0
WORKDIR /src
EXPOSE 8080
EXPOSE 8081
ARG BUILD_CONFIGURATION=Release
COPY ["Booking.API/Booking.API.csproj", "Booking.API/"]
RUN dotnet restore "Booking.API/Booking.API.csproj"
COPY . .
RUN dotnet build "Booking.API/Booking.API.csproj" -c $BUILD_CONFIGURATION -o /app/build
RUN dotnet publish "Booking.API/Booking.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false
WORKDIR /app/publish
ENTRYPOINT ["dotnet", "Booking.API.dll"]
