using System;
using System.Data;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormUnidadeCad : FormBase
    {
        #region Propriedades

        private DataSet dsGrid;

        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = dgvCadUnidades.SelectedRows;

                if (linhaSelecionada?.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                if (dgvCadUnidades.SelectedCells.Count == 1)
                    return Convert.ToInt32(dgvCadUnidades.Rows[dgvCadUnidades.SelectedCells[0].RowIndex].Cells["id"].Value);

                return -1;
            }
        }
        #endregion Propriedades

        #region Construtor

        public FormUnidadeCad()
        {
            InitializeComponent();
        }

        #endregion Construtor

        #region Eventos

        private void BtEditarUnidade_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormUnidadesAltInsert UnidadeAltInsert = new FormUnidadesAltInsert(IdSelecionado);
                UnidadeAltInsert.ShowDialog();

                CarregarGrid();
            }
            else
            {
                MessageBox.Show("selecione um registro para alterar!");
            }
        }

        private void BtExcluirUnidades_Click(object sender, EventArgs e)
        {
            if (IdSelecionado < 0)
            {
                MessageBox.Show("Selecione um registro para excluir");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Deseja Excluir o registro?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new ConexaoBD().ExcluirUnidade(IdSelecionado);
                    MessageBox.Show("Registro excluído com sucesso");
                }
                CarregarGrid();
            }
        }

        private void BtIncluirUnidade_Click(object sender, EventArgs e)
        {
            FormUnidadesAltInsert UnidadeAltInsert = new FormUnidadesAltInsert();
            UnidadeAltInsert.ShowDialog();

            CarregarGrid();
        }

        private void BtSairUnidades_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUnidadeCad_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarComboFiltros();
            // Inscreva-se para o evento TextoAlterado do UserControl
            tbFiltro.TextChanged += TbFiltro_TextoAlterado;
        }
        #endregion Eventos

        #region Metodos

        private void CarregarComboFiltros()
        {
            int index = 0;
            foreach (DataGridViewColumn coluna in dgvCadUnidades.Columns)
            {
                if (coluna.Visible)
                    cbFiltro.Add(index, coluna.HeaderText);
                index++;
            }
        }

        private void CarregarGrid()
        {
            dsGrid = new ConexaoBD().ConsultarUnidades();
            dgvCadUnidades.DataSource = dsGrid;
            dgvCadUnidades.DataMember = "Table";
            dgvCadUnidades.AutoGenerateColumns = false;
            dgvCadUnidades.Sort(dgvCadUnidades.Columns["ID"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void Filtrar()
        {
            base.Filtrar(dgvCadUnidades, dsGrid, cbFiltro.SelectedIndex, tbFiltro.Text);
        }

        private void TbFiltro_TextoAlterado(object sender, EventArgs e)
        {
            Filtrar();
        }
        #endregion Metodos
    }
}