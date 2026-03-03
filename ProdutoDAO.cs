using System;
using System.Data;
using MySql.Data.MySqlClient; // Ajustado para MariaDB/MySQL

public class ProdutoDAO
{
    // String de conexão para MariaDB/MySQL (ajuste user e password)
    private string connectionString = @"Server=localhost;Port=3306;Database=Industria40_Estoque;Uid=root;Pwd=";

    public void Salvar(string nome, string codigo, int qtd, decimal preco)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            string sql = "INSERT INTO Produtos (Nome, Codigo, Quantidade, Preco) VALUES (@nome, @cod, @qtd, @preco)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cod", codigo);
            cmd.Parameters.AddWithValue("@qtd", qtd);
            cmd.Parameters.AddWithValue("@preco", preco);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public DataTable BuscarTodos()
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            string sql = "SELECT Id, Nome, Codigo, Quantidade, Preco FROM Produtos";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}