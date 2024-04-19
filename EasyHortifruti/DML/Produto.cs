using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyHortifruti.DML
{
    public class Produto
    {
        public int ID { get; set; }
        public string Descricao { get; set; }

        public int Unidade { get; set; }

        public double PrecoDeCompra { get; set; }

        public double PrecoDeVenda { get; set; }

        public double MargemLucro { get; set; }

        public int Grupo { get; set; }

        public int SubGrupo { get; set; }
    }
}
