using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyHortifruti.DML
{
    public class Pedido
    {
        public int ID { get; set; }

        public DateTime dataPedido { get; set; }

        public string StatusPedido { get; set; }

        public int IdFonte { get; set; }

        public DateTime DataPrev { get; set; }

        public int PrazoPagamento { get; set; }

        public DateTime DataEntrega { get; set; }

        public DateTime DataConclusao { get; set; }

        public int IdProduto { get; set; }

        public int QuantidadeProduto{ get;set;}

        public double ValorCompra { get; set; }
        
        public double ValorVenda { get; set; }

        public double TotalVenda { get; set; }

        public double PercentualLucro { get; set; }
    }
}
