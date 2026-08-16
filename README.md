# Clean Architecture Essencial - Projeto de Estudo

Projeto de apoio ao curso "Clean Architecture Essencial - ASP .NET Core com C#" do professor Jose Carlos Macoratti.

Link do curso: https://www.udemy.com/course/clean-architecture-essencial-asp-net-core-com-c/?couponCode=25BBPMXINACTIVE

## Descrição

Este repositório contém a solução e os projetos desenvolvidos durante o curso, com implementação de camadas seguindo os princípios da Clean Architecture (Domain, Application, Infra, WebUI). O objetivo é estudar e praticar as boas práticas apresentadas nas aulas.

## Professor

Jose Carlos Macoratti

## Objetivos

- Aprender a estruturar uma aplicação ASP.NET Core usando Clean Architecture.
- Separar responsabilidades entre camadas (Domain, Application, Infra, WebUI).
- Implementar testes unitários básicos para entidades e regras de domínio.

## Pré-requisitos

- .NET SDK 6.0 ou superior instalado
- IDE (Visual Studio, VS Code, Rider) com suporte a .NET

## Tecnologias

- C#
- ASP.NET Core
- xUnit / MSTest (dependendo da configuração dos testes)

## Estrutura do projeto (visão geral)

- CleanArchMvc.Domain/: entidades e interfaces do domínio
- CleanArchMvc.Application/: serviços e lógica de aplicação
- CleanArchMvc.Infra.IoC/: injeção de dependência e composição de serviços
- CleanArchMvc.WebUI/: aplicação web ASP.NET Core (UI / Controllers / Views)
- CleanArchMvc.Domain.Tests/: testes de unidade do domínio

## Como executar

1. Restaurar pacotes:

```bash
dotnet restore
```

2. Compilar a solução:

```bash
dotnet build
```

3. Executar os testes (quando aplicável):

```bash
dotnet test
```

4. Rodar a aplicação Web:

```bash
dotnet run --project CleanArchMvc.WebUI
```

Após executar, abra o navegador em `https://localhost:5001` ou a URL mostrada no terminal.

## Contribuições

Este repositório é para estudo pessoal. Se quiser sugerir melhorias, abra uma issue descrevendo a proposta.

## Referências

- Curso: Clean Architecture Essencial - ASP .NET Core com C# (Jose Carlos Macoratti)

---

Arquivo criado como material de apoio ao curso; personalize conforme suas anotações e exercícios.