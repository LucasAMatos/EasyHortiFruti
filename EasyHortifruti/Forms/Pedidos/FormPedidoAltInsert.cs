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

        private Geral iGeral;

        private readonly List<ItemPedido> itensPedidos;

        private DataSet dsProdutos;

        private readonly Timer timer;

        private readonly Color originalColor;

        private readonly Color warningColor = Color.Red; // Cor de aviso (vermelho)

        private bool warningDisplayed = false;

        private decimal Total_Pedido
        {
            get
            {
                if (!string.IsNullOrEmpty(TbTotPedido.Text))
                {
                    return Convert.ToDecimal(TbTotPedido.Text.Replace("R$", ""));
                }
                return 0;
            }
            set
            {
                TbTotPedido.Text = value.ToString("F2");
            }
        }

        private decimal Total_Geral
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

        private decimal TotalLucro
        {
            get
            {
                if (!string.IsNullOrEmpty(TbLucroPedido.Text))
                    return Convert.ToDecimal(TbLucroPedido.Text);
                return 0;
            }
            set
            {
                TbLucroPedido.Text = value.ToString("F2");
            }
        }

        private int IdClienteSelecionado { get; set; }

        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = DgvItensPedido.SelectedRows;

                if (linhaSelecionada?.Count == 1)
                    return DgvItensPedido.SelectedRows[0].Index;

                return -1;
            }
        }
        #endregion propriedades

        public FormPedidoAltInsert()
        {
            dsProdutos = new DataSet();
            itensPedidos = new List<ItemPedido>();

            InitializeComponent();

            ConfiguraGridPadrao(DgvItensPedido);

            TbDesconto.TextChanged += TbFiltro_TbDescontoTextChanged;
            // Armazenar a cor original do label
            originalColor = LbAviso.ForeColor;

            // Configurar o Timer
            timer = new Timer
            {
                Interval = 500 // Intervalo em milissegundos
            };
            timer.Tick += Timer_Tick;

            // Iniciar o Timer
            timer.Start();
        }

        public FormPedidoAltInsert(int pId)
        {
            Id = pId;
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

            PreencheCampos();
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
                    TbPrecoProd.Text = dr["pcocompra_produto"].ToString();
                    TbMargemLucro.Text = dr["margem_produto"].ToString();
                }
            }
        }

        private void CarregarComboTpDocumento()
        {
            CbTpDocumento.Clear();
            CbTpDocumento.CarregarDescricoesEnum<TPFJ>();
        }

        private void CarregarComboProdutos()
        {
            CbProdutos.Clear();
            foreach (DataRow dr in dsProdutos.Tables[0].Rows)
            {
                if (!CbProdutos.Items.Contains(dr["nome_produto"].ToString()))
                {
                    CbProdutos.Add(Convert.ToInt32(dr["id_recno"]), dr["nome_produto"].ToString());
                }
            }
            CarregarComboUnidades();
        }

        private void CarregarComboUnidades()
        {
            if (CbProdutos.SelectedIndex >= 0)
            {
                CbUnidPedido.Clear();
                foreach (DataRow dr in dsProdutos.Tables[0].Rows)
                {
                    if (CbProdutos.SelectedItem == dr["nome_produto"].ToString() && (!CbUnidPedido.Items.Contains(dr["abrev_unid"].ToString())))
                    {
                        CbUnidPedido.Add(Convert.ToInt32(dr["id_unidade"]), dr["abrev_unid"].ToString());
                    }
                }
                if (CbUnidPedido.Items.Count > 1)
                    CbUnidPedido.SelectedText = string.Empty;
            }
        }

        private void CalcularValorLucroItem()
        {
            // Verifica se os TextBoxes têm valores válidos
            if (decimal.TryParse(TbPrecoProd.Text, out decimal valorCompra) &&
                decimal.TryParse(TbQtdPedido.Text, out decimal quantidade) &&
                decimal.TryParse(TbMargemLucro.Text, out decimal margemLucro))
            {
                // Calcula o valor da margem de lucro
                decimal lucroFinalItem = (valorCompra * quantidade * (margemLucro / 100));

                // Exibir a margem de lucro no TextBox de resultado
                TbLucroItem.Text = lucroFinalItem.ToString();
            }
            else
            {
                // Se os TextBoxes não tiverem valores válidos, limpa o TextBox da margem de lucro
                TbLucroItem.Text = string.Empty;
            }
            CalculaCustoCompra();
        }

        private void CalculaCustoCompra()
        {
            if (decimal.TryParse(TbPrecoProd.Text, out decimal valorCompra) &&
                decimal.TryParse(TbQtdPedido.Text, out decimal quantidade))
            {
                decimal valorcusto = (valorCompra * quantidade);
                TbVlCusto.Text = valorcusto.ToString();
            }
            else
            {
                TbVlCusto.Text = string.Empty;
            }
        }

        private void CalcularValorFinalItem()
        {
            // Verifica se os TextBoxes têm valores válidos
            if (decimal.TryParse(TbQtdPedido.Text, out _) &&
                decimal.TryParse(TbVlCusto.Text, out decimal valorCompra) &&
                decimal.TryParse(TbMargemLucro.Text, out _) &&
                decimal.TryParse(TbLucroItem.Text, out decimal LucroItem))
            {
                // Calcula o valor da margem de lucro
                decimal valorFinal = (valorCompra + LucroItem);

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
            if (CbNomeCliente.SelectedItem != null || IdClienteSelecionado >= 0)
            {

                if (Id == 0)
                {
                    IdClienteSelecionado = CbNomeCliente.SelectedIndex;
                    CbNomeCliente.Enabled = true;
                }

                iGeral = new ConexaoBD().ConsultarGeralPorId(IdClienteSelecionado);

                if (iGeral != null)
                {
                    if (iGeral.Telefones?.Count > 0)
                        TbCelular.Text = iGeral.Telefones.First(x => x.TipoTelefone == TipoTelefone.celular).TelefoneCompleto;

                    if (CbNomeCliente.Text == string.Empty && Id > 0)
                    {
                        CbNomeCliente.Enabled = false;
                        CbNomeCliente.Text = iGeral.TipoPessoa == TPFJ.Juridica ? iGeral.RazaoSocial : iGeral.NomeCompleto;
                    }
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
                        TbEndLogradouro.Text = iGeral.Endereco.Logradouro;
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
                String opcaoSelecionada = CbTpDocumento.SelectedItem;

                PanelPFPedido.Visible = opcaoSelecionada == "Fisica";
                PanelPJPedido.Visible = opcaoSelecionada == "Juridica";
            }
        }

        private void BtAdicItemPedido_Click(object sender, EventArgs e)
        {
            // Cria um novo objeto Pedido e preenche suas propriedades
            ItemPedido novoPedido = new ItemPedido
            {
                DescrProduto = CbProdutos.SelectedItem,
                Id_Produto = CbProdutos.SelectedIndex,
                Unidade = CbUnidPedido.SelectedItem,
                Id_unidade = CbUnidPedido.SelectedIndex,
                Quantidade = Convert.ToInt32(TbQtdPedido.Text),
                Valor_custo = Convert.ToDecimal(TbVlCusto.Text),
                Total_item = Convert.ToDecimal(TbTotalItem.Text),
                Valor_lucro = Convert.ToDecimal(TbLucroItem.Text)
            };

            AtualizarTotalPedido();

            if (BtAdicItemPedido.Text == "Alterar")
            {
                DgvItensPedido.Rows.RemoveAt(IdSelecionado);
                DgvItensPedido.Refresh();
                BtAdicItemPedido.Text = "Adicionar";
                CbProdutos.Enabled = true;
                BtExclItemPedido.Enabled = true;
            }
            AdicionarPedidoDataGridView(novoPedido);

            // (Opcional) Limpa os campos da interface do usuário após registrar o pedido
            LimparCampos();
        }

        private void AdicionarPedidoDataGridView(ItemPedido pedido)
        {
            DgvItensPedido.Rows.Add(pedido.DescrProduto, pedido.Unidade, pedido.Quantidade, pedido.Valor_custo, pedido.Total_item, pedido.Valor_lucro, pedido.Id_item);
            itensPedidos.Add(pedido);
        }

        private void AtualizarTotalPedido()
        {
            decimal novoTotal = 0;
            decimal novoLucro = 0;

            // Itera pelas linhas do DataGridView e soma os preços de venda
            foreach (DataGridViewRow row in DgvItensPedido.Rows)
            {
                if (!row.IsNewRow && row.Cells["vltotitem"].Value != null)
                {
                    decimal precoItem = Convert.ToDecimal(row.Cells["vltotitem"].Value);
                    novoTotal += precoItem;
                }

                if (!row.IsNewRow && row.Cells["vllucro"].Value != null)
                {
                    decimal lucropedido = Convert.ToDecimal(row.Cells["vllucro"].Value);
                    novoLucro += lucropedido;
                }
            }
            // Atualiza o total do pedido no TextBox externo
            Total_Pedido = novoTotal;
            TbTotPedido.Text = Total_Pedido.ToString("C");

            // Calcula o total do pedido com desconto
            decimal totalComDesconto = novoTotal - Desconto;

            // Atualiza o total do pedido com desconto no ComboBox externo
            TbTotalGeral.Text = totalComDesconto.ToString("C");

            TotalLucro = novoLucro;
            TbLucroPedido.Text = TotalLucro.ToString("C");
        }

        private void LimparCampos()
        {
            CbProdutos.SelectedIndex = -1;
            TbQtdPedido.Clear();
            CbUnidPedido.SelectedIndex = -1;
            TbPrecoProd.Clear();
            TbVlCusto.Clear();
            TbMargemLucro.Clear();
            TbTotalItem.Clear();
            TbLucroItem.Clear();
        }

        private void AtbValorLucroItem_TextChanged(object sender, EventArgs e)
        {
            CalcularValorLucroItem();
        }

        private void TbFiltro_TbDescontoTextChanged(object sender, EventArgs e)
        {
            Total_Geral = Total_Pedido - Desconto;
        }

        private void BtGravarPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido
            {
                DataPedido = DtPedido.Value,
                IdPessoa = IdClienteSelecionado,
                StatusPedido = (StatusPedido)CbStatusPedido.SelectedIndex,
                PrazoPagamento = string.IsNullOrEmpty(TbPrazoPgto.Text) ? 0 : Convert.ToInt32(TbPrazoPgto.Text),
                DataPrev = DtPrevEntrega.Value,
                DataEntrega = DtEntregaPedido.Value,
                DataConclusao = DtConclusaoPedido.Value,
                Itens = itensPedidos,
                Observacoes = tbObservacoes.Text,
                ValorLucro = Convert.ToDecimal(TbLucroPedido.Text.Replace("R$", "")),
                TotalPedido = Convert.ToDecimal(TbTotPedido.Text.Replace("R$", "")),
                ValorDesconto = string.IsNullOrEmpty(TbDesconto.Text) ? 0 : Convert.ToDecimal(TbDesconto.Text.Replace("R$", "")),
                TotalGeral = Convert.ToDecimal(TbTotalGeral.Text.Replace("R$", ""))
            };
            new ConexaoBD().InserirPedido(pedido);

            MessageBox.Show("Pedido inserido com sucesso!");
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

        private void BtExclItemPedido_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                DgvItensPedido.Rows.RemoveAt(IdSelecionado);
                DgvItensPedido.Refresh();
            }
        }

        private void BtEditItemPedido_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                CbProdutos.Text = DgvItensPedido.Rows[IdSelecionado].Cells[0].Value.ToString();
                CbProdutos.Enabled = false;
                CbProdutos_SelectedIndexChanged(sender, EventArgs.Empty);
                CbUnidPedido.Text = DgvItensPedido.Rows[IdSelecionado].Cells[1].Value.ToString();
                TbQtdPedido.Text = DgvItensPedido.Rows[IdSelecionado].Cells[2].Value.ToString();
                BtAdicItemPedido.Text = "Alterar";
                BtExclItemPedido.Enabled = false;
                itensPedidos.RemoveAll(x => x.Id_item == Convert.ToInt16(DgvItensPedido.Rows[IdSelecionado].Cells["Id_item"].Value));
            }
        }

        private void PreencheCampos()
        {
            try
            {
                if (Id > 0)
                {
                    Pedido pedido = new ConexaoBD().ConsultarClientePedidoPorId(Id);

                    DtPedido.Value = pedido.DataPedido;
                    IdClienteSelecionado = pedido.IdPessoa;
                    CbNomeCliente_SelectedIndexChanged(null, null);
                    CbStatusPedido.Text = pedido.StatusPedido.ToString();
                    TbPrazoPgto.Text = pedido.PrazoPagamento.ToString();
                    DtPrevEntrega.Value = pedido.DataPrev;
                    DtEntregaPedido.Value = pedido.DataEntrega;
                    DtConclusaoPedido.Value = pedido.DataConclusao;
                    tbObservacoes.Text = pedido.Observacoes;
                    TbLucroPedido.Text = pedido.ValorLucro.ToString();
                    TbTotPedido.Text = pedido.TotalPedido.ToString();
                    TbDesconto.Text = pedido.ValorDesconto.ToString();
                    Total_Geral = pedido.TotalGeral;

                    pedido.Itens = new ConexaoBD().ConsultarItensPedido(pedido.ID);

                    foreach (var item in pedido.Itens)
                        AdicionarPedidoDataGridView(item);

                    CbNomeCliente_SelectedIndexChanged(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}