using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Testando Inserção e Consulta de Dados ---");
        
        try
        {
            ProdutoDAO dao = new ProdutoDAO();

            // 1. Tenta inserir um produto fictício
            Console.WriteLine("Cadastrando um produto de teste...");
            dao.Salvar("Teclado Mecânico", "TEC001", 10, 250.00m);
            Console.WriteLine("✅ Inserção concluída!");

            // 2. Busca todos os produtos para conferir
            Console.WriteLine("\n--- Lista de Produtos no Banco ---");
            DataTable lista = dao.BuscarTodos();

            if (lista.Rows.Count == 0)
            {
                Console.WriteLine("O banco está conectado, mas a tabela está vazia.");
            }
            else
            {
                foreach (DataRow linha in lista.Rows)
                {
                    Console.WriteLine($"ID: {linha["Id"]} | Nome: {linha["Nome"]} | Qtd: {linha["Quantidade"]} | Preço: R$ {linha["Preco"]}");
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n✅ TESTE COMPLETO: O sistema grava e lê dados com sucesso!");
            Console.ResetColor();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n❌ ERRO DURANTE O TESTE:");
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }
    }
}