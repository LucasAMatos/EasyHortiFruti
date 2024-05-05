using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EasyHortifruti.DML
{
    public class Pedido
    {
        public int ID { get; set; }

        public DateTime dataPedido { get; set; }

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
    }

    public enum StatusPedido
    {
        [Description("Selecione")]
        Selecione = 0,

        [Description("Pendente")]
        Pendente = 1,

        [Description("Não Aprovado")]
        NaoAprovado = 2,

        [Description("Aprovado")]
        Aprovado = 3,

        [Description("Em Execução")]
        EmExecucao = 4,

        [Description("Concluído")]
        Concluido = 5,

        [Description("Engregue - Finalizado")]
        Entregue = 6
    }
}