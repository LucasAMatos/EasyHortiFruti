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
    }
}
