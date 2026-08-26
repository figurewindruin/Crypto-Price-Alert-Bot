$ErrorActionPreference = "Stop"
$sln = Join-Path $PSScriptRoot "..\Crypto-Price-Alert-Bot.sln"
dotnet test $sln --configuration Release --verbosity normal
