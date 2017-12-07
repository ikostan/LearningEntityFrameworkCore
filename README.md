# Learning Entity Framework Core

Entity Framework is a data access technology of choice for .NET and ASP.NET data-oriented development. .NET developers appreciate how this object-relational mapper reduces the need for writing data-access code by providing the ability to work with relational data using domain-specific objects. How can you take advantage of this framework in your programming efforts? Reynold Adolphe shows you how in this course. Reynald demonstrates how to write code-based models and how to interact with data. He also explains how Entity Framework works with ASP.NET Core MVC and Web APIs. He covers creating a console app, creating an MVC app, and more.

### Topics include:
- Entity Framework (EF) overview
- Uses for EF
- Installing EF
- Creating entities
- Creating the DbContext
- Performing migrations
- Creating an MVC application
- Installing EF packages
- Reverse engineering the model
- Performing context and dependency injection
- Creating the controller and the view
- Logging
- Using SqlServerTypeMapper

### How to install EF Core:
- Open the project
- Go to Tools > NuGet Package Manager > Package Manager Console
- Type "Install-Package Microsoft.EntityFrameworkCore.SqlServer" and hit Enter
- Type "Install-Package Microsoft.EntityFrameworkCore.Tools" and hit Enter

### In order to be able to use DB reverse engineering please install following::
- Type "Install-Package Microsoft.EntityFrameworkCore.Design" and hit Enter
- Type "Install-Package Microsoft.EntityFrameworkCore.SqlServer.Design" and hit Enter

### In order to create a new Migration Schema:
- Open the project
- Go to Tools > NuGet Package Manager > Package Manager Console
- "Add-Migration <migration_name>" (type "Initial" in case it's your first migration)
- Hit Enter

### In order to update DB Schema (applay a new/lates migration):
- Open the project
- Go to Tools > NuGet Package Manager > Package Manager Console
- "Update-Database" 
- Hit Enter

Source: https://www.lynda.com/Entity-Framework-tutorials/Welcome/559226/591532-4.html
