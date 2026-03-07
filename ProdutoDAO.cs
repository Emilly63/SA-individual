using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SA_INDIVIDUAL
{
    public class ProdutoDAO
    {
        // Certifique-se de que a senha (Pwd) é a mesma do seu MySQL
        private string connectionString = "Server=localhost;Database=Industria40_Estoque;Uid=root;Pwd=;";

        public void Salvar(string nome, string codigo, int qtd, decimal preco)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string sql = "INSERT INTO Produtos (Nome, Codigo, Quantidade, Preco) VALUES (@nome, @cod, @qtd, @preco)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cod", codigo);
                cmd.Parameters.AddWithValue("@qtd", qtd);
                cmd.Parameters.AddWithValue("@preco", preco);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable BuscarTodos()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string sql = "SELECT * FROM Produtos";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void Atualizar(int id, string nome, string codigo, int qtd, decimal preco)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string sql = "UPDATE Produtos SET Nome=@nome, Codigo=@cod, Quantidade=@qtd, Preco=@preco WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cod", codigo);
                cmd.Parameters.AddWithValue("@qtd", qtd);
                cmd.Parameters.AddWithValue("@preco", preco);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Remover(int id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string sql = "DELETE FROM Produtos WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}