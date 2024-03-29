# MarcenariaAPI

A MarcenariaAPI é uma API RESTful desenvolvida para gerenciar informações sobre funcionários e agendas em uma marcenaria. Esta API permite a criação, leitura, atualização e exclusão de registros de funcionários e agendas, bem como a associação de agendas a funcionários através de uma chave estrangeira.

## Tecnologias Utilizadas

- ASP.NET Core 
- Entity Framework Core
- SQLite (banco de dados)
- Swagger (documentação da API)

## Como Usar

### Pré-requisitos

- [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/) (ou qualquer IDE de sua preferência)
- [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet) instalado
- [SQLite](https://www.sqlite.org/download.html) (opcional, se desejar usar outro banco de dados, atualize a configuração)

### Configuração

1. Clone este repositório para sua máquina local:

   ```bash
   git clone https://github.com/seu-usuario/MarcenariaAPI.git

2. Abra o projeto no Visual Studio ou na sua IDE de escolha.

3. Configure a string de conexão com o banco de dados no arquivo appsettings.json:

   ```bash
    "ConnectionStrings": {
    "DefaultConnection": "Data Source=marcenaria.db"
   }

4. Abra o terminal e navegue até a pasta raiz do projeto e execute as migrações para criar o banco de dados:
      
   ```bash
   dotnet ef database update

### Endpoints da API
A API possui endpoints para as seguintes entidades:

## Funcionário
GET /api/Funcionario/listar: Retorna a lista de todos os funcionários cadastrados.
GET /api/Funcionario/buscar/{id}: Retorna um funcionário específico com base no ID.
POST /api/Funcionario/cadastrar: Cadastra um novo funcionário.
PUT /api/Funcionario/atualizar/{id}: Atualiza os detalhes de um funcionário existente.
DELETE /api/Funcionario/deletar/{id}: Deleta um funcionário com base no ID.

## Agenda
GET /api/Agenda/listar: Retorna a lista de todas as agendas cadastradas.
GET /api/Agenda/buscar/{id}: Retorna uma agenda específica com base no ID.
POST /api/Agenda/cadastrar: Cadastra uma nova agenda e associa a um funcionário existente.
PUT /api/Agenda/atualizar/{id}: Atualiza os detalhes de uma agenda existente.
DELETE /api/Agenda/deletar/{id}: Deleta uma agenda com base no ID.

## Fornecedor
GET /api/Fornecedor/listar: Retorna a lista de todos os fornecedores cadastrados.

GET /api/Fornecedor/buscar/{id}: Retorna um fornecedor específico com base no ID.

POST /api/Fornecedor/cadastrar: Cadastra um novo fornecedor.

PUT /api/Fornecedor/atualizar/{id}: Atualiza os detalhes de um fornecedor existente.

DELETE /api/Fornecedor/deletar/{id}: Deleta um fornecedor com base no ID.

## Cliente
GET /api/Cliente/listar: Retorna a lista de todos os clientes cadastrados.

GET /api/Cliente/buscar/{id}: Retorna um cliente específico com base no ID.

POST /api/Cliente/cadastrar: Cadastra um novo cliente.

PUT /api/Cliente/atualizar/{id}: Atualiza os detalhes de um cliente existente.

DELETE /api/Cliente/deletar/{id}: Deleta um cliente com base no ID.


Este sistema de gerenciamento abrangente permite à marcenaria manter um registro preciso de funcionários, agendas, fornecedores, clientes e muito mais. O uso da documentação da API Swagger facilita a exploração dos endpoints e a execução de operações CRUD.
DELETE /api/Agenda/deletar/{id}: Deleta uma agenda com base no ID.

