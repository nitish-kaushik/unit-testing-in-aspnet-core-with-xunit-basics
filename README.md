# Library API

A .NET library management API built with ASP.NET Core, featuring a RESTful API for managing books with comprehensive unit tests using XUnit.

## Features

- **RESTful API** for book management
- **Entity Framework Core** with In-Memory and SQL Server support
- **Comprehensive Unit Tests** with XUnit
- **Helper Classes** for common operations (Math, String, Date/Time)
- **Late Fee Calculator** for library book returns

## Project Structure

```
src/
├── LibraryApi/                 # Main API project
│   ├── Controllers/           # API Controllers
│   ├── Data/                  # Database context and initialization
│   ├── Helpers/               # Utility classes
│   ├── Models/                # Data models
│   └── Repositories/          # Data access layer
│
└── LibraryApi.UnitTests/      # Unit test project
    ├── Controllers/           # Controller tests
    ├── Helpers/               # Helper class tests
    └── TestsData/             # Test data providers
```

## Technologies Used

- **.NET 10.0**
- **ASP.NET Core**
- **Entity Framework Core**
- **XUnit** for testing
- **SQL Server** and **In-Memory Database**

## Getting Started

### Prerequisites

- .NET 10.0 SDK or later
- SQL Server (optional, can use In-Memory database)