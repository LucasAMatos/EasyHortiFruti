using EasyHortifruti.DML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EasyHortifruti
{
    public partial class FormGeralAltInsert : FormBase
    {
        private Telefone Fone { get
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
        }

        private void RbPessoaJuridica_CheckedChanged_1(object sender, EventArgs e)
        {
            PanelPF.Visible = !RbPessoaJuridica.Checked;
            PanelPJ.Visible = RbPessoaJuridica.Checked;
        }
        private void BtCancelarGeralInserir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtGravaAltGeral_Click(object sender, EventArgs e)
        {
            Criticar();
            Geral pGeral = new Geral
            {
                TipoPessoa = RbPessoaFisica.Checked ? TPFJ.Fisica : TPFJ.Juridica,
                NomeFantasia = TbNomeFantasia.Text,
                RazaoSocial = TbRazaoSocial.Text,
                Contato = TbContato.Text,
                DtNascFundacao = DtNascAbert.Value,
                OrgaoExpedidor = tbOrgaoExpRg.Text,
                OrgaoExpedidorUF = tbEstadoRg.Text,
                CPF = tbCpf.Value,
                CNPJ = TbCNPJ.Text,
                RG = tbRg.Text,
                IE = TbInscrEstadual.Text,
                Sexo = (Sexo)cbSexo.SelectedIndex,
                EstadoCivil = (EstadoCivil)cbEstadoCivil.SelectedIndex,
                Email = TbEmail.Text,
                PontoReferencia = TbPontoRef.Text,
                Telefones = new Telefones
            {
                Fone,
                Celular
            },
                Endereco = RetornarEnderecoTela()
            };

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
                        TbNomeFantasia.Text = iGeral.NomeFantasia;
                        TbRazaoSocial.Text = iGeral.RazaoSocial;
                        TbContato.Text = iGeral.Contato;
                        DtNascAbert.Value = iGeral.DtNascFundacao;
                        tbOrgaoExpRg.Text = iGeral.OrgaoExpedidor;
                        tbEstadoRg.Text = iGeral.OrgaoExpedidorUF;
                        tbCpf.Text = Regex.Replace(iGeral.CPF, @"(\d{3})(\d{3})(\d{3})(\d{2})", @"$1.$2.$3-$4");
                        TbCNPJ.Text = iGeral.CNPJ;
                        tbRg.Text = iGeral.RG;
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
            cbSexo.Items.Clear();
            foreach (Sexo item in Enum.GetValues(typeof(Sexo)))
            {
                cbSexo.Items.Add(item);
            }
            cbSexo.SelectedText = string.Empty;
        }
        private void CarregarComboEstadoCivil()
        {
            cbSexo.Items.Clear();
            foreach (Sexo item in Enum.GetValues(typeof(Sexo)))
            {
                cbSexo.Items.Add(item);
            }
            cbSexo.SelectedText = string.Empty;
        }
    }
}
