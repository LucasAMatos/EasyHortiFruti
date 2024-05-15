using System;
using System.Data;
using System.Windows.Forms;

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
        }

        public void CarregarGrid()
        {
            dsGrid = new ConexaoBD().ConsultarClientePedido();
            DgvPedidos.DataSource = dsGrid;
            DgvPedidos.AutoGenerateColumns = false;
            DgvPedidos.DataMember = "Table";
        }

        private void CarregarComboFiltros()
        {
            int index = 0;
            foreach (DataGridViewColumn coluna in DgvPedidos.Columns)
            {
                if (coluna.Visible)
                    cbFiltro.Add(index, coluna.HeaderText);
                index++;
            }
        }

        private void Filtrar()
        {
            base.Filtrar(DgvPedidos, dsGrid, cbFiltro.SelectedIndex, tbFiltro.Text);
        }

        private void TbFiltro_TextoAlterado(object sender, EventArgs e)
        {
            Filtrar();
        }
        #endregion

    }
}