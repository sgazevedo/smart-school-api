## Crie uma Web API com .NET 6 + EF Core + Docker

Repositório contendo implementação de código do curso "Crie uma Web API com .NET 6 + EF Core + Docker", do Vinicius de Andrade, disponível na Udemy.


## Criando Web API com AspNet Core

## Subindo conteiner para o Docker

1. Criar o Dockerfile
2. Executar o comando abaixo, via WSL. Esse comando criará a imagem "smartschool"
> docker build -t smartschool .
3. Executar o comando abaixo, via WSL. Esse comando criará o conteiner "smartschool-app" a partir da imagem "smartschool"
> docker run -d -p 5000:80 --name smartschool-app smartschool

## Criar volume
> docker volume create smartschooldb