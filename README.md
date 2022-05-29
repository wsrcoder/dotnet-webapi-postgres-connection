# dotnet-webapi-postgres-connection
Exemplo de uso de tecnologia: dotnet webapi, Padrao de API REST, postgres SQL

Para executar o projeto:
  * git clone 
  * abra com vsCode e digite o comando CLI: dotnet build
  * O projeto estará acessivel em: https://localhost:7096/swagger/index.html


![dotnet-webapi-postgres-connection-01](https://user-images.githubusercontent.com/105994806/170884435-4908d04f-871c-441f-8ac4-048ebe1e2b8d.jpg)



Para construir o projeto os seguintes passos foram executados:

DOTNET CLI - Command Line Interface

instalacao do dotnet entity framework:
dotnet tool install --global dotnet-ef

verificar versao do entity framework:
dotnet-ef --version

criacao da aplicação web:
dotnet new webapi

para executar a aplicação:
    * selecione p arquivo que será debugado, por exemplo, program.cs ou algum Controller
    * Você pode setar breakpoints
    * vá em Run and Debug e escolha "Start Debugging"
    * A aplicação será startada em uma url parecida com https://localhost:[porta]/swagger/index.html


criada a pasta "Models"
excluidas as classes de exemplo WeatherForecastController.cs e WeatherForecast.cs


Pacotes para efetuar a Conexao com o Banco de Dados:

    -Entity Framework Core 
    - Entity Framework Core Design
    - Entity Framework Core Tools
    - Entity Framework Core PgSQL


* Criada a pasta Database
* Criada a pasta Repository

Criação das Migrations com o comando:
    dotnet ef migrations add InitialCreate

Para atualizar as migrations use o comando:
    dotnet ef database update
