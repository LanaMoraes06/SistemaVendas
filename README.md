# Sistema de Vendas (Imperio Motors)

Um sistema completo para gestao de frota e vendas de veiculos desenvolvido com **ASP.NET Core MVC**, **Entity Framework Core** e **SQLite**. 

O projeto apresenta uma interface elegante, clean e responsiva, inspirada no design de grandes plataformas automotivas do mercado, focando na melhor experiencia de usuario para o controle do negocio.

## Funcionalidades

O sistema possui um fluxo de CRUD (Create, Read, Update, Delete) completo e relacional para os seguintes modulos:

*   **Veiculos:** Controle de estoque, caracteristicas (modelo, cor, ano) e valores.
*   **Marcas:** Cadastro de fabricantes para categorizacao da frota.
*   **Vendas:** Registro de transacoes financeiras, vinculando o veiculo negociado, o comprador, o vendedor e os valores de custo e lucro.
*   **Clientes:** Gestao da carteira de compradores.
*   **Cidades:** Mapeamento de regioes de atuacao para vinculos de clientes.

## Tecnologias Utilizadas

*   **Backend:** C# com .NET 10
*   **Framework Web:** ASP.NET Core MVC
*   **ORM:** Entity Framework Core
*   **Banco de Dados:** SQLite
*   **Frontend:** HTML5, CSS3, Bootstrap (Customizado com CSS puro para um Design System limpo e arredondado)
*   **Geracao de Codigo:** .NET AspNet Core CodeGenerator (Scaffolding)

## Como Executar o Projeto

Certifique-se de ter o [.NET SDK 10](https://dotnet.microsoft.com/) instalado em sua maquina.

1. **Clone o repositorio:**
   ```bash
   git clone https://github.com/SEU-USUARIO/SistemaVendas.git
   cd SistemaVendas
   ```

2. **Restaure as dependencias do projeto:**
   ```bash
   dotnet restore
   ```

3. **Gere o banco de dados (Migrations):**
   ```bash
   dotnet ef database update
   ```
   *Nota: Este comando criara automaticamente o arquivo `vendas_veiculos.db` na raiz do projeto com as tabelas necessarias.*

4. **Inicie o servidor:**
   ```bash
   dotnet run
   ```

5. **Acesse no navegador:**
   Abra o link exibido no terminal (geralmente `http://localhost:5000` ou `https://localhost:5001`).
