# Exemplo de Rest API com ASP.NET

## Objetivos

- Criação de uma webapi utilizando ASP.NET para aprofundamento na plataforma .NET.

## Requerimentos

- Instalar:
    - Visual Studio Code
    - .NET
    - MySQL: <https://dev.mysql.com/downloads/>

- Extensões no VSCode:
    - ThunderClient (pode usar o Postman se preferir).
    - Mysql.

## Criando o Projeto

~~~bash
# Instalando o dotnet entity framework
dotnet tool install --global dotnet-ef

# vendo informações sobre o entity framework
dotnet-ef

# criando a pasta para o projeto
mkdir Proj01_API
cd Proj01_API

# ver todos projetos possiveis de serem criados
dotnet new

# criando o projeto
dotnet new webapi

# executando o projeto de exemplo
dotnet run

# instalando os pacotes a serem utilizados
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.10
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.9
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.1
~~~

## Criando a base de dados a partir da extensão Mysql

- Siga os passos a seguir
    - Add Connection
    - Forneça user/pass
    - Inserir em appsettings.json as config de string de bd
    - Configurar a Startup.cs

## Criando tabelas a partir da classe Pessoa.cs com Migrations

~~~bash
# no dir do projeto - entity framework mapeará 
## mostra o que sera executado no dir migrations criado
dotnet ef migrations add PrimeiraMigration

# executa a criacao da tabela 
dotnet ef database update

# ~~~verifique a criação da tabela no mysql
~~~

## Criando a classe PessoaController

- Após criar a classe PessoaController execute o thunderclient para testar os métodos get, put, post e delete:
    - https://localhost:5001/pessoa/api

## Links

- <https://www.youtube.com/c/RalfLima/playlists>





