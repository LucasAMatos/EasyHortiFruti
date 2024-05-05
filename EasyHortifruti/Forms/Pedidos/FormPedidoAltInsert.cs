using EasyHortifruti.DML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private Dictionary<string, int> produtoItem;

        private Dictionary<string, int> margemLucro;

        private DataSet dsProdutos;

        private Timer timer;

        private Color originalColor;

        private Color warningColor = Color.Red; // Cor de aviso (vermelho)

        private bool warningDisplayed = false;

        private decimal Total_Pedido
        { 
            get
            {
                if (!string.IsNullOrEmpty(TbTotPedido.Text))
                    return Convert.ToDecimal(TbTotPedido.Text);
               return 0;
            }
            set 
            {
                TbTotPedido.Text = value.ToString("F2");
            }
        }

        private decimal TotalGeral
        {
            get
            {
                if (!string.IsNullOrEmpty(TbTotalGeral.Text))
                    return Convert.ToDecimal(TbTotalGeral.Text);
                return 0;
            }
            set
            {
                TbTotalGeral.Text = value.ToString("F2");
            }
        }

        private decimal Desconto
        {
            get
            {
                if(!string.IsNullOrEmpty(TbDesconto.Text))
                    return Convert.ToDecimal(TbDesconto.Text);
                return 0;
            }
            set
            {
                TbDesconto.Text = value.ToString("F2");
            }
        }

        #endregion propriedades

        public FormPedidoAltInsert()
        {
            dctGeral = new Dictionary<string, int>();
            produtoItem = new Dictionary<String, int>();
            margemLucro = new Dictionary<String, int>();
            dsProdutos = new DataSet();

            InitializeComponent();

            configuraGridPadrao(DgvItensPedido);

            TbDesconto.TextChanged += TbFiltro_TbDescontoTextChanged;
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
                dctGeral.Add(dr["razaosocial"].ToString(), Convert.ToInt32(dr["id_recno"]));
                CbNomeCliente.Items.Add(dr["razaosocial"].ToString());
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

        private void CbUnidPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow dr in dsProdutos.Tables[0].Rows)
            {
                if (CbProdutos.SelectedItem != null && CbProdutos.SelectedItem.ToString() == dr["nome_produto"].ToString() && 
                    (CbUnidPedido.SelectedItem != null && CbUnidPedido.SelectedItem.ToString() == dr["abrev_unid"].ToString()))
                {
                    TbVlCompra.Text = dr["pcocompra_produto"].ToString();
                    TbMargemLucro.Text = dr["margem_produto"].ToString();
                }
            }
        }

        private void CarregarComboTpDocumento()
        {
            CbTpDocumento.Items.Clear();
            CbTpDocumento.CarregarDescricoesEnum<TPFJ>();
        }

        private void CarregarComboUnidades()
        {
            if (CbProdutos.SelectedIndex >= 0)
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

                    CbTpDocumento.SelectedIndex = iGeral.TipoPessoa == TPFJ.Fisica ? 0 : 1;             
                    TbRazaoSocial.Text = iGeral.TipoPessoa == TPFJ.Juridica ? iGeral.RazaoSocial: string.Empty;
                    TbCNPJ.Text = iGeral.TipoPessoa == TPFJ.Juridica ? iGeral.CNPJ : string.Empty;                    
                    TbIE.Text = iGeral.TipoPessoa == TPFJ.Juridica ? iGeral.IE : string.Empty;
                    TbNomeCompleto.Text = iGeral.TipoPessoa == TPFJ.Fisica ? iGeral.NomeCompleto : string.Empty;
                    TbCPF.Text = iGeral.TipoPessoa == TPFJ.Fisica ? iGeral.CPF : string.Empty;
                    TbRG.Text = iGeral.TipoPessoa == TPFJ.Fisica ? iGeral.RG : string.Empty;
                    TbPrazoPgto.Text = iGeral.PrazoPagamento.ToString();
                    TbEndCep.Text = iGeral.Endereco.CEP;
                    TbEndLogradouro.Text = iGeral.Endereco.logradouro;
                    TbEndNum.Text = iGeral.Endereco.Numero.ToString();
                    TbEndCmpt.Text = iGeral.Endereco.Complemento;
                    TbEndBairro.Text = iGeral.Endereco.Bairro;
                    TbEndCidade.Text = iGeral.Endereco.Cidade;
                    TbEndUF.Text = iGeral.Endereco.UF;
                    TbEndPontoReferencia.Text = iGeral.PontoReferencia;
                    TbEndEmail.Text = iGeral.Email;
                }
            }
        }

        private void CbTpDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbTpDocumento.SelectedItem != null)
            {
                // Verifique qual opção está selecionada no ComboBox
                String opcaoSelecionada = CbTpDocumento.SelectedItem.ToString();

                PanelPFPedido.Visible = opcaoSelecionada == "Fisica";
                PanelPJPedido.Visible = opcaoSelecionada == "Juridica";
 
            }
        }

        private void BtAdicItemPedido_Click(object sender, EventArgs e)
        {
            // Captura os valores dos campos da interface do usuário
            DateTime dataPedido = DtPedido.MinDate;
            string produtoItem = CbProdutos.SelectedItem.ToString();
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

            AtualizarTotalPedido();

            // Adiciona o novo pedido à DataGridView
            AdicionarPedidoDataGridView(novoPedido);

            // (Opcional) Limpa os campos da interface do usuário após registrar o pedido
            LimparCampos();
        }

        private void AdicionarPedidoDataGridView(Pedido pedido)
        {
            // Adiciona uma nova linha à DataGridView e preenche as células com os valores do pedido
            DgvItensPedido.Rows.Add(pedido.dataPedido, pedido.DescrProduto, pedido.UnidProduto, pedido.QtdeProduto, pedido.VlCompraProduto, pedido.MargemLucro, pedido.TotalItem, pedido.ValorLucroItem);
        }

        private void AtualizarTotalPedido()
        {
            decimal novoTotal = 0;

            // Itera pelas linhas do DataGridView e soma os preços de venda
            foreach (DataGridViewRow row in DgvItensPedido.Rows)
            {
                if (!row.IsNewRow && row.Cells["TotalItem"].Value != null)
                {
                    decimal precoItem = Convert.ToDecimal(row.Cells["TotalItem"].Value);
                    novoTotal += precoItem;
                }
            }
            // Atualiza o total do pedido no TextBox externo
            Total_Pedido = novoTotal;
            TbTotPedido.Text = Total_Pedido.ToString("C");

            // Calcula o total do pedido com desconto
            decimal totalComDesconto = novoTotal - Desconto;

            // Atualiza o total do pedido com desconto no ComboBox externo
            TbTotalGeral.Text = totalComDesconto.ToString("C");
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

        private void SomaTotalPedido(decimal TotalItem)
        {
            //TotalPedido = TotalItem;
            //SomaTotalGeral();
        }

        private void SomaTotalGeral()
        {
            //TotalGeral = TotalPedido - Desconto;
        }

        private void TbFiltro_TbDescontoTextChanged(object sender, EventArgs e)
        {
            TotalGeral = Total_Pedido - Desconto;
        }

        private void btGravarPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.dataPedido = DtPedido.Value;

            new ConexaoBD().InserirPedido(pedido);
        }

        private void DgvItensPedido_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarTotalPedido();
        }

        private void DgvItensPedido_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            AtualizarTotalPedido();
        }

        private void DgvItensPedido_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            AtualizarTotalPedido();
        }
    }
}