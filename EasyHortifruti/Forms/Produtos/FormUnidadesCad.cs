using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

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

        private DataSet dsGrid;
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
            CarregarComboFiltros();
            // Inscreva-se para o evento TextoAlterado do UserControl
            tbFiltro.TextChanged += TbFiltro_TextoAlterado;
        }

        private void btIncluirUnidade_Click(object sender, EventArgs e)
        {
            FormUnidadesAltInsert UnidadeAltInsert = new FormUnidadesAltInsert();
            UnidadeAltInsert.ShowDialog();

            CarregarGrid();
        }

        private void btEditarUnidade_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormUnidadesAltInsert UnidadeAltInsert = new FormUnidadesAltInsert(IdSelecionado);
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
            dsGrid = new ConexaoBD().ConsultarUnidades();
            dgvCadUnidades.DataSource = dsGrid;
            dgvCadUnidades.DataMember = "Table";
            dgvCadUnidades.AutoGenerateColumns = false;
            dgvCadUnidades.Sort(dgvCadUnidades.Columns["ID"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void CarregarComboFiltros()
        {
            foreach (DataGridViewColumn coluna in dgvCadUnidades.Columns)
            {
                if(coluna.Visible)
                    cbFiltro.Items.Add(coluna.HeaderText);
            }
        }

        private void TbFiltro_TextoAlterado(object sender, EventArgs e)
        {
            // Quando o texto no UserControl é alterado, chame o método Filtrar do formulário
            Filtrar();
        }

        // Método para filtrar, este é apenas um exemplo
        private void Filtrar()
        {
            string coluna = dgvCadUnidades.Columns[cbFiltro.SelectedIndex].DataPropertyName;
            dsGrid.Tables["Table"].DefaultView.RowFilter = $"{coluna} LIKE '%{tbFiltro.Text}%'";
            dgvCadUnidades.DataSource = dsGrid.Tables["Table"].DefaultView;
        }
        #endregion
    }
}
