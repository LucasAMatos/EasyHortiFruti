using Npgsql;
using System;
using System.Data;
using System.Reflection.Emit;

namespace EasyHortifruti

{
    public class ConexaoBD
    {
        private string connectionString;
               

        public ConexaoBD()
        {
            connectionString = "Host=localhost;Username=Admin;Password=2125071216;Database=EasyHortifruti";
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
        public DataSet ConsultarTabelaPorId(int pId, string pNomeTabela)
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = string.Concat("SELECT * FROM ", pNomeTabela, " WHERE id_recno=", pId.ToString());

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
        public DataSet ConsultarSubGrupo(int pId, string pNomeTabela)
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = string.Concat("SELECT Sub.id_recno, grp.nome_grupo, Sub.nome_subgrupo, " +
                        "Sub.margem_subgrupo FROM ", TabelasScript.TabelaSubGrupos,  " Sub JOIN ", TabelasScript.TabelaGrupos , " grp ON Sub.id_grupo = grp.id_recno") ;                       


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

        #region Unidades
        public void InserirUnidades(string Abreviatura, string Descricao, string Observacao)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string sql = "INSERT INTO UNIDADES (abrev_unid, desc_unid, obs_unid) " +
                    "VALUES (@Abreviatura, @Descricao, @Observacao)";


                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("abreviatura", Abreviatura);
                    cmd.Parameters.AddWithValue("Descricao", Descricao);
                    cmd.Parameters.AddWithValue("observacao", Observacao);

                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }
        }
        public void AlterarUnidades(int pId, string Abreviatura, string Descricao, string Observacao)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string sql = string.Format("UPDATE UNIDADES SET abrev_unid='{0}',desc_unid='{1}',obs_unid='{2}' WHERE id_recno=@ID", Abreviatura, Descricao, Observacao);
            
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("ID", pId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ExcluirUnidade(int pId, string pNomeTabela)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string sql = String.Format("DELETE FROM {0} WHERE id_recno=@ID", pNomeTabela);

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("ID", pId);

                    cmd.ExecuteNonQuery();                    
                }
            }
        }
        #endregion

        #region Grupo
        public void InserirGrupo(string Descricao, string Observacao, string MargemLucro)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string sql = string.Format("INSERT INTO {0} (desc_grupo, obs_grupo, margem_grupo) VALUES ('{1}', '{2}', {3})", TabelasScript.TabelaGrupos, Descricao, Observacao, MargemLucro);

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }
        }
        public void AlterarGrupo(int pId, string Descricao, string Observacao, string MargemLucro)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string sql = string.Format("UPDATE {0} SET desc_grupo='{1}',obs_grupo='{2}',margem_grupo={3} WHERE id_recno=@ID", TabelasScript.TabelaGrupos, Descricao, Observacao, MargemLucro);

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("ID", pId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ExcluirGrupo(int pId, string pNomeTabela)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string sql = String.Concat("DELETE * FROM ", TabelasScript.TabelaGrupos, " WHERE id_recno=@ID");

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("ID", pId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void InserirSubGrupo(string Descricao, int pGrupo, string MargemLucro)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string sql = string.Concat("INSERT INTO ", TabelasScript.TabelaSubGrupos, " (desc_grupo, id_grupo, margem_subgrupo) ",
                             "VALUES (@Descricao, @Grupo, @MargemLucro)");

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("Descricao", Descricao);
                    cmd.Parameters.AddWithValue("Grupo", pGrupo);
                    cmd.Parameters.AddWithValue("MargemLucro", MargemLucro);

                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region SubGrupo
        public void AlterarSubGrupo(int pId, string Descricao, int pGrupo, string MargemLucro)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string sql = string.Format("UPDATE SUBGRUPO SET nome_subgrupo='{0}',id_grupo={1}, " +
                    "margem_subgrupo='{2}' WHERE id_recno=@ID", Descricao, pGrupo, MargemLucro);

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("ID", pId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ExcluirSubGrupo(int pId, string pNomeTabela)
        {            
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string sql = String.Concat("DELETE * FROM SUBGRUPO WHERE id_recno=@ID");

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("ID", pId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region TabelasBD
        public void CriaTabelasBD()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                foreach(string script in new TabelasScript().Scripts)
                    new NpgsqlCommand(script, conn).ExecuteNonQuery();                
            }

        }
        #endregion
    }
}
