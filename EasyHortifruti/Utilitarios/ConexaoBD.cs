using EasyHortifruti.DML;
using Npgsql;
using System;
using System.Data;

namespace EasyHortifruti

{
    public class ConexaoBD
    {
        private string connectionString;

        #region Constructor
        public ConexaoBD()
        {
            connectionString = "Host=localhost;Username=Admin;Password=2125071216;Database=EasyHortifruti";
        }
        #endregion

        #region Métodos

        #region Geral
        public DataSet ConsultarTabela(string pNomeTabela)
        {
            string sql = string.Concat("SELECT * FROM ", pNomeTabela);

            return ExecutaEPreencheDataset(sql);
        }

        public DataSet ConsultarTabelaPorId(int pId, string pNomeTabela)
        {
            string sql = string.Concat("SELECT * FROM ", pNomeTabela, " WHERE id_recno=", pId.ToString());

            return ExecutaEPreencheDataset(sql);
        }
        public void ExcluirRegistro(int pId, string pNomeTabela)
        {
            string sql = String.Format("DELETE FROM {0} WHERE id_recno={1}", pNomeTabela, pId);

            ExecutaSemRetorno(sql);
        }
        #endregion

        #region Unidades
        public void InserirUnidades(string Abreviatura, string Descricao, string Observacao)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string sql = string.Concat("INSERT INTO ", TabelasScript.TabelaUnidades, "(abrev_unid, desc_unid, obs_unid) ",
                    "VALUES (@Abreviatura, @Descricao, @Observacao)");


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
            string sql = string.Format("UPDATE {0} SET abrev_unid='{1}',desc_unid='{2}',obs_unid='{3}' WHERE id_recno={4}", TabelasScript.TabelaUnidades, Abreviatura, Descricao, Observacao, pId);

            ExecutaSemRetorno(sql);
        }

        #endregion

        #region Grupo
        public void InserirGrupo(string Descricao, string Observacao, string MargemLucro)
        {
            string sql = string.Format("INSERT INTO {0} (nome_grupo, obs_grupo, margem_grupo) VALUES ('{1}', '{2}', {3})", TabelasScript.TabelaGrupos, Descricao, Observacao, MargemLucro);

            ExecutaSemRetorno(sql);
        }
        public void AlterarGrupo(int pId, string Descricao, string Observacao, string MargemLucro)
        {
            string sql = string.Format("UPDATE {0} SET nome_grupo='{1}',obs_grupo='{2}',margem_grupo={3} WHERE id_recno={4}", TabelasScript.TabelaGrupos, Descricao, Observacao, MargemLucro, pId);

            ExecutaSemRetorno(sql);
        }
        #endregion

        #region SubGrupo
        public DataSet ConsultarSubGrupo(int pId)
        {
            string sql = string.Concat("SELECT Sub.id_recno, grp.nome_grupo, Sub.nome_subgrupo, " +
                "Sub.margem_subgrupo FROM ", TabelasScript.TabelaSubGrupos, " Sub JOIN ", TabelasScript.TabelaGrupos, " grp ON Sub.id_grupo = grp.id_recno");

            if (pId > 0)
                sql += " where Sub.id_recno = " + pId.ToString();

            return ExecutaEPreencheDataset(sql);
        }
        public void InserirSubGrupo(string Descricao, int pGrupo, string MargemLucro)
        {
            string sql = string.Format("INSERT INTO {0} (nome_subgrupo, id_grupo, margem_subgrupo) VALUES ('{1}', {2}, {3})", TabelasScript.TabelaSubGrupos, Descricao, pGrupo, MargemLucro == string.Empty ? "null" : MargemLucro);

            ExecutaSemRetorno(sql);
        }
        
        public void AlterarSubGrupo(int pId, string Descricao, int pGrupo, string MargemLucro)
        {
            string sql = string.Format("UPDATE {0} SET nome_subgrupo='{1}',id_grupo={2}, " +
                "margem_subgrupo={3} WHERE id_recno={4}", TabelasScript.TabelaSubGrupos, Descricao, pGrupo, MargemLucro == string.Empty ? "null" : MargemLucro, pId);

            ExecutaSemRetorno(sql);
        }
        #endregion

        #region Produtos
        public DataSet ConsultarProdutos()
        {
            string sql = string.Concat("SELECT * FROM produtos P INNER JOIN GRUPOS G ON P.ID_GRUPO=G.ID_RECNO INNER JOIN SUBGRUPOS S ON P.ID_SUBGRUPO=S.ID_RECNO INNER JOIN UNIDADES U ON P.ID_UNIDADE=U.ID_RECNO");

            return ExecutaEPreencheDataset(sql);
        }
        public Produto ConsultarProdutoPorId(int pId)
        {
            string sql = string.Concat("SELECT * FROM produtos P INNER JOIN GRUPOS G ON P.ID_GRUPO=G.ID_RECNO INNER JOIN SUBGRUPOS S ON P.ID_SUBGRUPO=S.ID_RECNO INNER JOIN UNIDADES U ON P.ID_UNIDADE=U.ID_RECNO WHERE ID =", pId);

            DataSet ds = ExecutaEPreencheDataset(sql);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                return new Produto
                {
                    ID = Convert.ToInt32(dr["id_recno"]),
                    Descricao = dr["nome_produto"].ToString(),
                    IdGrupo = Convert.ToInt32(dr["id_grupo"]),
                    IdSubGrupo = Convert.ToInt32(dr["id_subgrupo"]),
                    MargemLucro = Convert.ToDouble(dr["margem_produto"]),
                    PrecoDeCompra = Convert.ToDouble(dr["pcocompra_produto"]),
                    PrecoDeVenda = Convert.ToDouble(dr["pcovenda_produto"]),
                    IdUnidade = Convert.ToInt32(dr["id_unidade"])
                };
            }

            return null;
        }

        public void IncluirProduto(Produto pProduto)
        {
            string sql = string.Empty;

            ExecutaSemRetorno(sql);
        }
        public void AlterarProduto(Produto pProduto)
        {
            string sql = string.Empty;

            ExecutaSemRetorno(sql);
        }
        #endregion
        #region Privado
        private DataSet ExecutaEPreencheDataset(string pSql)
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(pSql, conn))
                        adapter.Fill(dataSet);
                }
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ExecutaSemRetorno(string pSql)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(pSql, conn))
                {
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

                foreach (string script in new TabelasScript().Scripts)
                    new NpgsqlCommand(script, conn).ExecuteNonQuery();
            }

        }
        #endregion

        #endregion
    }
}
