﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyHortifruti.DML
{
    public class ItemPedido
    {
        public int id_item { get; set; }

        public string descrProduto { get; set; }

        public int id_Produto { get; set; }

        public int id_unidade { get; set; }

        public string unidade { get; set; }

        public int quantidade { get; set; }

        public decimal valor_custo { get; set; }

        public decimal percentual_lucro { get; set; }

        public decimal total_item { get; set; }

        public decimal valor_lucro { get; set; }
    }
}
