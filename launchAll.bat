@echo off
echo Starting app servers.
:: backend

start "backend" cmd /k "cd ./backend/squares.api && dotnet run"

:: database on docker
start "database" cmd /k "docker compose up"

echo All servers launched.

pause