# 🏭 Sistema de Controlo de Estoque - Indústria 4.0

Este projeto foi desenvolvido como parte da **Situação de Aprendizagem (SA)** da Unidade Curricular Desenvolvimento de Sistemas, sob a orientação do Professor **Cláudio Iwakami** O sistema foca no gerenciamento de inventário para fábricas inteligentes, utilizando tecnologias de desenvolvimento desktop e persistência de dados em SQL.

## 🚀 Tecnologias Utilizadas
* **Editor de Código:** Visual Studio Code (VS Code)
* **Linguagem:** C# (.NET 8.0) 
* **Interface:** Windows Forms (WinForms) 
* **Banco de Dados:** MySQL 
* **Arquitetura:** Padrão DAO (Data Access Object) 

## 📋 Especificações do Sistema

### Requisitos Funcionais (RF)
* **RF01:** Cadastro completo de produtos: Nome, Código, Quantidade e Preço.
* **RF02:** Listagem automática e consulta em tempo real via `DataGridView`.
* **RF03:** Atualização de dados de produtos selecionados.
* **RF04:** Remoção de itens do estoque através do ID.
* **RF05:** Geração de relatório consolidado (Soma de itens e Valor Patrimonial).

### Regras de Negócio (RN)
* **RN01:** O **Código** do produto deve ser único para evitar duplicidade.
* **RN02:** O campo **Id** deve ser gerado automaticamente (Chave Primária).
* **RN03:** O cálculo do **Valor Total** deve multiplicar a quantidade pelo preço unitário.

## 📊 Modelagem Técnica

### Diagrama de Classes UML
A arquitetura do sistema separa a interface do usuário da lógica de banco de dados, utilizando as classes `Form1` e `ProdutoDAO`.



### Diagrama de Banco de Dados (DER)
A tabela `Produtos` foi estruturada para garantir a integridade referencial e unicidade de registros.



## 💻 Como Executar o Projeto
1. Clone este repositório para a sua máquina local.
2. No seu MySQL Workbench, execute o script SQL contido no ficheiro `banco.sql`.
3. Certifique-se de que a `connectionString` no arquivo `ProdutoDAO.cs` possui as suas credenciais locais.
4. No terminal da pasta do projeto, execute:
   ```bash
   dotnet run


