# C# MVC 2[label](readme.md)

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


Criar nova pasta do da Solução - Microservices
1º: dotnet new sln                                  // Nova Solution
2º: dotnet new mvc -f net7.0 -o FrontEnd            // Novo projeto MVC
3º: dotnet new webapi -f net7.0 -o Service          // Novo Projeto API
4º: dotnet sln add .\FrontEnd\FrontEnd.csproj       // Add a solution
5º: dotnet sln add .\Service\Service.csproj         // Add a solution
6º: dotnet restore                                  // procurar dependências e baixar para que dependencias seja compatíveis entre si sem conflitos
7º: dotnet build                                    // compila o projeto e suas dependências em um conjunto de binários.

// Criar do zero
dotnet ef migrations add CreateIdentitySchema
dotnet ef database update

---- dotnet ef migrations add SeedProductDataTable

// remover uma migration
dotnet ef migrations remove

// Se o esquema de identidade já foi criado, mas não aplicado ao banco de dados, apenas o comando para atualizar o banco de dados deve ser executado:
dotnet ef database update

// Criar um projeto: Sobrescrever o projeto
dotnet aspnet-codegenerator controller -name DepartmentController -m Department -dc App.Data.DepartmentContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --force

// Criar um projeto: inicial
dotnet aspnet-codegenerator controller -name DepartmentController -m Department -dc App.Data.DepartmentContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlserver



// appsettings.json
//
{
  "Logging": {
      "LogLevel": {
         "Default": "Information",
         "Microsoft.AspNetCore": "Warning"
      }
   },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      "SalesWebMvcContext": "User Id=SYSDBA;Password=root;Data Source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))) (CONNECT_DATA = (SERVICE_NAME = servicename)))"
   }
}
// appsettings.json
//
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
//
builder.Services.AddDbContext<SalesWebMvcContext>( options => options
   .UseOracle( builder
      .Configuration
      .GetConnectionString("SalesWebMvcContext") ?? throw new InvalidOperationException("Connection string 'SalesWebMvcContext' not found.")
   )
);
// Conection MySql
//
builder.Services.AddDbContext<MySqlContext>( options => options
   .UseMySQL( builder
      .Configuration
      .GetConnectionString("MicroservicesContext") ?? throw new InvalidOperationException("Connection string 'MicroservicesContext' nto found.")
   )
);


dotnet aspnet-codegenerator identity -h
dotnet aspnet-codegenerator identity --listFiles
dotnet aspnet-codegenerator identity --useDefaultUI





##
# SHA256:VP9Fncuxy+0mPzb6lN6lVqS8Yl9B5FCqfKOgV/dZyiw wallisontiagoassis206@outlook.com
# Nova SSH: ssh-keygen -t ed25519 -C "wallisontiagoassis206@outlook.com"
# Inicializa��o autom�tica do ssh-agent no Git para Windows:
# Voc� pode executar ssh-agent automaticamente quando abre o shell do Bash ou do Git. Copie as seguintes linhas e cole-as no arquivo ~/.profile ou ~/.bashrc no shell do Git:
##
env=~/.ssh/agent.env

agent_load_env () { test -f "$env" && . "$env" >| /dev/null ; }

agent_start () {
    (umask 077; ssh-agent >| "$env")
    . "$env" >| /dev/null ; }

agent_load_env

# agent_run_state: 0=agent running w/ key; 1=agent w/o key; 2=agent not running
agent_run_state=$(ssh-add -l >| /dev/null 2>&1; echo $?)

if [ ! "$SSH_AUTH_SOCK" ] || [ $agent_run_state = 2 ]; then
    agent_start
    ssh-add
elif [ "$SSH_AUTH_SOCK" ] && [ $agent_run_state = 1 ]; then
    ssh-add
fi

unset env




dotnet --list--sdks
rm .HomeController.cs.swp          // Remover um arquivo
rm *.pdf		                   // Remover todos os arquivos em PDF localizados no diretório atual
mkdir ViewModels                   // Nova pasta
mv ErrorViewModel.cs /ViewModels   // Mover arquivo para uma determinada pasta

wget -c https://repo.mysql.com//mysql-apt-config_0.8.26-1_all.deb
sudo dpkg -i mysql-apt-config_0.8.26-1_all.deb
sudo apt update
sudo apt install mysql-server
sudo mysql_secure_installation

sudo systemctl status mysql             // Verificar o status do banco
sudo systemctl start  mysql             // Startar banco
sudo systemctl enable mysql             // Habilitar o inicio junto com o Sistema
sudo mysql -u root -p                   // Acessar por linha de comando o banco -- 5711Co@
SHOW DATABASES;                         // Mostar schema
quit                                    // Sair do banco
status                                  // Info do banco
SHOW VARIABLES WHERE Variable_ame = 'port';    // identificar a porta conectada
USE information_schema;                 // acessar um determinado database
SHOW tables;                            // Mostrar tabelas do database
CREATE DATABASE microservices_shopping  // Criar banco de dados

dotnet aspnet-codegenerator controller -name MoviesController -m Movie -dc MvcMovie.Data.MvcMovieContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlserver

dotnet aspnet-codegenerator identity -dc aspnIdentity.Data.ApplicationDbContext --files "Account.Register;Account.Login;Account.Logout"
dotnet aspnet-codegenerator identity MyEdit Edit -m Movie -dc ApplicationContext -outDir Views/Movies






Usage: aspnet-codegenerator [arguments] [options]

Argumentos:
gerador Nome do gerador. Verifique os geradores disponíveis abaixo.

Opções:
-p|--project Caminho para o arquivo .csproj no projeto.
-n|--nuget-package-dir
-c|--configuration Configuração do projeto (Possíveis valores: Debug/ Release)
-tfm|--target-framework Estrutura de destino a ser usada. (Nome curto da pasta do tfm. por exemplo, net46)
-b|--build-base-path
--no-build

Gerador de código selecionado: identidade

Opções do gerador:
--dbContext|-dc : Nome do DbContext a ser usado ou gerado (se não existir).
--files|-fi : Lista de arquivos separados por ponto e vírgula para scaffold. Use a opção --listFiles para ver as opções disponíveis.
--listFiles|-lf : Lista os arquivos que podem ser scaffoldados usando a opção '--files'.
--userClass|-u : Nome da classe de usuário a ser gerada.
--databaseProvider|-dbProvider : Provedor de banco de dados a ser usado. As opções incluem 'sqlserver' (padrão), 'sqlite', 'cosmos', 'postgres'.
--force|-f : Use esta opção para sobrescrever os arquivos existentes.
--useDefaultUI|-udui : Use esta opção para configurar a identidade e usar a IU padrão.
--layout|-l : especifique um arquivo de layout personalizado a ser usado.
--generateLayout|-gl : Use esta opção para gerar um novo _Layout.cshtml
--bootstrapVersion|-b : Especifique a versão de inicialização. Valores válidos: '3', '4'. O padrão é 4.
--useSqLite|-sqlite : sinalizador para especificar se DbContext deve usar SQLite em vez de SQL Server.
