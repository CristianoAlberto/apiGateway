# API Gateway - Verificação de Dados Externos

Este projeto consiste em um **API Gateway** que consome APIs externas para realizar verificações e buscas, como a validação de documentos como **BI** e **Passaporte**, além de recuperar a lista de províncias de Angola. Ele foi desenvolvido utilizando a biblioteca **RestSharp** para facilitar a comunicação HTTP com as APIs externas e retornar as informações com base na resposta da API.

## Funcionalidades

### 1. **Verificação de BI (Bilhete de Identidade)**
   - A API verifica se o número do **Bilhete de Identidade (BI)** está registrado ou não.
   - Endpoint: `/is-bi-valid/{bi}`

### 2. **Verificação de Passaporte**
   - A API verifica se o número do **Passaporte** é válido ou está registrado.
   - Endpoint: `/is-passport-valid/{passport}`

### 3. **Listar Províncias de Angola**
   - A API recupera a lista de todas as províncias de Angola.
   - Endpoint: `/all-provinces`

## Como Funciona

1. **Consumo de APIs Externas**:
   O projeto consome APIs externas para recuperar dados de províncias e verificar a validade de documentos. A biblioteca **RestSharp** é utilizada para realizar as requisições HTTP de forma simples e eficiente.

2. **Respostas e Validação**:
   A cada requisição feita ao API Gateway, ele realiza a chamada à API externa correspondente, validando a resposta para garantir que os dados sejam recuperados corretamente.

3. **Estrutura de Resposta**:
   A resposta da API contém informações sobre o sucesso ou falha da operação, bem como o conteúdo dos dados retornados pela API externa.

## Tecnologias Utilizadas

- **.NET 8** (ou versão superior)
- **RestSharp** (para requisições HTTP)
- **ASP.NET Core** (para criar a API Gateway)

## Como Executar o Projeto

### Pré-requisitos

- **.NET SDK 6.0** ou superior instalado em sua máquina.
- Editor de código (Visual Studio, Visual Studio Code, ou outro de sua preferência).

### Passos para Rodar o Projeto

1. Clone o repositório para sua máquina local:

   ```bash
   git clone https://github.com/seu-usuario/api-gateway.git

2. Navegue até o diretório do projeto:
   ```bash
   cd api-gateway
3. Restaure as dependências:
   ```bash
   dotnet restore
4. Execute o projeto:
   ```bash
   dotnet run

## Acessar o Swagger

Após iniciar a aplicação, acesse a interface do Swagger em seu navegador através do seguinte URL:
  ```bash
  http://localhost:<porta>/swagger/index.html

Att: Mudar a porta pela porta do projeto. Substitua <porta> pela porta exata onde o seu projeto está rodando. Isso pode variar dependendo da configuração do ambiente.
