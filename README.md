# 🍔 Lanchonete do Torin - Projeto MVC

## 📝 Descrição
Projeto acadêmico desenvolvido para a disciplina de desenvolvimento web, utilizando o padrão ASP.NET Core MVC. A aplicação simula o site de uma lanchonete, onde é possível visualizar um cardápio de lanches, suas descrições e preços.

## ✔️ Critérios de Avaliação Atendidos
O projeto foi desenvolvido para atender aos seguintes requisitos:
- **Arquitetura:** ASP.NET Core MVC
- **Acesso a Dados:** Entity Framework Core como ORM
- **Banco de Dados:** SQLite com base de dados local (`lanchonete.db`)
- **Padrões de Projeto:** Implementação do Padrão Repositório para abstração de dados.
- **Frontend:** Personalização com Bootstrap, CSS customizado e JavaScript.
- **Versionamento:** Commits distribuídos ao longo do desenvolvimento no GitHub.
- **Documentação:** README detalhado.

## 🛠️ Tecnologias Utilizadas
- **Backend:** C#, .NET 8, ASP.NET Core MVC
- **Frontend:** HTML, CSS, JavaScript, Bootstrap 5
- **Banco de Dados:** SQLite
- **ORM:** Entity Framework Core 8

## 🚀 Como Executar o Projeto
1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/Unidesc-web/projetomvc-TorinJob.git](https://github.com/Unidesc-web/projetomvc-TorinJob.git)
    ```
2.  **Navegue até a pasta do projeto:**
    ```bash
    cd projetomvc-TorinJob/LanchoneteMVC
    ```
3.  **Restaure as dependências do .NET:**
    ```bash
    dotnet restore
    ```
4.  **Crie o banco de dados e aplique as migrações:**
    ```bash
    dotnet ef database update
    ```
5.  **Execute a aplicação:**
    ```bash
    dotnet run
    ```
6.  Abra seu navegador e acesse `https://localhost:[PORTA]` (a porta será indicada no terminal).
