# Instruções de utilização
O arquivo global.json define a versão em que o SDK vai compilar o projeto, estamos utilizando o SDK na versão **6.0.420**

# Arquitetura da Api

![Arquitetura da Api](https://prnt.sc/eWNIzNHrOi5V)


# Comandos básicos CLI

**OBS: Os comandos devem ser executados estando na pasta src/src (pasta onde se encontra o arquivo API.sln)**

### 1. Criar uma solution

~~~javascript
dotnet new sln --name ['Nome da Solution']
//Ex:
dotnet new sln --name API
~~~

### 2. Criar um projeto WebApi
~~~javascript
// -n tag para especificar o nome
// -o tag para especificar a pasta de saída do projeto
// --no-https configuração para não ser https
dotnet new webapi -n ['nome do projeto'] -o ['pasta de saída do projeto'] --no-https

//Ex:
dotnet new webapi -n application -o Api.Application --no-https
~~~

### 3. Vincular o projeto na solution

**OBS: TODO PROJETO DEVE SER VINCULADO À SOLUTION**

~~~js
dotnet sln add ['pasta de saída do projeto']

//Ex:
dotnet sln add Api.Application
~~~

### 4. Criar uma classe de library

**OBS: TODA classe de library DEVE SER VINCULADO À SOLUTION**

~~~js
// -n tag para especificar o nome
// -o tag para especificar a pasta de saída do projeto
// -f tag para especificar qual framework e versão deverá ser usada para a criação da classe
dotnet new classlib -n ['Nome da classe'] -o['pasta de saída da classe'] -f ['framework e versão']

//Ex:
dotnet new classlib -n Service -o Api.Service -f netcoreapp3.1
~~~


### 5. Restore da aplicação

**O comando dotnet restore é usado no ambiente de desenvolvimento .NET Core para restaurar as dependências de um projeto.**

~~~js
dotnet restore
~~~

### 6. Build da aplicação

**O comando dotnet build é usado no ambiente de desenvolvimento .NET Core para compilar um projeto e suas dependências.**

~~~js
// Ao fazer o build automaticamente também faz o:
// dotnet restore
dotnet build
~~~

dotnet ef migrations add Inital_Migration

### 7. Gerar Migration

**O comando deve ser executado estando dentro da pasta Api.Data.**

~~~js
//Inital_Migration é o nome da migration então pode ser trocado
dotnet ef migrations add Inital_Migration
~~~


### 8. Executar Migration

**O comando deve ser executado estando dentro da pasta Api.Data.**

~~~js

dotnet ef database update
~~~

# Passo a Passo

### Api.Domain

	1 - Entities (Entidades)
	2 - Dtos
	3 - Interfaces
	4 - Models

---
	
### Api.Data

	1 - Mapping Entities (Mapear as Entidades)
	2 - MyContext (Atualizar)
	3 - Fazer Migrações (dotnet ef migrations add Inital_Migration)
	4 - Atualizar o Banco de Dados (dotnet ef database update)
	5 - Implementations (Implementação da Classe BaseEntity)
            5.1 - Api.Domain.Repository
	        5.2 - Api.Data.Implementations

---
### Api.CrossCutting

       1 - DtoToModelProfile
       2 - EntityToDtoProfile
       3 - ModelToEntityProfile

---
 	
### Api.Service
       1 - Criar Services

----
	
### Api.CrossCutting
       1 - Configure Repository
       2 - Configure Service  	

---
### Api.Application
       1 - Controller



## Histórico de versões

### [0.0.1] - 06/04/2024
#### Commit Inicial
- Adicionado scopo inical do projeto baseado no DDD
