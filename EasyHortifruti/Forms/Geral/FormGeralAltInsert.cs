using EasyHortifruti.DML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EasyHortifruti
{
    public partial class FormGeralAltInsert : FormBase
    {
        private Telefone Fone { get; set; }
        private Telefone Celular { get; set; }
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
        }

        private void RbPessoaJuridica_CheckedChanged_1(object sender, EventArgs e)
        {
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
                NomeFantasia = tbNaturalidade.Text,
                Contato = TbContato.Text,
                DtNascFundacao = DtNascAbert.Value,
                CPF = tbCpf.Text,
                RGIE = tbRg.Text,
                RGDataExepedicao = dtExpRg.Value,
                Sexo = (Sexo)cbSexo.SelectedIndex,
                EstadoCivil = (EstadoCivil)cbEstadoCivil.SelectedIndex,
                Naturalidade = tbNaturalidade.Text,
                Telefones = new Telefones
            {
                Fone,
                Celular
            },
                Endereco = RetornarEnderecoTela()
            };

            if (Alterar)
            {
                pGeral.ID = Convert.ToInt16(LbIdCadGeral.Text);

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
                    LimparCampos();
                    tabPage4.Text = string.Empty;
                }
                else
                    this.Close();
            }

            new ConexaoBD().InserirGeral(pGeral);
        }

        private Endereco RetornarEnderecoTela()
        {
            Endereco enderecoRetorno = new Endereco();

            enderecoRetorno.CEP = TbCepEndereco.Text;
            enderecoRetorno.logradouro = TbRua.Text;
            enderecoRetorno.Numero = Convert.ToInt16(TbNumero.Text);
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
            if (Id > 0)
            {
                Geral iGeral = new ConexaoBD().ConsultarGeralPorId(Id);

                if (iGeral != null)
                {
                    tbNaturalidade.Text = iGeral.NomeFantasia;
                    TbContato.Text = iGeral.Contato;
                    DtNascAbert.Value = iGeral.DtNascFundacao;
                    tbCpf.Text = iGeral.CPF;
                    tbRg.Text = iGeral.RGIE;
                    dtExpRg.Value = iGeral.RGDataExepedicao;
                    cbSexo.SelectedIndex = (int)iGeral.Sexo;
                    cbEstadoCivil.SelectedIndex  = (int)iGeral.EstadoCivil;
                    tbNaturalidade.Text = iGeral.Naturalidade;

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
                    tabPage4.Text = iGeral.ReferenciasComerciais.ToString();
                }
            }
        }

        private void CarregarComboSexo()
        {
            cbSexo.Items.Clear();
            DataSet ds = new ConexaoBD().ConsultarUnidades();
            foreach (Sexo item in Enum.GetValues(typeof(Sexo)))
            {
                cbSexo.Items.Add(item);
            }
            cbSexo.SelectedText = string.Empty;
        }
        private void CarregarComboEstadoCivil()
        {
            cbSexo.Items.Clear();
            DataSet ds = new ConexaoBD().ConsultarUnidades();
            foreach (Sexo item in Enum.GetValues(typeof(EstadoCivil)))
            {
                cbSexo.Items.Add(item);
            }
            cbSexo.SelectedText = string.Empty;
        }
    }
}
