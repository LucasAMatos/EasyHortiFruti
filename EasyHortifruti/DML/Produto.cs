using System;
using System.Data;

namespace EasyHortifruti.DML
{
    public class Produto
    {
        public int ID { get; set; }
        public string Descricao { get; set; }

        public int IdUnidade { get; set; }

        public string Unidade { get; set; }

        public double PrecoDeCompra { get; set; }

        public double PrecoDeVenda { get; set; }

        public double MargemLucro { get; set; }

        public int IdGrupo { get; set; }

        public string Grupo { get; set; }

        public int IdSubGrupo { get; set; }

        public string SubGrupo { get; set; }

        public void CarregarProduto(DataSet ds)
        {
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                if(dr["id_recno"] != null)
                    ID = Convert.ToInt32(dr["id_recno"]);

                if (dr["nome_produto"] != null)
                    Descricao = dr["nome_produto"].ToString();

                if (dr["id_grupo"] != null)
                    IdGrupo = Convert.ToInt32(dr["id_grupo"]);

                if (dr["nome_grupo"] != null)
                    Grupo = dr["nome_grupo"].ToString();

                if (dr["id_subgrupo"] != null)
                    IdSubGrupo = Convert.ToInt32(dr["id_subgrupo"]);

                if (dr["nome_subgrupo"] != null)
                    SubGrupo = dr["nome_subgrupo"].ToString();

                if (dr["margem_produto"] != null)
                    MargemLucro = Convert.ToDouble(dr["margem_produto"]);

                if (dr["pcocompra_produto"] != null)
                    PrecoDeCompra = Convert.ToDouble(dr["pcocompra_produto"]);

                if (dr["pcovenda_produto"] != null)
                    PrecoDeVenda = Convert.ToDouble(dr["pcovenda_produto"]);

                if (dr["id_unidade"] != null)
                    IdUnidade = Convert.ToInt32(dr["id_unidade"]);

                if (dr["abrev_unid"] != null)
                    Unidade = dr["abrev_unid"].ToString();
            }
        }
    }
}
