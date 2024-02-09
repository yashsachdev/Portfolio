#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Flashcard_yashsachdev5677/Flashcard_yashsachdev5677.csproj", "Flashcard_yashsachdev5677/"]
RUN dotnet restore "Flashcard_yashsachdev5677/Flashcard_yashsachdev5677.csproj"
COPY . .
WORKDIR "/src/Flashcard_yashsachdev5677"
RUN dotnet build "Flashcard_yashsachdev5677.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Flashcard_yashsachdev5677.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Flashcard_yashsachdev5677.dll"]