using System;
using System.Data;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormUnidadeCad : FormBase
    {
        #region Propriedades
        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = dgvCadUnidades.SelectedRows;

                if (linhaSelecionada != null && linhaSelecionada.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                if (dgvCadUnidades.SelectedCells.Count == 1)
                    return Convert.ToInt32(dgvCadUnidades.Rows[dgvCadUnidades.SelectedCells[0].RowIndex].Cells["id"].Value);

                return -1;
            }
        }
        #endregion

        #region Construtor
        public FormUnidadeCad()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void FormUnidadeCad_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btIncluirUnidade_Click(object sender, EventArgs e)
        {
            FormUnidadeAltInsert UnidadeAltInsert = new FormUnidadeAltInsert();
            UnidadeAltInsert.ShowDialog();

            CarregarGrid();
        }

        private void btEditarUnidade_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormUnidadeAltInsert UnidadeAltInsert = new FormUnidadeAltInsert(IdSelecionado);
                UnidadeAltInsert.ShowDialog();

                CarregarGrid();
            }
            else
                MessageBox.Show("selecione um registro para alterar!");
        }
        private void btExcluirUnidades_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja Excluir o registro?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new ConexaoBD().ExcluirUnidade(IdSelecionado);
                    MessageBox.Show("Registro excluído com sucesso");
                }
                CarregarGrid();
            }
            else
                MessageBox.Show("Selecione um registro para excluir");
        }
        private void btSairUnidades_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodos
        private void CarregarGrid()
        {
            dgvCadUnidades.DataSource = new ConexaoBD().ConsultarUnidades(); // dataset
            dgvCadUnidades.DataMember = "Table"; 
            dgvCadUnidades.Sort(dgvCadUnidades.Columns["ID"], System.ComponentModel.ListSortDirection.Ascending);
        }
        #endregion
    }
}
