# Usage Guide

## Running Crypto-Price-Alert-Bot

```bash
dotnet run --project src/Crypto-Price-Alert-Bot/Crypto-Price-Alert-Bot.csproj
```

## CLI Arguments

| Argument | Description |
|----------|-------------|
| `--config` | Path to a custom appsettings file. |
| `--verbose` | Enable verbose logging. |

## Sample Data

The `data/samples.json` file contains realistic-looking simulated data for local testing.

## Extending

Add new providers by implementing the domain interfaces in `Core/Services` and registering them in `Program.cs`.
