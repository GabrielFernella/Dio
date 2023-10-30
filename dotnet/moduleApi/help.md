# Commands
1. dotnet new webapi
2. dotnet watch run (Executar a aplicação)
3. dotnet tool install --global dotnet-ef (Instalar pacotes utilitatios para dotnet)
4. dotnet add  package Microsoft.EntityFrameworkCore.Design (ORM para dotnet)
5. dotnet add  package Microsoft.EntityFrameworkCore.SqlServer (ORM para dotnet)
6. dotnet-ef migrations add CriacaoTabelaContato (Cria a migration)
7. dotnet-ef database update (Sobe a migration para o banco de dados)



# Settings
  Connection SQLServer: //"ConexaoPadrao": "Server=localhost\\sqlexpress;Initial Catalog=Agenda; Integrated Security=True"
  Connection Postgres: "ConexaoPadrao": "Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=myUsername;Password=myPassword;"