

# AutomationPortalPlanoAliados
Este projeto é um projeto de teste automatizados para o portal Plano Aliados, utilizando as tecnologias de automação de testes mais atuais, como Selenium, Reqnroll, xUnit, e .NET 8. O objetivo principal do projeto é validar o login com sucesso.

## Diretórios e Arquivos:
#### - Features: Contém os arquivos .feature, onde estão descritos os cenários de teste usando a linguagem Gherkin (Given/When/Then).
#### - Steps: Contém os arquivos de código onde as definições de passo para os testes são implementadas.
#### - Tests: Contém a configuração do WebDriver, execução dos testes e qualquer configuração inicial que precise ser feita.
#### - Drivers: Contém a configuração do WebDriver para diferentes navegadores (Chrome, Firefox, etc.).
#### - reqnroll.json: Arquivo de configuração do Reqnroll, que define como os arquivos .feature são vinculados aos testes.
#### - AutomationTest.csproj: Arquivo de configuração do projeto .NET.

## Ferramentas e Tecnologias Utilizadas
Este projeto utiliza as seguintes ferramentas e tecnologias:

- .NET 8: Plataforma de desenvolvimento para criar, compilar e executar os testes automatizados.
- Selenium WebDriver: Ferramenta para automação de navegadores, permitindo interações com a interface do usuário do portal.
- Reqnroll: Framework para automação de testes em BDD (Behavior-Driven Development), permitindo escrever testes em Gherkin e vinculá-los aos passos do código.
- xUnit: Framework de teste para execução dos testes automatizados.
- BoDi (Dependency Injection): Para gerenciar dependências como o WebDriver e outros objetos necessários nos testes.

#### NuGet Packages:
- Selenium.WebDriver
- Selenium.WebDriver.ChromeDriver
- Reqnroll
- xUnit
- BoDi

## Pré-requisitos
Antes de começar, verifique se você tem as seguintes ferramentas instaladas:

#### .NET 8 SDK: Para compilar e executar os testes.
#### Chrome WebDriver ou outro WebDriver compatível com o navegador que você deseja usar.

### Como Executar o Projeto
Siga os passos abaixo para configurar o projeto e executar os testes automatizados:

#### 1. Clonar o Repositório
git clone https://github.com/RenatoGregorio01/AutomationPortalPlanoAliados.git

#### 2. Restaurar Dependências
No diretório do projeto, execute o comando para restaurar as dependências NuGet:
dotnet restore
#### 3. Compilar o Projeto
Compile o projeto para garantir que todos os arquivos e dependências estejam corretos:
dotnet build

#### 4. Executar os Testes
Para executar os testes automatizados, use o comando abaixo:
dotnet test

Os testes serão executados, e você verá o resultado no terminal, indicando se os testes passaram ou falharam e a evidência está sendo armazenada na pasta /Sreenshots.
