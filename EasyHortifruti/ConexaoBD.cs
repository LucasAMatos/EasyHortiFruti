using Npgsql;
using System;
using System.Data;

namespace EasyHortifruti

{
    public class ConexaoBD
    {
        private string connectionString;

        public ConexaoBD()
        {
            connectionString = "Host=localhost;Username=hortifruti;Password=hortifruti;Database=EasyHortifruti";
        }

        public DataSet ConsultarTabela(string pNomeTabela)
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = string.Concat("SELECT * FROM ", pNomeTabela);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn))
                        adapter.Fill(dataSet);
                }
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InserirUnidades(string Abreviatura, string Descricao, string Observacao)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string sql = "INSERT INTO UNIDADES (abrev_unid, desc_unid, obs_unid) " +
                    "VALUES (@Abreviatura, @Descricao, @Observacao)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("Abreviatura", Abreviatura);
                    cmd.Parameters.AddWithValue("Descricao", Descricao);
                    cmd.Parameters.AddWithValue("Observacao", Observacao);

                    int idGerado = (int)cmd.ExecuteScalar();
                }
            }
        }

        public void DeletarPeloID(int pId, string pNomeTabela)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string sql = String.Format("DELETE FROM {0} WHERE ID_RECNO=@ID", pNomeTabela);

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("ID", pId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
