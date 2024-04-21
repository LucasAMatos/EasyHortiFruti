using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyHortifruti.DML
{
    public class ContaAReceber
    {
        public int ID { get; set; }
        public int IdPedido { get; set; }
        public int IdFonte { get; set; }
        public double ValorPedido { get; set; }
        public double MargemPedido { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataRecebimento { get; set; }
}
}
