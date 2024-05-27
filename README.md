
# Loja Sonho de Café é E-commerce Simplificado de uma Cafeteria.

Este projeto é uma aplicação de e-commerce simplificada desenvolvida com Blazor web app, utilizando EF Core e um banco de dados SQL Server. A aplicação inclui componentes modernos como QuickGrid para exibição de dados e Blazored. LocalStorage para armazenamento local. A API web subjacente, construída com ASP.NET Core, permite operações CRUD completas refletindo diretamente no banco de dados, enquanto a biblioteca CsvHelper facilita a exportação de dados csv.
## Documentação

[Documentação](https://link-da-documentação)


## Funcionalidades

- Catálogo de Produtos: Navegação e exibição de produtos por categoria com opções de ordenação e paginação.
- Detalhes dos Produtos: Visualização detalhada de cada produto, incluindo descrição e foto.
- Promoções: Carousel dinâmico exibindo produtos em promoção.
- Gerenciamento de Produtos: Cadastro, reabastecimento, favoritamento e exclusão de produtos com validação de campos.
- Carrinho de Compras: Adição, remoção e ajuste de quantidade de itens no carrinho.
- Simulador de Pagamento: Processamento de compras com opções de pagamento via cartão, boleto ou dinheiro, refletindo na quantidade de estoque.
- Controle de Funcionamento: Restrições de pagamento fora do horário de funcionamento da loja.
- Relatório de Faturamento: Tabela de faturamento mensal com opção de download em formato do Excel (.csv).


## Autores

- [@Davi-Damartes](https://www.github.com/octokatherine)


## 🔗 Links
[![portfolio](https://img.shields.io/badge/my_portfolio-000?style=for-the-badge&logo=ko-fi&logoColor=white)](https://github.com/Davi-Damartes?tab=repositories)
[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/davi-lima-434605303/)



## Referência

 - [Referência  do projeto feito no canal do Jose Macoratti.](https://www.youtube.com/watch?v=lQaXpJFxbxM&list=PLJ4k1IC8GhW1GFJbYD2uo-_pLfdvX6Pu9)


## Rodando localmente

Clone o projeto

```bash
  git clone https://link-para-o-projeto
```

Entre no diretório do projeto

```bash
  cd my-project
```

Instale as dependências
```bash
  dotnet add package "Nomes.Dos.Pacotes"
```

Faça a criação do Banco de Dados:

```bash
  Add-migration "NomeMigration" -Context NomeDoSeuDB
```

Inicie o blazor server juntamente com a Api e rode o comando: 

```bash
  Dotnet watch run
```
ou através da tecla de Depuração: 

```bash
  F5
```


## Demonstração

https://github.com/Davi-Damartes/BlazorCafeteria/assets/167019873/99052200-a150-444d-851c-526b6b6f70c8
