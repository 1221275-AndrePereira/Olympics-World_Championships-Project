@bat
@echo off
REM Executa dotnet run na pasta `WebApi` relativa a este ficheiro, usando apenas HTTPS

set "PROJECT_DIR=%~dp0/Backend_App/WebApi"

if not exist "%PROJECT_DIR%" (
  echo Pasta nao encontrada: %PROJECT_DIR%
  pause
  exit /b 1
)

pushd "%PROJECT_DIR%"

REM Ambiente e URL apenas HTTPS (ajuste a porta se necessario)
set "ASPNETCORE_ENVIRONMENT=Development"
set "ASPNETCORE_URLS=https://localhost:7096"

echo Iniciando aplicacao em %CD% ...
dotnet restore
dotnet run --launch-profile https

REM Aguarda alguns segundos para a API subir e abre o Swagger UI em HTTPS
timeout /t 5 >nul
start "" "https://localhost:7096/swagger/index.html"

popd
pause
