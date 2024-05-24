using EasyHortifruti.DML;
using EasyHortifruti.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyHortifruti.Forms.Produtos
{
    public partial class FormAlterarPrecoCompra : FormBase
    {
        #region propriedades

        private readonly Dictionary<string, int> grupo;

        private readonly Dictionary<string, int> subGrupo;

        private DataSet dsGrid;

        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = DgvListaProdutos.SelectedRows;

                if (linhaSelecionada?.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);
                return -1;
            }
        }

        #endregion propriedades

        #region Construtor

        public FormAlterarPrecoCompra()
        {
            grupo = new Dictionary<string, int>();
            subGrupo = new Dictionary<string, int>();

            InitializeComponent();
            ConfiguraGridPadrao(DgvListaProdutos);
        }

        public FormAlterarPrecoCompra(int pId)
        {
            Id = pId;
            grupo = new Dictionary<string, int>();
            subGrupo = new Dictionary<string, int>();
        }

        #endregion Construtor

        #region Metodos

        private void CarregarComboGrupo()
        {
            CbFiltraGrupo.Clear();
            CbFiltraGrupo.Add(0, string.Empty);
            grupo.Clear();
            DataSet ds = new ConexaoBD().ConsultarGrupos();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                grupo.Add(dr["nome_grupo"].ToString(), Convert.ToInt32(dr["id_recno"]));
                CbFiltraGrupo.Add(Convert.ToInt32(dr["id_recno"]), dr["nome_grupo"].ToString());
            }
        }

        private void CarregarComboProdutos()
        {
            CbFiltraProdutos.Clear();
            CbFiltraProdutos.Add(0, string.Empty);

            foreach (DataRow dr in dsGrid.Tables[0].Rows)
            {
                CbFiltraProdutos.Add(Convert.ToInt32(dr["id_recno"]), dr["nome_produto"].ToString());
            }
        }

        private void CarregarComboSubGrupo()
        {
            CbFiltraSubGrupo.Clear();
            CbFiltraSubGrupo.Add(0, string.Empty);
            subGrupo.Clear();
            DataSet ds = new ConexaoBD().ConsultarSubGrupos();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                subGrupo.Add(dr["nome_subgrupo"].ToString(), Convert.ToInt32(dr["id_recno"]));
                CbFiltraSubGrupo.Add(Convert.ToInt32(dr["id_recno"]), dr["nome_subgrupo"].ToString());
            }
        }

        private void CarregarGrid()
        {
            dsGrid = new ConexaoBD().ConsultarProdutos();
            DgvListaProdutos.DataSource = dsGrid;
            DgvListaProdutos.AutoGenerateColumns = false;
            DgvListaProdutos.DataMember = "Table";
            DgvListaProdutos.Sort(DgvListaProdutos.Columns["Descricao"], System.ComponentModel.ListSortDirection.Ascending);
        }

        #endregion Metodos

        public decimal MontaFormERetornaValorAlterado(string produto)
        {
            using (var form = new Form())
            {
                form.Text = "Editar Valor";
                form.Size = new Size(300, 150);
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.ControlBox = false;
                form.StartPosition = FormStartPosition.CenterParent;

                var label = new Label { Left = 20, Top = 20, Text = $"Digite o novo valor do produto {produto}:" };
                var textBox = new TextBox { Left = 20, Top = 50, Width = 250 };
                var buttonOk = new Button { Text = "OK", Left = 170, Width = 100, Top = 80, DialogResult = DialogResult.OK };
                var buttonCancel = new Button { Text = "Cancelar", Left = 50, Width = 100, Top = 80, DialogResult = DialogResult.Cancel };

                buttonOk.Click += (s, args) => { form.DialogResult = DialogResult.OK; form.Close(); };
                buttonCancel.Click += (s, args) => { form.DialogResult = DialogResult.Cancel; form.Close(); };

                form.Controls.Add(label);
                form.Controls.Add(textBox);
                form.Controls.Add(buttonOk);
                form.Controls.Add(buttonCancel);
                form.AcceptButton = buttonOk;
                form.CancelButton = buttonCancel;

                var result = form.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrEmpty(textBox.Text))
                {
                    return Convert.ToDecimal(textBox.Text);
                }
            }
            return 0;
        }

        private void BtCancelGrupo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtEditarGrupo_Click(object sender, EventArgs e)
        {
            if (DgvListaProdutos.SelectedRows.Count > 0)
            {
                var selectedRow = DgvListaProdutos.SelectedRows[0];
                string produto = selectedRow.Cells[0].Value.ToString();

                decimal vlrVenda = TransformaMoedaEmDecimal(selectedRow.Cells[7].Value.ToString());
                decimal novoValor = MontaFormERetornaValorAlterado(produto);
                selectedRow.Cells[5].Value = novoValor;
                selectedRow.Cells[6].Value = RecalcularPercentualLucro(novoValor, vlrVenda);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha para editar.");
            }
        }

        private void Filtrar(object sender, EventArgs e)
        {
            string pFiltroGrupo = string.IsNullOrEmpty(CbFiltraGrupo.Text) ? string.Empty : $"nome_grupo LIKE '%{CbFiltraGrupo.Text}%'";
            string pFiltroSubGrupo = string.IsNullOrEmpty(CbFiltraSubGrupo.Text) ? string.Empty : $"nome_subgrupo LIKE '%{CbFiltraSubGrupo.Text}%'";
            string pFiltroProdutos = string.IsNullOrEmpty(CbFiltraProdutos.Text) ? string.Empty : $"nome_produto LIKE '%{CbFiltraProdutos.Text}%'";

            string[] filtros = { pFiltroGrupo, pFiltroSubGrupo, pFiltroProdutos };
            StringBuilder resultado = new StringBuilder();

            foreach (string s in filtros)
            {
                if (!string.IsNullOrWhiteSpace(s))
                {
                    if (resultado.Length > 0)
                    {
                        resultado.Append(" AND ");
                    }
                    resultado.Append(s);
                }
            }

            string filtroFinal = resultado.ToString();

            dsGrid.Tables["Table"].DefaultView.RowFilter = filtroFinal;

            DgvListaProdutos.DataSource = dsGrid.Tables["Table"].DefaultView.ToTable();

            DgvListaProdutos.Refresh();
        }

        private void FormAlterarPrecoCompra_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarComboGrupo();
            CarregarComboSubGrupo();
            CarregarComboProdutos();
        }

        private void BtGravarAltPreco_Click(object sender, EventArgs e)
        {
            // Supondo que o DataSet seja dsGrid e a tabela seja "Table"
            DataTable dataTable = dsGrid.Tables["Table"];
            DataView dataView = dataTable.DefaultView;

            // Salva o filtro atual para restaurá-lo mais tarde
            string filtroAtual = dataView.RowFilter;

            try
            {
                // Desabilita o filtro para garantir que todas as linhas sejam processadas
                dataView.RowFilter = string.Empty;

                // Lista de tuplas para armazenar os valores de id e novo valor
                List<Tuple<int, decimal, int>> listaDePrecos = new List<Tuple<int, decimal, int>>();

                // Itera através das linhas do DataGridView
                foreach (DataGridViewRow row in DgvListaProdutos.Rows)
                {
                    // Verifica se a linha não é uma nova linha (row.IsNewRow)
                    if (row.IsNewRow) continue;

                    // Captura o id do produto (assumindo que está em uma célula chamada "id_recno")
                    int id = Convert.ToInt32(row.Cells["id_recno"].Value);

                    // Captura o valor alterado, removendo a máscara de moeda
                    string valorAlteradoStr = row.Cells["vlrAlterado"].Value?.ToString();

                    int margemProduto = Convert.ToInt32(row.Cells["margem_produto"].Value);

                    if (decimal.TryParse(valorAlteradoStr, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal valorAlterado))
                    {
                        // Adiciona a tupla à lista
                        listaDePrecos.Add(new Tuple<int, decimal, int>(id, valorAlterado, margemProduto));
                    }
                    else
                    {
                        // Lida com o caso em que o valor não pode ser convertido para decimal
                        // Ex: Mensagem de erro, logging, etc.
                        // Aqui estou apenas ignorando valores inválidos
                        continue;
                    }
                }

                // Instância da classe ConexaoBD
                ConexaoBD conexaoBD = new ConexaoBD();

                // Itera pela lista de tuplas e chama o método atualizarValor para cada uma
                foreach (var preco in listaDePrecos)
                {
                    conexaoBD.AtualizarValor(preco);
                }

                // Mensagem de confirmação ou qualquer ação subsequente
                MessageBox.Show("Preços atualizados com sucesso!");

                CarregarGrid();
            }
            finally
            {
                // Restaura o filtro original
                dataView.RowFilter = filtroAtual;
            }
        }

        private decimal TransformaMoedaEmDecimal(string valorComMascara)
        {
            decimal valorDecimal;

            CultureInfo culturaBrasileira = new CultureInfo("pt-BR");

            decimal.TryParse(valorComMascara, NumberStyles.Currency, culturaBrasileira, out valorDecimal);

            return valorDecimal;
        }

        public int RecalcularPercentualLucro(decimal valorCompra, decimal valorVenda)
        {
            if (valorCompra <= 0)
            {
                throw new ArgumentException("O valor de compra deve ser maior que zero.", nameof(valorCompra));
            }

            // Calcula o percentual de lucro
            decimal percentualLucro = ((valorVenda - valorCompra) / valorCompra) * 100;

            // Retorna apenas a parte inteira do percentual de lucro
            return (int)Math.Floor(percentualLucro);
        }
    }
}