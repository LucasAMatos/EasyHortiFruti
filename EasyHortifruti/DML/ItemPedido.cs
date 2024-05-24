namespace EasyHortifruti.DML
{
    public class ItemPedido
    {
        public int Id_item { get; set; }

        public string DescrProduto { get; set; }

        public int Id_Produto { get; set; }

        public int Id_unidade { get; set; }

        public string Unidade { get; set; }

        public int Quantidade { get; set; }

        public decimal Valor_custo { get; set; }

        public decimal Percentual_lucro
        {
            get
            {
                return Valor_lucro / Valor_custo * 100;
            }
        }

        public decimal Total_item { get; set; }

        public decimal Valor_lucro { get; set; }
    }
}