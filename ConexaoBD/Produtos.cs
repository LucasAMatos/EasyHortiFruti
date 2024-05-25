using System.Data;
using Npgsql;

namespace ConexaoBD
{
    public class Produtos
    {
        private string connectionString = "Host=localhost;Username=Admin;Password=2125071216;Database=EasyHortifruti";

        public DataTable GetData()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM YourTable"; // Substitua YourTable pelo nome da sua tabela
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}