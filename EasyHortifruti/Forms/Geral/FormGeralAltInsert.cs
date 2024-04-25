using EasyHortifruti.DML;
using EasyHortifruti.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EasyHortifruti
{
    public partial class FormGeralAltInsert : FormBase
    {
        bool chamadoCNPJ;
        bool chamadoCEP;
        CNPJConsultado cnpj;
        CEPConsultado cepConsultado;
        private Telefone Fone
        {
            get
            {
                return new Telefone
                {
                    tipoTelefone = TipoTelefone.pessoal,
                    DDD = TbFone.Value.Length < 2 ? TbFone.Value.Substring(0, TbFone.Value.Length) : TbFone.Value.Substring(0, 2),
                    Numero = TbFone.Value.Length < 3 ? string.Empty : TbFone.Value.Substring(2)
                };
            }
        }
        private Telefone Celular
        {
            get
            {
                return new Telefone
                {
                    tipoTelefone = TipoTelefone.celular,
                    DDD = TbCelular.Value.Length < 2 ? TbCelular.Value.Substring(0, TbCelular.Value.Length) : TbCelular.Value.Substring(0, 2),
                    Numero = TbCelular.Value.Length < 3 ? string.Empty : TbCelular.Value.Substring(2)
                };
            }
        }

        public FormGeralAltInsert()
        {
            InitializeComponent();
        }

        private void FormGeralAltInsert_Load(object sender, EventArgs e)
        {
            LimparCampos();
            PreencheCampos();

        }

        private void RbPessoaFisica_CheckedChanged_1(object sender, EventArgs e)
        {
            PanelPF.Visible = RbPessoaFisica.Checked;
            PanelPJ.Visible = !RbPessoaJuridica.Checked;
            BtConsCNPJ.Visible = PanelPJ.Visible;
        }

        private void RbPessoaJuridica_CheckedChanged_1(object sender, EventArgs e)
        {
            PanelPF.Visible = !RbPessoaJuridica.Checked;
            PanelPJ.Visible = RbPessoaJuridica.Checked;
            BtConsCNPJ.Visible = PanelPJ.Visible;
        }
        private void BtCancelarGeralInserir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtGravaAltGeral_Click(object sender, EventArgs e)
        {
            Criticar();
            Geral pGeral = new Geral();

            pGeral.TipoPessoa = RbPessoaFisica.Checked ? TPFJ.Fisica : TPFJ.Juridica;
            pGeral.Classificacao = (Classificacao)CbClassificacao.SelectedIndex;
            pGeral.NomeFantasia = TbNomeFantasia.Text;
            pGeral.RazaoSocial = TbRazaoSocial.Text;
            pGeral.Contato = TbContato.Text;
            pGeral.DtNascFundacao = DtNascAbert.Value;
            pGeral.OrgaoExpedidor = tbOrgaoExpRg.Text;
            pGeral.OrgaoExpedidorUF = tbEstadoRg.Text;
            pGeral.CPF = tbCpf.Value;
            pGeral.CNPJ = TbCNPJ.Value;
            pGeral.RG = tbRg.Text;
            pGeral.IE = TbInscrEstadual.Text;
            pGeral.InscricaoMunicipal = TbInscrMunicipal.Text;
            pGeral.Sexo = cbSexo.SelectedIndex >= 0 ? (Sexo)cbSexo.SelectedIndex : Sexo.NaoDefinido;
            pGeral.EstadoCivil = (EstadoCivil)cbEstadoCivil.SelectedIndex >= 0 ? (EstadoCivil)cbEstadoCivil.SelectedIndex : EstadoCivil.NaoDefinido;
            pGeral.Email = TbEmail.Text;
            pGeral.PontoReferencia = TbPontoRef.Text;
                pGeral.Telefones = new Telefones
            {
                Fone,
                Celular
            };
            pGeral.Endereco = RetornarEnderecoTela();            

            if (Alterar)
            {
                pGeral.ID = Convert.ToInt32(LbIdCadGeral.Text);

                new ConexaoBD().AlterarGeral(pGeral);

                MessageBox.Show(string.Format("Geral Alterado com Sucesso!"));
                this.Close();
            }
            else
            {
                new ConexaoBD().InserirGeral(pGeral);

                DialogResult pNovaUnidade = MessageBox.Show(string.Format("{0} incluído com sucesso! Deseja cadastrar uma nova unidade?", pGeral.NomeFantasia), string.Empty, MessageBoxButtons.YesNo);
                if (pNovaUnidade == DialogResult.Yes)
                {
                    LimparCampos(this);
                    tabPage4.Text = string.Empty;
                }
                else
                    this.Close();
            }
        }

        private Endereco RetornarEnderecoTela()
        {
            Endereco enderecoRetorno = new Endereco();

            enderecoRetorno.CEP = TbCepEndereco.Value;
            enderecoRetorno.logradouro = TbRua.Text;
            enderecoRetorno.Numero = Convert.ToInt32(TbNumero.Text);
            enderecoRetorno.Complemento = TbComplemento.Text;
            enderecoRetorno.Bairro = TbBairro.Text;
            enderecoRetorno.Cidade = TbCidade.Text;
            enderecoRetorno.UF = CbUF.Text;
            return enderecoRetorno;
        }

        private void LimparCampos()
        {
            base.LimparCampos();
            CarregarComboSexo();
            CarregarComboEstadoCivil();
            CarregarComboClassificacao();
            CarregarComboUf();
            tabPage4.Text = string.Empty;
        }

        private void PreencheCampos()
        {
            try
            {
                if (Id > 0)
                {
                    Geral iGeral = new ConexaoBD().ConsultarGeralPorId(Id);

                    if (iGeral != null)
                    {
                        RbPessoaFisica.Checked = iGeral.TipoPessoa == TPFJ.Fisica;
                        RbPessoaJuridica.Checked = iGeral.TipoPessoa == TPFJ.Juridica;
                        TbNomeFantasia.Text = iGeral.NomeFantasia;
                        TbRazaoSocial.Text = iGeral.RazaoSocial;
                        TbContato.Text = iGeral.Contato;
                        DtNascAbert.Value = iGeral.DtNascFundacao;
                        tbOrgaoExpRg.Text = iGeral.OrgaoExpedidor;
                        tbEstadoRg.Text = iGeral.OrgaoExpedidorUF;
                        tbCpf.Text = iGeral.TipoPessoa == TPFJ.Fisica ? iGeral.CPF : string.Empty;
                        TbCNPJ.Text = iGeral.TipoPessoa == TPFJ.Juridica ? iGeral.CNPJ : string.Empty;
                        tbRg.Text = iGeral.TipoPessoa == TPFJ.Fisica ? iGeral.RG : string.Empty;
                        TbInscrEstadual.Text = iGeral.TipoPessoa == TPFJ.Juridica ? iGeral.IE : string.Empty;
                        TbInscrMunicipal.Text = iGeral.TipoPessoa == TPFJ.Juridica ? iGeral.InscricaoMunicipal : string.Empty;
                        cbSexo.SelectedIndex = (int)iGeral.Sexo;
                        cbEstadoCivil.SelectedIndex = (int)iGeral.EstadoCivil;

                        if (iGeral.Telefones != null && iGeral.Telefones.Count > 0)
                        {
                            TbFone.Text = iGeral.Telefones.FirstOrDefault(x => x.tipoTelefone == TipoTelefone.pessoal).TelefoneCompleto;
                            TbCelular.Text = iGeral.Telefones.FirstOrDefault(x => x.tipoTelefone == TipoTelefone.celular).TelefoneCompleto;
                        }
                        if (iGeral.Endereco != null)
                        {
                            TbCepEndereco.Text = iGeral.Endereco.CEP;
                            TbRua.Text = iGeral.Endereco.logradouro;
                            TbNumero.Text = iGeral.Endereco.Numero.ToString();
                            TbComplemento.Text = iGeral.Endereco.Complemento;
                            TbBairro.Text = iGeral.Endereco.Bairro;
                            TbCidade.Text = iGeral.Endereco.Cidade;
                            CbUF.Text = iGeral.Endereco.UF;
                        }

                        TbEmail.Text = iGeral.Email;
                        TbPontoRef.Text = iGeral.PontoReferencia;
                    }
                    LbIdCadGeral.Text = Id.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregarComboSexo()
        {
            cbEstadoCivil.CarregarValoresEnum<Sexo>();
        }

        private void CarregarComboEstadoCivil()
        {
            cbEstadoCivil.CarregarValoresEnum<EstadoCivil>();
        }

        private void CarregarComboClassificacao()
        {
            CbClassificacao.CarregarValoresEnum<Classificacao>();
        }

        private void CarregarComboUf()
        {
            CbUF.CarregarValoresEnum<UF>();
        }

        private async void BtConsCNPJ_ClickAsync(object sender, EventArgs e)
        {
            if (!chamadoCNPJ)
            {
                cnpj = await ConsultarCNPJ.consCNPJ(TbCNPJ.Value);
                chamadoCNPJ = true;
            }

            MessageBox.Show(cnpj.RazaoSocial);
        }

        private void TbCNPJ_Leave(object sender, EventArgs e)
        {
            chamadoCNPJ = false;
            cnpj = null;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!chamadoCNPJ)
            {
                cepConsultado = await ConsultarCEP.consCEP(TbCepEndereco.Value);
                chamadoCNPJ = true;
            }

            MessageBox.Show(cepConsultado.Logradouro);

        }
    }
}
