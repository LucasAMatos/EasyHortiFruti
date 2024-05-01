using EasyHortifruti.DML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormPedidoAltInsert : FormBase
    {
        #region propriedades

        private Dictionary<string, int> dctGeral;

        private Geral iGeral;

        private Dictionary<string, int> produtos;

        private Dictionary<string, int> unidade;

        private Dictionary<string, int> produtoItem;

        private Dictionary<string, int> margemLucro;
        
        private DataSet dsProdutos;
        #endregion propriedades

        private Timer timer;
        private Color originalColor;
        private Color warningColor = Color.Red; // Cor de aviso (vermelho)
        private bool warningDisplayed = false;

        public FormPedidoAltInsert()
        {
            dctGeral = new Dictionary<string, int>();
            produtoItem = new Dictionary<String, int>();
            margemLucro = new Dictionary<String, int>();
            dsProdutos = new DataSet();
            InitializeComponent();

            // Armazenar a cor original do label
            originalColor = LbAviso.ForeColor;

            // Configurar o Timer
            timer = new Timer();
            timer.Interval = 500; // Intervalo em milissegundos
            timer.Tick += Timer_Tick;

            // Iniciar o Timer
            timer.Start();
        }

        public FormPedidoAltInsert(int pId)
        {
            Id = pId;
            dctGeral = new Dictionary<string, int>();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Alternar entre a cor original e a cor de aviso
            if (warningDisplayed)
            {
                LbAviso.ForeColor = originalColor;
            }
            else
            {
                LbAviso.ForeColor = warningColor;
            }

            // Inverter o estado
            warningDisplayed = !warningDisplayed;
        }

        private void BtBuscaClientePedido_Click(object sender, EventArgs e)
        {
            FormGeralCad BuscaCliente = new FormGeralCad();
            BuscaCliente.ShowDialog();
        }

        private void CarregarGridNomeCliente()
        {
            CbNomeCliente.Items.Clear();
            dctGeral.Clear();
            DataSet ds = new ConexaoBD().ConsultarGerais();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                dctGeral.Add(dr["nomefantasia"].ToString(), Convert.ToInt32(dr["id_recno"]));
                CbNomeCliente.Items.Add(dr["nomefantasia"].ToString());
            }
            CbNomeCliente.SelectedText = string.Empty;
        }

        private void CarregarComboStatusPedido()
        {
            CbStatusPedido.CarregarDescricoesEnum<StatusPedido>();
        }

        private void FormPedidoAltInsert_Load(object sender, EventArgs e)
        {
            base.LimparCampos();
            CarregarComboStatusPedido();
            CarregarGridNomeCliente();
            dsProdutos = new ConexaoBD().ConsultarProdutos();
            CarregarComboProdutos();
            CarregarComboUnidades();
            CarregarComboTpDocumento();
        }

        private void CarregarComboProdutos()
        {
            CbProdutos.Items.Clear();
            foreach (DataRow dr in dsProdutos.Tables[0].Rows)
            {
                if (!CbProdutos.Items.Contains(dr["nome_produto"].ToString()))
                { 
                    CbProdutos.Items.Add(dr["nome_produto"].ToString());
                }
            }

            CarregarComboUnidades();
        }

        private void CbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarComboUnidades();
        }

        private void CarregarComboTpDocumento()
        {
            CbTpDocumento.Items.Clear();
            CbTpDocumento.CarregarDescricoesEnum<TPFJ>();
        }

        private void CarregarComboUnidades()
        {
            if(CbProdutos.SelectedIndex >= 0 )
            { 
                CbUnidPedido.Items.Clear();
                foreach (DataRow dr in dsProdutos.Tables[0].Rows)
                {
                    if (CbProdutos.SelectedItem.ToString() == dr["nome_produto"].ToString() && (!CbUnidPedido.Items.Contains(dr["abrev_unid"].ToString())))
                    { 
                        CbUnidPedido.Items.Add(dr["abrev_unid"].ToString());
                    }
                }
                CbUnidPedido.SelectedText = string.Empty;
            }
        }

        private void CalcularValorFinalItem()
        {
            // Verifica se os TextBoxes têm valores válidos
            if (decimal.TryParse(TbQtdPedido.Text, out decimal quantidade) &&
                decimal.TryParse(TbVlCompra.Text, out decimal valorCompra) &&
                decimal.TryParse(TbMargemLucro.Text, out decimal margemLucro))
            {
                // Calcula o valor da margem de lucro
                decimal valorFinal = valorCompra * (1 + (margemLucro / 100)) * quantidade;

                // Exibir a margem de lucro no TextBox de resultado
                TbTotProdPedido.Text = valorFinal.ToString();
            }
            else
            {
                // Se os TextBoxes não tiverem valores válidos, limpa o TextBox da margem de lucro
                TbTotProdPedido.Text = string.Empty;
            }
            CalcularValorLucroItem();
        }

        private void CalcularValorLucroItem()
        {
            // Verifica se os TextBoxes têm valores válidos
            if (decimal.TryParse(TbVlCompra.Text, out decimal valorCompra) &&
                decimal.TryParse(TbQtdPedido.Text, out decimal quantidade) &&
                decimal.TryParse(TbMargemLucro.Text, out decimal margemLucro))
            {
                // Calcula o valor da margem de lucro
                decimal lucroFinalItem = ((valorCompra * quantidade) * (margemLucro / 100));

                // Exibir a margem de lucro no TextBox de resultado
                AtbValorLucroItem.Text = lucroFinalItem.ToString();
            }
            else
            {
                // Se os TextBoxes não tiverem valores válidos, limpa o TextBox da margem de lucro
                AtbValorLucroItem.Text = string.Empty;
            }
        }

        private void BtCancelarPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbQtdPedido_TextChanged(object sender, EventArgs e)
        {
            CalcularValorFinalItem();
        }

        private void TbVlCompra_TextChanged(object sender, EventArgs e)
        {
            CalcularValorFinalItem();
        }

        private void TbMargemLucro_TextChanged(object sender, EventArgs e)
        {
            CalcularValorFinalItem();
        }

        private void CbNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbNomeCliente.SelectedItem != null)
            {
                int indice;
                dctGeral.TryGetValue(CbNomeCliente.SelectedItem.ToString(), out indice);
                iGeral = new ConexaoBD().ConsultarGeralPorId(indice);

                if (iGeral != null)
                {
                    TbCelular.Text = iGeral.Telefones.First(x => x.tipoTelefone == TipoTelefone.celular).TelefoneCompleto;

                    CbTpDocumento.SelectedIndex = iGeral.TipoPessoa == TPFJ.Juridica ? 1 : 0;
                    TbNome.Text = iGeral.NomeFantasia;
                    TbCpj.Caption = iGeral.TipoPessoa == TPFJ.Juridica ? "CNPJ" : "CPF";
                    TbCpj.Text = iGeral.TipoPessoa == TPFJ.Juridica ? iGeral.CNPJ : iGeral.CPF;
                    TbRg.Caption = iGeral.TipoPessoa == TPFJ.Juridica ? "IE" : "RG";
                    TbRg.Text = iGeral.TipoPessoa == TPFJ.Juridica ? iGeral.IE : iGeral.RG;
                    TbPrazoPgto.Text = iGeral.PrazoPagamento.ToString();
                    tbEndCep.Text = iGeral.Endereco.CEP;
                    tbEndLogradouro.Text = iGeral.Endereco.logradouro;
                    tbEndNome.Text = iGeral.Endereco.Numero.ToString();
                    tbEndCmpt.Text = iGeral.Endereco.Complemento;
                    tbEndBairro.Text = iGeral.Endereco.Bairro;
                    tbEndCidade.Text = iGeral.Endereco.Cidade;
                    tbEndUF.Text = iGeral.Endereco.UF;
                    tbEndPontoReferencia.Text = iGeral.PontoReferencia;
                    tbEmail.Text = iGeral.Email;
                }
            }
        }

        private void CbTpDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbTpDocumento.SelectedItem != null)
            {
                // Verifique qual opção está selecionada no ComboBox
                String opcaoSelecionada = CbTpDocumento.SelectedItem.ToString();
            }
        }

        private void BtAdicItemPedido_Click(object sender, EventArgs e)
        {
            // Captura os valores dos campos da interface do usuário
            string produtoItem = CbProdutos.Text;
            string unidadeItem = CbUnidPedido.SelectedItem.ToString();
            string quantidadeItem = TbQtdPedido.Text;
            decimal valorCompraItem = Convert.ToDecimal(TbVlCompra.Text);
            decimal margemLucroItem = Convert.ToDecimal(TbMargemLucro.Text);
            decimal TotalItem = Convert.ToDecimal(TbTotProdPedido.Text);
            decimal LucroItem = Convert.ToDecimal(AtbValorLucroItem.Text);

            // Cria um novo objeto Pedido e preenche suas propriedades
            Pedido novoPedido = new Pedido
            {
                DescrProduto = produtoItem,
                UnidProduto = unidadeItem,
                QtdeProduto = quantidadeItem,
                VlCompraProduto = valorCompraItem,
                MargemLucro = margemLucroItem,
                TotalItem = TotalItem,
                ValorLucroItem = LucroItem
            };

            // Adiciona o novo pedido à DataGridView
            AdicionarPedidoDataGridView(novoPedido);

            // (Opcional) Limpa os campos da interface do usuário após registrar o pedido
            LimparCampos();
        }

        private void AdicionarPedidoDataGridView(Pedido pedido)
        {
            // Adiciona uma nova linha à DataGridView e preenche as células com os valores do pedido
            DgvPedidoProdutos.Rows.Add(pedido.DescrProduto, pedido.UnidProduto, pedido.QtdeProduto, pedido.VlCompraProduto, pedido.MargemLucro, pedido.TotalItem, pedido.ValorLucroItem);
        }

        private void LimparCampos()
        {
            CbProdutos.SelectedIndex = -1;
            TbQtdPedido.Clear();
            CbUnidPedido.SelectedIndex = -1;
            TbVlCompra.Clear();
            TbMargemLucro.Clear();
            TbTotProdPedido.Clear();
            AtbValorLucroItem.Clear();
        }

        private void AtbValorLucroItem_TextChanged(object sender, EventArgs e)
        {
            CalcularValorLucroItem();
        }
    }
}