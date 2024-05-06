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

        private List<ItemPedido> itensPedidos;
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
                {
                    return Convert.ToDecimal(TbTotPedido.Text.Replace("R$",""));
                }
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
                if (!string.IsNullOrEmpty(TbDesconto.Text))
                    return Convert.ToDecimal(TbDesconto.Text);
                return 0;
            }
            set
            {
                TbDesconto.Text = value.ToString("F2");
            }
        }

        private int IdClienteSelecionado {get; set;}
        #endregion propriedades

        public FormPedidoAltInsert()
        {
            dctGeral = new Dictionary<string, int>();
            produtoItem = new Dictionary<String, int>();
            margemLucro = new Dictionary<String, int>();
            dsProdutos = new DataSet();
            itensPedidos = new List<ItemPedido>();

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
            CbNomeCliente.Clear();
            DataSet ds = new ConexaoBD().ConsultarGerais();
            foreach (DataRow dr in ds.Tables[0].Rows)
                CbNomeCliente.Add(Convert.ToInt32(dr["id_recno"]), dr["razaosocial"].ToString());

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
                    CbProdutos.Add(Convert.ToInt32(dr["id_recno"]), dr["nome_produto"].ToString());
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
                if (CbProdutos.SelectedItem == dr["nome_produto"].ToString() &&
                    (CbUnidPedido.SelectedItem == dr["abrev_unid"].ToString()))
                {
                    TbVlCompra.Text = dr["pcocompra_produto"].ToString();
                    TbMargemLucro.Text = dr["margem_produto"].ToString();
                }
            }
        }

        private void CarregarComboTpDocumento()
        {
            CbTpDocumento.Clear();
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
                        CbUnidPedido.Add(Convert.ToInt32(dr["id_unidade"]), dr["abrev_unid"].ToString());
                    }
                }
                if (CbUnidPedido.Items.Count > 1)
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
                decimal valorFinal = valorCompra * (margemLucro / 100) * quantidade;

                // Exibir a margem de lucro no TextBox de resultado
                TbTotalItem.Text = valorFinal.ToString();
            }
            else
            {
                // Se os TextBoxes não tiverem valores válidos, limpa o TextBox da margem de lucro
                TbTotalItem.Text = string.Empty;
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
                IdClienteSelecionado = CbNomeCliente.SelectedIndex;
                iGeral = new ConexaoBD().ConsultarGeralPorId(IdClienteSelecionado);

                if (iGeral != null)
                {
                    if(iGeral.Telefones != null && iGeral.Telefones.Count > 0)
                        TbCelular.Text = iGeral.Telefones.First(x => x.tipoTelefone == TipoTelefone.celular).TelefoneCompleto;

                    CbTpDocumento.SelectedIndex = iGeral.TipoPessoa == TPFJ.Fisica ? 0 : 1;
                    TbRazaoSocial.Text = iGeral.TipoPessoa == TPFJ.Juridica ? iGeral.RazaoSocial : string.Empty;
                    TbCNPJ.Text = iGeral.TipoPessoa == TPFJ.Juridica ? iGeral.CNPJ : string.Empty;
                    TbIE.Text = iGeral.TipoPessoa == TPFJ.Juridica ? iGeral.IE : string.Empty;
                    TbNomeCompleto.Text = iGeral.TipoPessoa == TPFJ.Fisica ? iGeral.NomeCompleto : string.Empty;
                    TbCPF.Text = iGeral.TipoPessoa == TPFJ.Fisica ? iGeral.CPF : string.Empty;
                    TbRG.Text = iGeral.TipoPessoa == TPFJ.Fisica ? iGeral.RG : string.Empty;
                    TbPrazoPgto.Text = iGeral.PrazoPagamento.ToString();

                    if (iGeral.Endereco != null)
                    {
                        TbEndCep.Text = iGeral.Endereco.CEP;
                        TbEndLogradouro.Text = iGeral.Endereco.logradouro;
                        TbEndNum.Text = iGeral.Endereco.Numero.ToString();
                        TbEndCmpt.Text = iGeral.Endereco.Complemento;
                        TbEndBairro.Text = iGeral.Endereco.Bairro;
                        TbEndCidade.Text = iGeral.Endereco.Cidade;
                        TbEndUF.Text = iGeral.Endereco.UF;
                    }
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

            // Cria um novo objeto Pedido e preenche suas propriedades
            ItemPedido novoPedido = new ItemPedido
            {
                descrProduto = CbProdutos.SelectedItem,
                id_Produto = CbProdutos.SelectedIndex,
                unidade = CbUnidPedido.SelectedItem,
                id_unidade = CbUnidPedido.SelectedIndex,
                quantidade = Convert.ToInt32(TbQtdPedido.Text),
                valor_custo = Convert.ToDecimal(TbVlCompra.Text),
                percentual_lucro = Convert.ToDecimal(TbMargemLucro.Text),
                total_item = Convert.ToDecimal(TbTotProdPedido.Text),
                valor_lucro = Convert.ToDecimal(AtbValorLucroItem.Text)
            };

            AtualizarTotalPedido();

            // Adiciona o novo pedido à DataGridView
            AdicionarPedidoDataGridView(novoPedido);

            // (Opcional) Limpa os campos da interface do usuário após registrar o pedido
            LimparCampos();
        }

        private void AdicionarPedidoDataGridView(ItemPedido pedido)
        {
            DgvItensPedido.Rows.Add(pedido.descrProduto, pedido.unidade, pedido.quantidade, pedido.valor_custo, pedido.percentual_lucro, pedido.total_item, pedido.valor_lucro);
            itensPedidos.Add(pedido);
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
            TbTotalItem.Clear();
            AtbValorLucroItem.Clear();
        }

        private void AtbValorLucroItem_TextChanged(object sender, EventArgs e)
        {
            CalcularValorLucroItem();
        }

         private void TbFiltro_TbDescontoTextChanged(object sender, EventArgs e)
        {
            TotalGeral = Total_Pedido - Desconto;
        }

        private void btGravarPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido
            {
                dataPedido = DtPedido.Value,
                IdPessoa = IdClienteSelecionado,
                StatusPedido = (StatusPedido)CbStatusPedido.SelectedIndex,
                PrazoPagamento = string.IsNullOrEmpty(TbPrazoPgto.Text) ? 0 : Convert.ToInt32(TbPrazoPgto.Text),
                DataPrev = DtPrevEntrega.Value,
                DataEntrega = DtEntregaPedido.Value,
                DataConclusao = DtConclusaoPedido.Value,
                Itens = itensPedidos,
                Observacoes = tbObservacoes.Text,
                TotalPedido = Convert.ToDecimal(TbTotPedido.Text.Replace("R$", "")),
                ValorDesconto = string.IsNullOrEmpty(TbDesconto.Text) ? 0 : Convert.ToDecimal(TbDesconto.Text.Replace("R$", "")),
                TotalGeral = Convert.ToDecimal(TbTotalGeral.Text.Replace("R$", ""))

            };
                new ConexaoBD().InserirPedido(pedido);

                DialogResult pPedido = MessageBox.Show("Pedido inserido com sucesso!");
                    this.Close();            
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