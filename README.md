# 📊 ProjetoDashboard

Um dashboard simples construído com ASP.NET Core Web API e Chart.js, que visualiza **vendas por dia** e **usuários ativos**, usando dados reais ou simulados armazenados em um banco SQL Server (LocalDB).

## 🚀 Tecnologias Utilizadas

- ✅ ASP.NET Core 8 (Web API)
- ✅ C#
- ✅ Entity Framework Core
- ✅ SQL Server LocalDB
- ✅ Chart.js (gráficos interativos)
- ✅ HTML + CSS (responsivo)
- ✅ Swagger (documentação da API)


## 📁 Estrutura do Projeto

ProjetoDashboard/
├── Controllers/
│ └── DashboardController.cs
├── Data/
│ └── DashboardContext.cs
│ └── Models.cs
├── wwwroot/
│ └── index.html // Página com os gráficos
├── appsettings.json
├── Program.cs
└── README.md


## 🔧 Como Executar Localmente

1. **Clone o repositório:**
    
2. Execute o projeto.

  A API estará disponível em https://localhost:5001/api/dashboard
  
  A página HTML com gráficos estará disponível em https://localhost:5001/

## 📈 Funcionalidades

-  Exibe gráfico de vendas diárias (linha).
  
-  Exibe gráfico de usuários ativos por dia (barras).
  
-  Integração direta com API .NET e banco de dados SQL.
  
-  Layout responsivo com CSS moderno e leve.


