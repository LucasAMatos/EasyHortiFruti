using EasyHortifruti.DML;
using EasyHortifruti.Utilitarios;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormGeralAltInsert : FormBase
    {
        #region Propriedades

        private CNPJConsultado cnpjConsultado;
        private CEPConsultado cepConsultado;

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

        #endregion Propriedades

        #region Construtor

        public FormGeralAltInsert()
        {
            InitializeComponent();

        }

        public FormGeralAltInsert(int pID)
        {
            InitializeComponent();
            Id = pID;
        }
        #endregion Construtor

        #region Eventos

        private void FormGeralAltInsert_Load(object sender, EventArgs e)
        {
            LimparCampos();
            PreencheCampos();
        }

        private void RbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            PanelPF.Visible = RbPessoaFisica.Checked;
            PanelPJ.Visible = !RbPessoaJuridica.Checked;
            PanelFantasiaPJ.Visible = false;
            BtConsCNPJ.Visible = PanelPJ.Visible;
        }

        private void RbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            PanelPF.Visible = !RbPessoaJuridica.Checked;
            PanelPJ.Visible = RbPessoaJuridica.Checked;
            PanelFantasiaPJ.Visible = RbPessoaJuridica.Checked;
            BtConsCNPJ.Visible = PanelPJ.Visible;
        }

        private void BtCancelarGeralInserir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtGravaAltGeral_Click(object sender, EventArgs e)
        {
            try
            {
                Criticar();
                Geral pGeral = new Geral();

            pGeral.TipoPessoa = RbPessoaFisica.Checked ? TPFJ.Fisica : TPFJ.Juridica;
            pGeral.Classificacao = (Classificacao)CbClassificacao.SelectedIndex;
            pGeral.NomeFantasia = TbNomeFantasia.Text;
            pGeral.RazaoSocial = TbRazaoSocial.Text;
            pGeral.NomeCompleto = TbNomeCompleto.Text;
            pGeral.Contato = TbContato.Text;
            pGeral.DtNascFundacao = DtNascAbert.Value;
            pGeral.CPF = tbCpf.Value;
            pGeral.CNPJ = TbCNPJ.Value;
            pGeral.RG = tbRg.Text;
            pGeral.IE = TbInscrEstadual.Text;
            pGeral.InscricaoMunicipal = TbInscrMunicipal.Text;
            pGeral.Sexo = CbSexo.SelectedIndex >= 0 ? (Sexo)CbSexo.SelectedIndex : Sexo.NaoDefinido;
            pGeral.EstadoCivil = (EstadoCivil)CbEstadoCivil.SelectedIndex >= 0 ? (EstadoCivil)CbEstadoCivil.SelectedIndex : EstadoCivil.NaoDefinido;
            pGeral.Email = TbEmail.Text;
            pGeral.PontoReferencia = TbPontoRef.Text;
            pGeral.PrazoPagamento = string.IsNullOrWhiteSpace(TbPrazoPgto.Text) ? -1 : Convert.ToInt32(TbPrazoPgto.Text);
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

                    DialogResult pNovaUnidade = MessageBox.Show(string.Format("{0} incluído com sucesso! Deseja cadastrar uma nova empresa?", pGeral.NomeFantasia), string.Empty, MessageBoxButtons.YesNo);
                    if (pNovaUnidade == DialogResult.Yes)
                    {
                        LimparCampos(this);
                        //tabPage4.Text = string.Empty;
                    }
                    else
                        this.Close();
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtConsCNPJ_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                cnpjConsultado = await ConsultarCNPJ.consCNPJ(TbCNPJ.Value);

                if (cnpjConsultado != null && cnpjConsultado.RazaoSocial != null)
                {
                    DialogResult dialogResult = MessageBox.Show(string.Format("CNPJ Consultado {0} Pertence à empresa {1}. Deseja Preencher os dados da empresa?", TbCNPJ.Text, cnpjConsultado.RazaoSocial), "Consulta CNPJ", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (cnpjConsultado.RazaoSocial != null)
                        {
                            TbRazaoSocial.Text = cnpjConsultado.RazaoSocial;
                            TbRazaoSocial.Enabled = false;
                        }
                        if (cnpjConsultado.Estabelecimento != null && cnpjConsultado.Estabelecimento.NomeFantasia != null)
                            TbNomeFantasia.Text = cnpjConsultado.Estabelecimento.NomeFantasia;
                        else
                            TbNomeFantasia.Text = cnpjConsultado.RazaoSocial;

                        if (cnpjConsultado.Estabelecimento != null && cnpjConsultado.Estabelecimento.Telefone1 != null)
                        {
                            Telefone fixo = new Telefone();
                            fixo.DDD = cnpjConsultado.Estabelecimento.Ddd1;
                            fixo.Numero = cnpjConsultado.Estabelecimento.Telefone1;

                            TbFone.Text = fixo.TelefoneCompleto;
                        }

                        TbNomeFantasia.Enabled = false;
                        if (cnpjConsultado.Estabelecimento != null && cnpjConsultado.Estabelecimento.InscricoesEstaduais != null && cnpjConsultado.Estabelecimento.InscricoesEstaduais.Count > 0)
                        {
                            TbInscrEstadual.Text = cnpjConsultado.Estabelecimento.InscricoesEstaduais.First().InscricaoEstadual;
                            TbInscrEstadual.Enabled = false;
                        }
                        if (cnpjConsultado.Estabelecimento.Logradouro != null)
                        {
                            DialogResult dialogResult2 = MessageBox.Show("deseja preencher o endereço do cliente?", "Preenche Endereço", MessageBoxButtons.YesNo);

                            if (dialogResult2 == DialogResult.Yes)
                            {
                                TbCepEndereco.Text = Regex.Replace(cnpjConsultado.Estabelecimento.Cep, @"(\d{5})(\d{3})", @"$1-$2");
                                TbRua.Text = cnpjConsultado.Estabelecimento.Logradouro;
                                TbRua.Enabled = false;
                                TbNumero.Text = cnpjConsultado.Estabelecimento.Numero;
                                TbNumero.Enabled = false;
                                TbComplemento.Text = cnpjConsultado.Estabelecimento.Complemento;
                                TbComplemento.Enabled = false;
                                TbBairro.Text = cnpjConsultado.Estabelecimento.Bairro;
                                TbBairro.Enabled = false;
                                TbCidade.Text = cnpjConsultado.Estabelecimento.Cidade.Nome;
                                TbCidade.Enabled = false;
                                CbUF.SelecionarIndexPeloConteudo(cnpjConsultado.Estabelecimento.Estado.Sigla);
                                CbUF.Enabled = false;
                            }
                            else
                            {
                                LimpaEndereco();
                            }
                        }
                    }
                    else
                    {
                        LimpaCnpj();

                        TbCepEndereco.Text = string.Empty;
                        TbCepEndereco.Enabled = true;

                        LimpaEndereco();
                    }
                }
                else
                {
                    MessageBox.Show("CNPJ não encontrado.");
                }
            }
            catch
            {
                MessageBox.Show("CNPJ não encontrado!");
            }
        }

        private async void btnConsultaCEP_Click(object sender, EventArgs e)
        {
            try
            {
                cepConsultado = await ConsultarCEP.consCEP(TbCepEndereco.Value);

                if (cepConsultado != null && cepConsultado.Cep != null)
                {
                    DialogResult dialogResult = MessageBox.Show(string.Format("CEP Consultado {0} retornou logradouro {1}. Deseja Preencher os dados do CEP?", TbCepEndereco.Text, cepConsultado.Logradouro), "Consulta CEP", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (cepConsultado.Logradouro != null)
                        {
                            TbRua.Text = cepConsultado.Logradouro;
                            TbRua.Enabled = false;
                        }
                        if (cepConsultado.Bairro != null)
                        {
                            TbBairro.Text = cepConsultado.Bairro;
                            TbBairro.Enabled = false;
                        }
                        if (cepConsultado.Localidade != null)
                        {
                            TbCidade.Text = cepConsultado.Localidade;
                            TbCidade.Enabled = false;
                        }
                        if (cepConsultado.Uf != null)
                        {
                            CbUF.SelecionarIndexPeloConteudo(cepConsultado.Uf);
                            CbUF.Enabled = false;
                        }
                        TbNumero.Focus();
                    }
                    else
                    {
                        LimpaEndereco();
                    }
                }
                else
                {
                    MessageBox.Show("CEP não encontrado.");
                }
            }
            catch
            {
                MessageBox.Show("CEP não encontrado!");
            }
        }

        #endregion Eventos

        #region Métodos

        private Endereco RetornarEnderecoTela()
        {
            Endereco enderecoRetorno = new Endereco();

            enderecoRetorno.CEP = TbCepEndereco.Value;
            enderecoRetorno.logradouro = TbRua.Text;
            enderecoRetorno.Numero = Convert.ToInt32(TbNumero.Text);
            enderecoRetorno.Complemento = TbComplemento.Text;
            enderecoRetorno.Bairro = TbBairro.Text;
            enderecoRetorno.Cidade = TbCidade.Text;
            enderecoRetorno.UF = CbUF.SelectedItem;
            return enderecoRetorno;
        }

        private void LimparCampos()
        {
            base.LimparCampos();
            CarregarComboSexo();
            CarregarComboEstadoCivil();
            CarregarComboClassificacao();
            CarregarComboUf();
            //tabPage4.Text = string.Empty;

            LimpaCnpj();
            LimpaEndereco();
        }

        private void LimpaCnpj()
        {
            TbRazaoSocial.Enabled = true;
            TbRazaoSocial.Text = string.Empty;
            TbNomeFantasia.Enabled = true;
            TbNomeFantasia.Text = string.Empty;
            TbInscrEstadual.Enabled = true;
            TbInscrEstadual.Text = string.Empty;
        }

        private void LimpaEndereco()
        {
            TbRua.Enabled = true;
            TbRua.Text = string.Empty;
            TbNumero.Enabled = true;
            TbNumero.Text = string.Empty;
            TbComplemento.Enabled = true;
            TbComplemento.Text = string.Empty;
            TbBairro.Enabled = true;
            TbBairro.Text = string.Empty;
            TbCidade.Enabled = true;
            TbCidade.Text = string.Empty;
            CbUF.Enabled = true;
            CbUF.Text = string.Empty;
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
                        CbClassificacao.SelecionarIndexPeloEnum((int)iGeral.Classificacao);
                        TbNomeFantasia.Text = iGeral.NomeFantasia;
                        TbRazaoSocial.Text = iGeral.RazaoSocial;
                        TbNomeCompleto.Text = iGeral.TipoPessoa == TPFJ.Fisica ? iGeral.NomeCompleto : iGeral.RazaoSocial;
                        TbContato.Text = iGeral.Contato;
                        TbPrazoPgto.Text = iGeral.PrazoPagamento > 0 ? iGeral.PrazoPagamento.ToString() : string.Empty;
                        DtNascAbert.Value = iGeral.DtNascFundacao;
                        tbCpf.Text = iGeral.TipoPessoa == TPFJ.Fisica ? iGeral.CPF : string.Empty;
                        TbCNPJ.Text = iGeral.TipoPessoa == TPFJ.Juridica ? iGeral.CNPJ : string.Empty;
                        tbRg.Text = iGeral.TipoPessoa == TPFJ.Fisica ? iGeral.RG : string.Empty;
                        TbInscrEstadual.Text = iGeral.TipoPessoa == TPFJ.Juridica ? iGeral.IE : string.Empty;
                        TbInscrMunicipal.Text = iGeral.TipoPessoa == TPFJ.Juridica ? iGeral.InscricaoMunicipal : string.Empty;
                        CbSexo.SelecionarIndexPeloConteudo(iGeral.Sexo.ToString());
                        CbEstadoCivil.SelecionarIndexPeloConteudo(iGeral.EstadoCivil.ToString());

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
                            CbUF.SelecionarIndexPeloConteudo(iGeral.Endereco.UF);
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
            CbSexo.CarregarDescricoesEnum<Sexo>();
        }

        private void CarregarComboEstadoCivil()
        {
            CbEstadoCivil.CarregarDescricoesEnum<EstadoCivil>();
        }

        private void CarregarComboClassificacao()
        {
            CbClassificacao.CarregarDescricoesEnum<Classificacao>();
        }

        private void CarregarComboUf()
        {
            CbUF.CarregarValoresEnum<UF>();
        }

        #endregion Métodos

        private void CbClassificacao_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((Classificacao)CbClassificacao.SelectedIndex == Classificacao.Funcionario || 
                (Classificacao)CbClassificacao.SelectedIndex == Classificacao.Socio)
                TbPrazoPgto.Obrigatorio = false;
            else
                TbPrazoPgto.Obrigatorio = true;
        }
    }
}