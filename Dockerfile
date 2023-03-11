FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/Geor.Web.Host/Geor.Web.Host.csproj", "src/Geor.Web.Host/"]
COPY ["src/Geor.Web.Core/Geor.Web.Core.csproj", "src/Geor.Web.Core/"]
COPY ["src/Geor.Application/Geor.Application.csproj", "src/Geor.Application/"]
COPY ["src/Geor.Core/Geor.Core.csproj", "src/Geor.Core/"]
COPY ["src/Geor.EntityFrameworkCore/Geor.EntityFrameworkCore.csproj", "src/Geor.EntityFrameworkCore/"]
WORKDIR "/src/src/Geor.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Geor.Web.Host", "src/Geor.Web.Host"]
COPY ["src/Geor.Web.Core", "src/Geor.Web.Core"]
COPY ["src/Geor.Application", "src/Geor.Application"]
COPY ["src/Geor.Core", "src/Geor.Core"]
COPY ["src/Geor.EntityFrameworkCore", "src/Geor.EntityFrameworkCore"]
WORKDIR "/src/src/Geor.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Geor.Web.Host.dll"]
