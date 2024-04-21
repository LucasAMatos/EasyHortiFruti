using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyHortifruti.DML
{
    public class Geral
    {
        public int ID { get; set; }

        public string NomeFantasia { get; set; }

        public string Contato { get; set; }

        public string Classificacao { get; set; }

        public DateTime DtNascFundacao { get; set; }

        public string CPF {  get; set; }

        public string RGIE { get; set; }

        public DateTime RGDataExepedicao { get; set; }

        public string OrgaoExpedidor { get; set; }

        public string OrgaoExpedidorUF { get; set; }

        public string InscricaoMunicipal {  get; set; }

        public Sexo Sexo { get; set; }

        public EstadoCivil EstadoCivil { get; set; }
        
        public string Naturalidade { get; set; }

        public Telefones Telefones { get; set; }

        public Endereco Endereco { get; set; }

        public string Email { get; set; }

        public string PontoReferencia { get; set; }

        public string ReferenciasComerciais { get; set; }
    }

    public enum EstadoCivil
    {
        [Description("Não definido")]
        NaoDefinido = 0,
        [Description("Casado")]
        Casado = 1,
        [Description("Solteiro")]
        Solteiro = 2,
        [Description("Divorciado")]
        Divorciado = 3,
        [Description("Viúvo")]
        Viuvo = 4,
        [Description("Desquitado")]
        Desquitado = 5,
        [Description("Companheiro")]
        Companheiro = 6
    }
    public enum Sexo
    {
        [Description("Não definido")]
        [DefaultValue("N")]
        NaoDefinido = 0,
        [Description("Masculino")]
        [DefaultValue("M")]
        Masculino = 1,
        [Description("Feminino")]
        [DefaultValue("F")]
        Feminino = 2
    }
}
