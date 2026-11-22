# University Project

This repository contains three Windows Forms applications built with .NET Framework 4.8:

- `Aplikacja login` - login and registration application
- `apk_user` - user application
- `apk.admin backup` - admin application

## Database configuration

The applications require access to a SQL Server database compatible with the included typed datasets. They read the connection string from the `PROJEKT_CONNECTION_STRING` environment variable. No database credentials are included in this repository.

Set the variable in the terminal used to start the application, replacing the placeholders with your own database settings:

```powershell
$env:PROJEKT_CONNECTION_STRING = "Server=tcp:YOUR_SERVER.database.windows.net,1433;Initial Catalog=YOUR_DATABASE;User ID=YOUR_USER;Password=YOUR_PASSWORD;Encrypt=True;TrustServerCertificate=False"
```

Open the relevant solution in Visual Studio and start the desired application. The database and its schema must already be provisioned.
