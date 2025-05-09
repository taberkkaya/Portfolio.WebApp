# Portfolio.WebApp

## 🚀 Technologies

- .NET Core Web API
- TS.CleanArchitecture
- TS.GenericRepository
- TS.Result
- Clean Architecture
- Result Pattern
- CQRS Pattern
- Entity Framework Core
- MediatR
- AutoMapper
- JwtBearer
- TypeScript
- Angular

## appsettings.json Template

```json
{
    "Logging": {
        "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "SqlServerLocal": "Data Source=YOUR_LOCAL_SERVER;Initial Catalog=YOUR_DB_NAME;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False",
        "SqlServer": "Server=YOUR_REMOTE_SERVER;Database=YOUR_REMOTE_DB;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;TrustServerCertificate=True;"
    },
    "Jwt": {
        "Issuer": "YOUR_ISSUER",
        "Audience": "YOUR_AUDIENCE",
        "SecretKey": "YOUR_SECRET_KEY"
    }
}

## 🖥 Frontend

The frontend of the application is built with **Angular** and **TypeScript**. After configuring the API, you can also set up the frontend to interact with the Web API.

## 🛠 Troubleshooting

- **500.30 Error**: If you encounter this error, make sure the **Upload** folder exists in the publish directory. The error occurs when the folder is missing.
```
