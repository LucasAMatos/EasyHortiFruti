using System;
using System.Data;
using System.Windows.Forms;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace EasyHortifruti
{
    public partial class FormPedidos : FormBase
    {
        #region Propriedades
        private DataSet dsGrid;
        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = DgvPedidos.SelectedRows;

                if (linhaSelecionada?.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                return -1;
            }
        }

        // Supondo que você tenha uma DataTable como fonte de dados
        private DataTable dataTable;

        #endregion

        #region Construtor
        public FormPedidos()
        {
            InitializeComponent();

            ConfiguraGridPadrao(DgvPedidos);
        }
        #endregion

        #region Eventos

        private void BtIncluirPedido_Click(object sender, EventArgs e)
        {
            FormPedidoAltInsert InserirPedido = new FormPedidoAltInsert();
            InserirPedido.ShowDialog();

            CarregarGrid();
        }

        private void BtEditarPedido_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormPedidoAltInsert FormInserirPedido = new FormPedidoAltInsert
                {
                    Id = IdSelecionado
                };
                FormInserirPedido.ShowDialog();

                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um registro para alterar");
            }
        }

        private void BtExcluirPedido_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Excluir", "Cancelar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new ConexaoBD().ExcluirPedido(IdSelecionado);
                    MessageBox.Show("Registro excluído com sucesso");
                }
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir");
            }
        }

        private void BtSairPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Metodos

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarComboFiltros();
            tbFiltro.TextChanged += TbFiltro_TextoAlterado;

            DateChanged(null, null);
        }

        public void CarregarGrid()
        {
            dataTable = new ConexaoBD().ConsultarClientePedido().Tables[0];
            DgvPedidos.DataSource = dataTable;
            DgvPedidos.AutoGenerateColumns = false;
        }

        private void CarregarComboFiltros()
        {
            cbFiltro.Add(0, "Cliente");
            cbFiltro.Add(15, "nomefantasia");
            cbFiltro.Add(16, "razaosocial");
        }

        private void Filtrar()
        {
            base.Filtrar(DgvPedidos, dataTable, cbFiltro.SelectedIndex, tbFiltro.Text);
        }

        private void TbFiltro_TextoAlterado(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void DateChanged(object sender, EventArgs e)
        {
            // Filtro aplicado ao DataTable com base nos DateTimePickers
            DataView dv = dataTable.DefaultView;
            dv.RowFilter = $"datapedido >= #{DtInicio.Value.ToString("yyyy-MM-dd")}# AND datapedido <= #{DtFim.Value.ToString("yyyy-MM-dd")}#";

            // Atualiza o DataGridView
            DgvPedidos.DataSource = dv;
        }
        #endregion
    }
}