using System;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormPedidos : FormBase
    {
        #region Propriedades
        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = dataGridView1.SelectedRows;

                if (linhaSelecionada != null && linhaSelecionada.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                return -1;
            }
        }

        #endregion

        #region Construtor
        public FormPedidos()
        {
            InitializeComponent();

            configuraGridPadrao(dataGridView1);
        }
        #endregion

        #region Eventos

        private void btIncluirPedido_Click(object sender, EventArgs e)
        {
            FormPedidoAltInsert InserirPedido = new FormPedidoAltInsert();
            InserirPedido.ShowDialog();
        }

        private void btSairPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEditarPedido_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormGeralAltInsert FormInserirPedido = new FormGeralAltInsert();
                FormInserirPedido.Id = IdSelecionado;
                FormInserirPedido.ShowDialog();
            }
            else
                MessageBox.Show("Selecione um registro para alterar");
        }

        private void btExcluirPedido_Click(object sender, EventArgs e)
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
                MessageBox.Show("Selecione um registro para excluir");
        }
        #endregion

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarComboFiltros();
        }

        #region Metodos
        public void CarregarGrid()
        {
            dataGridView1.DataSource = new ConexaoBD().ConsultarPedidos();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataMember = "Table";
        }
        private void CarregarComboFiltros()
        {
            foreach (DataGridViewColumn coluna in dataGridView1.Columns)
            {
                if (coluna.Visible)
                    cbFiltro.Items.Add(coluna.HeaderText);
            }
        }
        #endregion
    }
}