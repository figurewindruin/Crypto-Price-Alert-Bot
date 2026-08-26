# Architecture

## Overview

Crypto-Price-Alert-Bot is a modular console tracker for alerts data. It separates concerns into distinct layers:

- **Core**: domain models, service interfaces, validation, and exceptions.
- **Infrastructure**: logging, configuration loading, and external endpoint communication.
- **Entry Point**: `Program.cs` wires dependencies and starts the application.

## Layers

```
Program
  |
  +-- TrackerService
        |
        +-- PriceProvider
        +-- StorageProvider
        +-- AlertEngine
        +-- Configuration
```

## Key Components

| Component | Responsibility |
|-----------|---------------|
| `ITrackerService` | Orchestrates data refresh, storage, and alerting. |
| `IPriceProvider` | Fetches current price or alerts data from endpoints. |
| `IStorageProvider` | Persists snapshots and tracked assets in memory. |
| `IAlertEngine` | Evaluates thresholds and emits notifications. |
| `IConfigurationLoader` | Loads settings from `appsettings.json` and environment variables. |
| `ILogger` | Writes structured log output to the console. |
