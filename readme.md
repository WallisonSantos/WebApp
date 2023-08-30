# C# MVC 2 [Readme](readme.md)


export DOTNET_ROOT=$HOME/.dotnet
export PATH=$PATH:$HOME/.dotnet:$HOME/.dotnet/tools

dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef

dotnet add package Swashbuckle.AspNetCore
dotnet add package Swashbuckle.AspNetCore.SwaggerUI
dotnet add package Swashbuckle.AspNetCore.Annotations
dotnet add package AutoMapper
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Oracle.EntityFrameworkCore

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Identity.UI
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Pomelo.EntityFrameworkCore.MySql
dotnet add package MySql.EntityFrameworkCore
dotnet remove package Pomelo.EntityFrameworkCore.MySql


Criar nova pasta do da Solu√ß√£o - Microservices
1∫: dotnet new sln                                  // Nova Solution
2∫: dotnet new mvc -f net7.0 -o FrontEnd            // Novo projeto MVC
3∫: dotnet new webapi -f net7.0 -o Service          // Novo Projeto API
4∫: dotnet sln add .\FrontEnd\FrontEnd.csproj       // Add a solution
5∫: dotnet sln add .\Service\Service.csproj         // Add a solution
6∫: dotnet restore                                  // procurar depend√™ncias e baixar para que dependencias seja compat√≠veis entre si sem conflitos
7∫: dotnet build                                    // compila o projeto e suas depend√™ncias em um conjunto de bin√°rios.

// Criar do zero
dotnet ef migrations add CreateIdentitySchema
dotnet ef database update

---- dotnet ef migrations add SeedProductDataTable

// remover uma migration
dotnet ef migrations remove

// Se o esquema de identidade j√° foi criado, mas n√£o aplicado ao banco de dados, apenas o comando para atualizar o banco de dados deve ser executado:
dotnet ef database update

// Criar um projeto: Sobrescrever o projeto
dotnet aspnet-codegenerator controller -name DepartmentController -m Department -dc App.Data.DepartmentContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --force

// Criar um projeto: inicial
dotnet aspnet-codegenerator controller -name DepartmentController -m Department -dc App.Data.DepartmentContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlserver




// appsettings.json

{
  "Logging": {
      "LogLevel": {
         "Default": "Information",
         "Microsoft.AspNetCore": "Warning"
      }
   },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      "SalesWebMvcContext": "server=localhost;userid=root;password=1234567;database=saleswebmvcappdb"
   }
}


// Conection Oracle

builder.Services.AddDbContext<SalesWebMvcContext>( options => options
   .UseOracle( builder
      .Configuration
      .GetConnectionString("SalesWebMvcContext") ?? throw new InvalidOperationException("Connection string 'SalesWebMvcContext' not found.")
   )
);


// Conection MySql

builder.Services.AddDbContext<MySqlContext>( options => options
   .UseMySQL( builder
      .Configuration
      .GetConnectionString("MicroservicesContext") ?? throw new InvalidOperationException("Connection string 'MicroservicesContext' nto found.")
   )
);