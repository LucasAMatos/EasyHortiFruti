using System.Collections.Generic;

namespace EasyHortifruti.DML
{
    public class Telefone
    {
        public string DDD { get; set; }

        public string Numero { get; set; }

        public TipoTelefone TipoTelefone { get; set; }

        public string TelefoneCompleto
        {
            get
            {
                Numero = Numero.Trim();

                if (Numero.Length == 0)
                    return string.Empty;

                string Final = Numero.Substring(Numero.Length - 4);

                return string.Concat(
                    "(",
                    DDD,
                    ")",
                    Numero.Replace(Final, string.Empty),
                    "-",
                    Final
                );
            }
        }
    }

    public class Telefones : List<Telefone>
    {
        public Telefones()
        { }

        public Telefones(List<Telefone> pList) : base(pList)
        {
        }
    }

    public enum TipoTelefone
    {
        pessoal,
        celular
    }
}