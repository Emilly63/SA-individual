-- Aluna: Emilly Sabrina Barbosa Almeida
-- Professor: Cláudio Iwakami
-- Data: 02.03.2026
DROP DATABASE IF EXISTS Industria40_Estoque;
CREATE DATABASE Industria40_Estoque;
USE Industria40_Estoque;
-- 2. Criar a Tabela de Produtos
CREATE TABLE Produtos (
    Id INT AUTO_INCREMENT PRIMARY KEY,  -- Identificador único e automático
    Nome VARCHAR(100) NOT NULL,         -- Nome do produto
    Codigo VARCHAR(50) NOT NULL,        -- Código único 
    Quantidade INT DEFAULT 0,           -- Saldo físico
    Preco DECIMAL(10, 2) NOT NULL,      -- Valor unitário
    UNIQUE (Codigo)                     -- Garante que o código não se repita
);

-- 3. Exemplo de Query para Relatório (Requisito Funcional)
-- Valor total do inventário
SELECT 
    SUM(Quantidade) AS TotalItens, 
    SUM(Quantidade * Preco) AS ValorTotalEstoque 
FROM Produtos;