### comandos executados
```shell
# migrations
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Pomelo.EntityFrameworkCore.MySql

dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet tool install --global dotnet-ef
dotnet ef migrations add MinhaMigracao
dotnet ef database update
dotnet ef database update
dotnet run
dotnet ef migrations add MinhaNovaColunaEndereco
dotnet ef database update
dotnet run
dotnet ef migrations add Minhamigracao
dotnet ef database update

# scaffold
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet aspnet-codegenerator controller -name ClientesController -m Cliente -dc DbContexto --relativeFolderPath Controllers --useDefaultLayout
```