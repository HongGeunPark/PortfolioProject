# 1단계 (SDK)         2단계 (Runtime)
#  소스코드      →     빌드 결과물만
#  SDK 도구      →     (버림)
#  NuGet 캐시    →     (버림)
#  ~700MB             ~220MB


# ── 1단계: 빌드 ────────────────────────────────
#.NET SDK 이미지 다운로드. 빌드할 때 필요한 도구
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build 
WORKDIR /src

COPY ["PortfolioProjectWeb.csproj", "./"]
RUN dotnet restore

COPY . .
# 전체 소스 복사 후 빌드. Release 모드로 빌드해서 /app/publish에 결과물 저장.
RUN dotnet publish -c Release -o /app/publish 

# ── 2단계: 실행 ────────────────────────────────
# ASP.NET 런타임 이미지 사용
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime 
WORKDIR /app

# 빌드 결과물만 복사해서 실행파일만 가져오기
COPY --from=build /app/publish . 

EXPOSE 8080

ENTRYPOINT ["dotnet", "PortfolioProjectWeb.dll"]