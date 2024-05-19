using System;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;

namespace EasyHortifruti.DML
{
    public class Geral
    {
        public int ID { get; set; }

        public TPFJ TipoPessoa { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public string NomeCompleto { get; set; }

        public string Contato { get; set; }

        public Classificacao Classificacao { get; set; }

        public DateTime DtNascFundacao { get; set; }

        public string CPF { get; set; }

        public string CNPJ { get; set; }

        public string RG { get; set; }

        public string IE { get; set; }

        public string OrgaoExpedidor { get; set; }

        public string OrgaoExpedidorUF { get; set; }

        public string InscricaoMunicipal { get; set; }

        public Sexo Sexo { get; set; }

        public EstadoCivil EstadoCivil { get; set; }

        public Telefones Telefones { get; set; }

        public Endereco Endereco { get; set; }

        public string Email { get; set; }

        public string PontoReferencia { get; set; }

        public string ReferenciasComerciais { get; set; }

        public int PrazoPagamento { get; set; }

        public void CarregarGeral(DataSet ds)
        {
            if (ds?.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                if (dr["tppessoa"] != null)
                    TipoPessoa = dr["tppessoa"].ToString() == "J" ? TPFJ.Juridica : TPFJ.Fisica;

                if (dr["classificacao"] != null)
                    Classificacao = (Classificacao)Convert.ToInt32(dr["classificacao"]);

                if (dr["estadocivil"] != null && dr["estadocivil"] != DBNull.Value)
                    EstadoCivil = (EstadoCivil)Convert.ToInt32(dr["estadocivil"]);

                if (dr["sexo"] != null && dr["sexo"] != DBNull.Value)
                    Sexo = (Sexo)Convert.ToInt32(dr["sexo"]);

                if (dr["contato"] != null)
                    Contato = dr["contato"].ToString();

                if (dr["dtnascaber"] != null)
                    DtNascFundacao = Convert.ToDateTime(dr["dtnascaber"]);

                if (TipoPessoa == TPFJ.Fisica)
                {
                    if (dr["razaosocial"] != null)
                        NomeCompleto = dr["razaosocial"].ToString();

                    if (dr["cnpj_cpf"] != null && !string.IsNullOrEmpty(dr["cnpj_cpf"].ToString().Trim()))
                        CPF = Regex.Replace(dr["cnpj_cpf"].ToString(), @"(\d{3})(\d{3})(\d{3})(\d{2})", "$1.$2.$3-$4");

                    if (dr["ie_rg"] != null)
                        RG = dr["ie_rg"].ToString();
                }
                else
                {
                    if (dr["nomefantasia"] != null)
                        NomeFantasia = dr["nomefantasia"].ToString();

                    if (dr["razaosocial"] != null)
                        RazaoSocial = dr["razaosocial"].ToString();

                    if (dr["cnpj_cpf"] != null && !string.IsNullOrEmpty(dr["cnpj_cpf"].ToString().Trim()))
                        CNPJ = Regex.Replace(dr["cnpj_cpf"].ToString(), @"(\d{2})(\d{3})(\d{3})(\d{4})(\d{0,2})", "$1.$2.$3/$4-$5");

                    if (dr["ie_rg"] != null)
                        IE = dr["ie_rg"].ToString();
                }

                if (dr["inscrmunicipal"] != null)
                    InscricaoMunicipal = dr["inscrmunicipal"].ToString();

                if (Telefones == null)
                    Telefones = new Telefones();

                if (dr["dddfone"] != null)
                {
                    Telefone fone = new Telefone
                    {
                        TipoTelefone = TipoTelefone.pessoal,
                        Numero = dr["fone"].ToString(),
                        DDD = dr["dddfone"].ToString()
                    };
                    Telefones.Add(fone);
                }
                if (dr["dddcel"] != null)
                {
                    Telefone cel = new Telefone
                    {
                        TipoTelefone = TipoTelefone.celular,
                        Numero = dr["celular"].ToString(),
                        DDD = dr["dddcel"].ToString()
                    };
                    Telefones.Add(cel);
                }

                if (Endereco == null)
                    Endereco = new Endereco();

                if (dr["cep"] != null)
                    Endereco.CEP = Regex.Replace(dr["cep"].ToString(), @"(^\d{0,5})(\d{0,3})", "$1-$2");

                if (dr["logradouro"] != null)
                    Endereco.Logradouro = dr["logradouro"].ToString();

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

                if (dr["prazoPgto"] != null && !string.IsNullOrEmpty(dr["prazoPgto"].ToString()))
                    PrazoPagamento = Convert.ToInt32(dr["prazoPgto"].ToString());
            }
        }
    }

    #region ENUM

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
        [Description("Acre")]
        [DefaultValue("AC")]
        AC = 0,

        [Description("Alagoas")]
        [DefaultValue("AL")]
        AL = 1,

        [Description("Amapá")]
        [DefaultValue("AP")]
        AP = 2,

        [Description("Amazonas")]
        [DefaultValue("AM")]
        AM = 3,

        [Description("Bahia")]
        [DefaultValue("BA")]
        BA = 4,

        [Description("Ceará")]
        [DefaultValue("CE")]
        CE = 5,

        [Description("Distrito Federal")]
        [DefaultValue("DF")]
        DF = 6,

        [Description("Espirito Santo")]
        [DefaultValue("ES")]
        ES = 7,

        [Description("Goiás")]
        [DefaultValue("GO")]
        GO = 8,

        [Description("Maranhão")]
        [DefaultValue("MA")]
        MA = 9,

        [Description("Mato Grosso")]
        [DefaultValue("MT")]
        MT = 10,

        [Description("Mato Grosso do Sul")]
        [DefaultValue("MS")]
        MS = 11,

        [Description("Minas Gerais")]
        [DefaultValue("MG")]
        MG = 12,

        [Description("Pará")]
        [DefaultValue("PA")]
        PA = 13,

        [Description("Paraíba")]
        [DefaultValue("PB")]
        PB = 14,

        [Description("Paraná")]
        [DefaultValue("PR")]
        PR = 15,

        [Description("Pernambuco")]
        [DefaultValue("PE")]
        PE = 16,

        [Description("Piauí")]
        [DefaultValue("PI")]
        PI = 17,

        [Description("Rio de Janeiro")]
        [DefaultValue("RJ")]
        RJ = 18,

        [Description("Rio Grande do Norte")]
        [DefaultValue("RN")]
        RN = 19,

        [Description("Rio Grande do Sul")]
        [DefaultValue("RS")]
        RS = 20,

        [Description("Rondônia")]
        [DefaultValue("RO")]
        RO = 21,

        [Description("Roraima")]
        [DefaultValue("RR")]
        RR = 22,

        [Description("Santa Catarina")]
        [DefaultValue("SC")]
        SC = 23,

        [Description("São Paulo")]
        [DefaultValue("SP")]
        SP = 24,

        [Description("Sergipe")]
        [DefaultValue("SE")]
        SE = 25,

        [Description("Tocantins")]
        [DefaultValue("TO")]
        TO = 27
    }

    public enum Classificacao
    {
        [Description("Não Definido")]
        indefinido = 0,

        [Description("Cliente")]
        Cliente = 1,

        [Description("Fornecedor")]
        Fornecedor = 2,

        [Description("Funcionário")]
        Funcionario = 3,

        [Description("Sócio")]
        Socio = 4,

        [Description("Entregador")]
        Entregador = 5
    }

    #endregion ENUM
}