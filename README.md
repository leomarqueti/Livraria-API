# Livraria

# 📚 Livraria Full Stack (Rocketseat Challenge)

> Um sistema completo de gerenciamento de livros, unindo a robustez do .NET no backend com a interatividade do React no frontend.

![Status](https://img.shields.io/badge/Status-Concluído-brightgreen)
![License](https://img.shields.io/badge/License-MIT-blue)

## 💻 Sobre o Projeto

Este projeto nasceu como um desafio do módulo de C# da **Rocketseat**: construir uma API para gerenciar uma livraria.

No entanto, decidi **ir além do escopo original** (que pedia apenas armazenamento em memória) para consolidar conhecimentos de arquitetura de software e desenvolvimento Full Stack. Transformei o desafio em uma aplicação real com persistência em banco de dados e interface gráfica.

## 🚀 Diferenciais e Evolução

O que foi solicitado vs. O que foi entregue:

* ✅ **Solicitado:** API REST com CRUD e validações.
* 🔥 **Entregue:**
    * **Persistência Real:** Substituí listas em memória pelo **SQL Server** usando **Entity Framework Core**.
    * **Frontend Integrado:** Desenvolvi uma interface em **React (Vite)** para consumir a API.
    * **Arquitetura:** Separação clara entre Entidades de Domínio, DTOs e Controllers.
    * **Segurança:** Configuração de CORS para comunicação segura entre Front e Back.

## 🛠 Tecnologias Utilizadas

**Backend:**
* C# / .NET 9
* Entity Framework Core (ORM)
* SQL Server
* Swagger (Documentação)

**Frontend:**
* ReactJS
* Vite
* Javascript (Fetch API)

**Conceitos:**
* RESTful API
* CRUD Operations
* Domain Driven Design (noções básicas de Entidades)
* Data Transfer Objects (DTOs)
* Migrations (Code First)

## ⚙️ Funcionalidades

* **Cadastrar Livro:** Validação de preço (não negativo) e campos obrigatórios.
* **Listar Livros:** Visualização de todo o catálogo persistido no banco.
* **Atualizar Livro:** Edição de dados existentes.
* **Remover Livro:** Exclusão física do registro no banco de dados.
* **Validações de Negócio:**
    * Preço e Estoque não podem ser negativos.
    * Título deve ter entre 2 e 120 caracteres.

## 📦 Como rodar o projeto

### Pré-requisitos
* .NET SDK 9.0+
* Node.js e NPM
* SQL Server (LocalDB ou Express)

### Passo 1: Backend (.NET)

1. Clone o repositório:
```bash
git clone [https://github.com/SEU-USUARIO/SEU-REPOSITORIO.git](https://github.com/SEU-USUARIO/SEU-REPOSITORIO.git)
Configure a Connection String no arquivo appsettings.json para apontar para o seu SQL Server local.

Aplique as Migrations para criar o banco de dados:

Bash

Update-Database
(Ou use o terminal do VS: dotnet ef database update)

Rode a API:

Bash

dotnet run
A API rodará em https://localhost:7220 (ou porta similar).

Passo 2: Frontend (React)
Entre na pasta do frontend:

Bash

cd front-livraria
Instale as dependências:

Bash

npm install
Rode o projeto:

Bash

npm run dev
O frontend estará disponível em http://localhost:5173.

📸 Screenshots
(Espaço reservado para você colocar os prints da tela do React e do Swagger)

👨‍💻 Autor
Desenvolvido por Marqueti.
