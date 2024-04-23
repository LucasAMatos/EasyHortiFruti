using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyHortifruti.DML
{
    public class Geral
    {
        public int ID { get; set; }

        public TPFJ TipoPessoa { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public string Contato { get; set; }

        public Classificacao Classificacao { get; set; }

        public DateTime DtNascFundacao { get; set; }

        public string CPF {  get; set; }

        public string CNPJ { get; set; }

        public string RG { get; set; }

        public string IE { get; set; }

        public string OrgaoExpedidor { get; set; }

        public string OrgaoExpedidorUF { get; set; }

        public string InscricaoMunicipal {  get; set; }

        public Sexo Sexo { get; set; }

        public EstadoCivil EstadoCivil { get; set; }

        public Telefones Telefones { get; set; }

        public Endereco Endereco { get; set; }

        public string Email { get; set; }

        public string PontoReferencia { get; set; }

        public string ReferenciasComerciais { get; set; }

        public void CarregarGeral(DataSet ds)
        {
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                if (dr["tppessoa"] != null)
                    TipoPessoa = dr["tppessoa"].ToString() == "J" ? TPFJ.Juridica  : TPFJ.Fisica;

                if (dr["classificacao"] != null)
                    Classificacao = (Classificacao)Convert.ToInt32(dr["classificacao"]);

                if (dr["nomefantasia"] != null)
                    NomeFantasia = dr["nomefantasia"].ToString();

                if (dr["razaosocial"] != null)
                    RazaoSocial = dr["razaosocial"].ToString();

                if (dr["contato"] != null)
                    Contato = dr["contato"].ToString();

                if (dr["dtnascaber"] != null)
                    DtNascFundacao = Convert.ToDateTime(dr["dtnascaber"]);

                if (dr["cnpj"] != null)
                    CNPJ = dr["cnpj"].ToString();

                if (dr["cpf"] != null)
                    CPF = dr["cpf"].ToString();

                if (dr["rg"] != null)
                    RG = dr["rg"].ToString();

                if (dr["inscrestadual"] != null)
                    IE = dr["inscrestadual"].ToString();

                if (dr["inscrmunicipal"] != null)
                    InscricaoMunicipal = dr["inscrmunicipal"].ToString();

                if (dr["orgexpedidor"] != null)
                    OrgaoExpedidor = dr["orgexpedidor"].ToString();

                if (dr["ufrgexped"] != null)
                    OrgaoExpedidorUF = dr["ufrgexped"].ToString();

                if (Telefones == null)
                    Telefones = new Telefones();

                if (dr["dddfone"] != null)
                {
                    Telefone fone = new Telefone();
                    fone.tipoTelefone = TipoTelefone.pessoal;
                    fone.Numero = dr["fone"].ToString();
                    fone.DDD = dr["dddfone"].ToString();
                    Telefones.Add(fone);
                }
                if (dr["dddcel"] != null)
                {
                    Telefone cel = new Telefone();
                    cel.tipoTelefone = TipoTelefone.celular;
                    cel.Numero = dr["celular"].ToString();
                    cel.DDD = dr["dddcel"].ToString();
                    Telefones.Add(cel);
                }

                if (Endereco == null)
                    Endereco = new Endereco();

                if (dr["cep"] != null)
                    Endereco.CEP = dr["cep"].ToString();
                if (dr["logradouro"] != null)
                    Endereco.logradouro = dr["logradouro"].ToString();
                if (dr["Numero"] != null)
                    Endereco.Numero = Convert.ToInt32(dr["Numero"]);

                if (dr["complemento"] != null)
                    Endereco.Complemento = dr["complemento"].ToString();

                if (dr["bairro"] != null)
                    Endereco.Bairro = dr["bairro"].ToString();

                if (dr["cidade"] != null)
                    Endereco.Cidade = dr["cidade"].ToString();

                if (dr["uf"] != null)
                    Endereco.UF = dr["uf"].ToString();

                if (dr["pontoreferencia"] != null)
                    PontoReferencia = dr["pontoreferencia"].ToString();

                if (dr["email"] != null)
                    Email = dr["email"].ToString();
            }
        }
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

    public enum TPFJ
    {
        [Description("Fisica")]
        [DefaultValue("F")]
        Fisica,
        [Description("Juridica")]
        [DefaultValue("J")]
        Juridica
    }

    public enum UF
    { 
        AC,
        AM,

    }

    public enum Classificacao
    {
        [Description("Cliente")]
        Cliente = 0,
        [Description("Fornecedor")]
        Fornecedor = 1,
        [Description("Funcionário")]
        Funcionario = 2,
        [Description("Sócio")]
        Socio = 3
    }
}
