using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using static EasyHortifruti.DML.Pedido;

namespace EasyHortifruti.DML
{
    public class Pedido
    {
        public int ID { get; set; }

        public DateTime DataPedido { get; set; }

        public int IdPessoa { get; set; }

        public StatusPedido StatusPedido { get; set; }

        public int PrazoPagamento { get; set; }

        public DateTime DataPrev { get; set; }

        public DateTime DataEntrega { get; set; }

        public DateTime DataConclusao { get; set; }

        public List<ItemPedido> Itens { get; set; }

        public string Observacoes { get; set; }

        public decimal TotalPedido { get; set; }

        public decimal ValorDesconto { get; set; }

        public decimal TotalGeral { get; set; }

        public decimal ValorLucro { get; set; }

        public string Nome { get; set; }

        public void CarregaPedido(DataSet ds)
        {
            if (ds?.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                if (dr["id_recno"] != null)
                    ID = Convert.ToInt32(dr["id_recno"]);

                if (dr["dataPedido"] != null)
                    DataPedido = Convert.ToDateTime(dr["dataPedido"]);

                if (dr["id_geral"] != null)
                    IdPessoa = Convert.ToInt32(dr["id_geral"]);

                if (dr["statuspedido"] != null)
                    StatusPedido = RetornaStatusPedido(dr["statuspedido"].ToString());

                if (dr["prazopgto"] != null)
                    PrazoPagamento = Convert.ToInt32(dr["prazopgto"]);

                if (dr["dataprev"] != null)
                    DataPrev = Convert.ToDateTime(dr["dataprev"]);

                if (dr["dataentrega"] != null)
                    DataEntrega = Convert.ToDateTime(dr["dataentrega"]);

                if (dr["dataconclusao"] != null)
                    DataConclusao = Convert.ToDateTime(dr["dataconclusao"]);

                if (dr["obspedido"] != null)
                    Observacoes = dr["obspedido"].ToString();

                if (dr["totalcompra"] != null)
                    TotalPedido = Convert.ToDecimal(dr["totalcompra"]);

                if (dr["descpedido"] != null)
                    ValorDesconto = Convert.ToDecimal(dr["descpedido"]);

                if (dr["totalvenda"] != null)
                    TotalGeral = Convert.ToDecimal(dr["totalvenda"]);

                if (dr["vlrlucro"] != null)
                    ValorLucro = Convert.ToDecimal(dr["vlrlucro"]);
            }
        }
        public class Pedidos : List<Pedido>
        {
            public Pedidos()
            { }

            public void CarregarPedidos(DataSet ds)
            {
                this.Clear();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Pedido pedido = new Pedido();
                    if (dr["id_recno"] != null)
                        pedido.ID = Convert.ToInt32(dr["id_recno"]);

                    if (dr["dataPedido"] != null)
                        pedido.DataPedido = Convert.ToDateTime(dr["dataPedido"]);

                    if (dr["nCliente"] != null)
                        pedido.Nome = dr["nCliente"].ToString();

                    if (dr["statuspedido"] != null)
                        pedido.StatusPedido = RetornaStatusPedido(dr["statuspedido"].ToString());

                    if (dr["dataentrega"] != null)
                        pedido.DataEntrega = Convert.ToDateTime(dr["dataentrega"]);

                    if (dr["obspedido"] != null)
                        pedido.Observacoes = dr["obspedido"].ToString();

                    if (dr["totalcompra"] != null)
                        pedido.TotalPedido = Convert.ToDecimal(dr["totalcompra"]);

                    if (dr["vlrlucro"] != null)
                        pedido.ValorLucro = Convert.ToDecimal(dr["vlrlucro"]);

                    this.Add(pedido);
                }
            }
        }

        public static StatusPedido RetornaStatusPedido(string pStatus)
        {
            switch (pStatus)
            {
                case "Não Aprovado":
                    return StatusPedido.NaoAprovado;

                case "Aprovado":
                    return StatusPedido.Aprovado;

                case "Em Execução":
                    return StatusPedido.EmExecucao;

                case "Concluído":
                    return StatusPedido.Concluido;

                case "Entregue - Finalizado":
                    return StatusPedido.Entregue;

                default:
                    return StatusPedido.Pendente;
            }
        }
    }

    public enum StatusPedido
    {
        [Description("Pendente")]
        Pendente = 0,

        [Description("Não Aprovado")]
        NaoAprovado = 1,

        [Description("Aprovado")]
        Aprovado = 2,

        [Description("Em Execução")]
        EmExecucao = 3,

        [Description("Concluído")]
        Concluido = 4,

        [Description("Entregue - Finalizado")]
        Entregue = 5,

        [Description("Todos")]
        Todos = 99
    }
}