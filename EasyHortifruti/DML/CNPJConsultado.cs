using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyHortifruti.DML
{
    public class CNPJConsultado
    {
        [JsonProperty("cnpj_raiz")]
        public string CnpjRaiz { get; set; }
        [JsonProperty("razao_social")]
        public string RazaoSocial { get; set; }
        [JsonProperty("capital_social")]
        public string CapitalSocial { get; set; }
        [JsonProperty("responsavel_federativo")]
        public string ResponsavelFederativo { get; set; }
        [JsonProperty("atualizado_em")]
        public DateTime AtualizadoEm { get; set; }
        public Porte Porte { get; set; }
        [JsonProperty("natureza_juridica")]
        public NaturezaJuridica NaturezaJuridica { get; set; }
        [JsonProperty("qualificacao_do_responsavel")]
        public QualificacaoDoResponsavel QualificacaoDoResponsavel { get; set; }
        public List<Socio> Socios { get; set; }
        public object Simples { get; set; }
        public Estabelecimento Estabelecimento { get; set; }

        public static CNPJConsultado FromJson(string json)
        {
            return JsonConvert.DeserializeObject<CNPJConsultado>(json);
        }
    }

    public class Qualificacao
    {
        public string Id { get; set; }
        public string Descricao { get; set; }
    }

    public class Pais
    {
        public string Id { get; set; }
        public string Iso2 { get; set; }
        public string Iso3 { get; set; }
        public string Nome { get; set; }
        public string ComexId { get; set; }
    }

    public class Socio
    {
        [JsonProperty("cpf_cnpj_socio")]
        public string CpfCnpjSocio { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public DateTime DataEntrada { get; set; }
        public string CpfRepresentanteLegal { get; set; }
        public object NomeRepresentante { get; set; }
        public string FaixaEtaria { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public string PaisId { get; set; }
        public Qualificacao QualificacaoSocio { get; set; }
        public object QualificacaoRepresentante { get; set; }
        public Pais Pais { get; set; }
    }

    public class AtividadesSecundaria
    {
        public string Id { get; set; }
        public string Secao { get; set; }
        public string Divisao { get; set; }
        public string Grupo { get; set; }
        public string Classe { get; set; }
        public string Subclasse { get; set; }
        public string Descricao { get; set; }
    }

    public class AtividadePrincipal
    {
        public string Id { get; set; }
        public string Secao { get; set; }
        public string Divisao { get; set; }
        public string Grupo { get; set; }
        public string Classe { get; set; }
        public string Subclasse { get; set; }
        public string Descricao { get; set; }
    }

    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public int IbgeId { get; set; }
    }

    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IbgeId { get; set; }
        public string SiafiId { get; set; }
    }

    public class IE
    {
        public string InscricaoEstadual { get; set; }
        public bool Ativo { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public Estado Estado { get; set; }
    }

    public class Estabelecimento
    {
        public string Cnpj { get; set; }
        public List<AtividadesSecundaria> AtividadesSecundarias { get; set; }
        public string CnpjRaiz { get; set; }
        public string CnpjOrdem { get; set; }
        public string CnpjDigitoVerificador { get; set; }
        public string Tipo { get; set; }
        public object NomeFantasia { get; set; }
        public string SituacaoCadastral { get; set; }
        public DateTime DataSituacaoCadastral { get; set; }
        public DateTime DataInicioAtividade { get; set; }
        public object NomeCidadeExterior { get; set; }
        public string TipoLogradouro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Ddd1 { get; set; }
        public string Telefone1 { get; set; }
        public object Ddd2 { get; set; }
        public object Telefone2 { get; set; }
        public object DddFax { get; set; }
        public object Fax { get; set; }
        public object Email { get; set; }
        public object SituacaoEspecial { get; set; }
        public object DataSituacaoEspecial { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public AtividadePrincipal AtividadePrincipal { get; set; }
        public Pais Pais { get; set; }
        public Estado Estado { get; set; }
        public Cidade Cidade { get; set; }
        public object MotivoSituacaoCadastral { get; set; }
        public List<IE> InscricoesEstaduais { get; set; }
    }

    public class Porte
    {
        public string Id { get; set; }
        public string Descricao { get; set; }
    }

    public class NaturezaJuridica
    {
        public string Id { get; set; }
        public string Descricao { get; set; }
    }

    public class QualificacaoDoResponsavel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
