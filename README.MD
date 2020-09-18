# API

<p align="center">
  <img src="https://img.shields.io/static/v1?label=dotnet core&message=framework&color=blue&style=for-the-badge&logo=.Net "/>
  <img src="https://img.shields.io/static/v1?label=Asp Net core&message=framework&color=blue&style=for-the-badge&logo=.Net"/>
   <img src="http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=YELLOW&style=for-the-badge"/>
</p>

> Status do Projeto: Em desenvolvimento :warning:


### Topico

:small_blue_diamond: [Descrição do projeto](#descrição-do-projeto)

:small_blue_diamond: [Funcionalidades](#funcionalidades)

:small_blue_diamond: [Pré-requisitos](#pré-requisitos)

:small_blue_diamond: [Como rodar a aplicação](#como-rodar-a-aplicação-arrow_forward)

## Descrição do Projeto
Um projeto de uma API em .NET Core para cadastro de pessoas infectadas integrada a um cluster MongoDB, que pode ser local ou através do service cloud Mongo Atlas.

## Funcionalidades :hammer_and_wrench:

:heavy_check_mark: Cadastrar pessoas infectadas.

:heavy_check_mark: Atualiza  cadastro  de pessoas infectadas.

:heavy_check_mark: Deleta cadastro  de pessoas infectadas.




![certificado](https://i.ibb.co/f8HWXxt/Swagger-API.png)

## Pré-requisitos
:warning: [.Net Core - SDK]([https://dotnet.microsoft.com/download/dotnet-core/3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1))
:warning: [.AspNetCore - Runtime]([https://dotnet.microsoft.com/download/dotnet-core/3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1))

## Como rodar a aplicação :arrow_forward:

No terminal, clone o projeto:
```
 git clone https://github.com/
```
 Entre na pasta do projeto:
```
 cd API/API
```
Instale os pacotes:
```
dotnet restore
```
Rode o comando:
```
dotnet build
```
Excute a aplicação:
```
dotnet run
```
Pronto, agora e possível acessar aplicação a partir da rota  [http://localhost:5000/swagger/index.html](http://localhost:5000/swagger/index.html)

##  Linguagens, dependencias e pacotes utilizados :books:
### 
-  [MongoDB.Driver](https://docs.mongodb.com/drivers/csharp): versão 2.10.4
-  [Swashbuckle.AspNetCore](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&tabs=visual-studio): versão 5.5.1

## Casos de Uso

- Post - Cadastro de infectado
```
{
   "dataNascimento":  "2020-08-02T17:33:12.572Z",  
   "sexo":  "string",  
   "latitude":  0,  
   "longitude":  0
}
```
- Put - Atualização do Cadastro
```
{  
  "dataNascimento":  "2020-08-02T17:37:15.239Z",  
  "sexo":  "string",  
  "latitude":  0,  
  "longitude":  0  
}
```
- Deletar Cadastro
```
{
  "dataNascimento":  "2020-08-02T17:37:15.239Z"
}
```

## Tarefas em aberto

:memo: Implementação de testes 

:memo: Criação de endpoint para login

:memo: Autenticação com JsonWebToken(JWT)


## Desenvolvedor
|Nome|E-mail|
|--|--|
|Carlos Cunha|cesc88santana@gmail.com|





