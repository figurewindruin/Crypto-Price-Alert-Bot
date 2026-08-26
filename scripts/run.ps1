$ErrorActionPreference = "Stop"
$project = Join-Path $PSScriptRoot "..\src\Crypto-Price-Alert-Bot\Crypto-Price-Alert-Bot.csproj"
dotnet run --project $project -- @args
