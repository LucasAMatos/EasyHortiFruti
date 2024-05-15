using System;
using System.Data;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormGruposCad : FormBase
    {
        #region Propriedades
        private DataSet dsGrid;

        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = DgViewCadGrupos.SelectedRows;

                if (linhaSelecionada?.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                if (DgViewCadGrupos.SelectedCells.Count == 1)
                    return Convert.ToInt32(DgViewCadGrupos.Rows[DgViewCadGrupos.SelectedCells[0].RowIndex].Cells["id"].Value);

                return -1;
            }
        }

        #endregion Propriedades

        #region Construtor

        public FormGruposCad()
        {
            InitializeComponent();
            ConfiguraGridPadrao(DgViewCadGrupos);
        }

        #endregion Construtor

        #region Eventos

        private void FormCadGrupos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarComboFiltros();
            // Inscreva-se para o evento TextoAlterado do UserControl
            tbFiltro.TextChanged += TbFiltro_TextoAlterado;
        }

        private void BtIncluirGrupo_Click(object sender, EventArgs e)
        {
            FormGruposAltInsert formGruposAltInsert = new FormGruposAltInsert();
            formGruposAltInsert.ShowDialog();

            CarregarGrid();
        }

        private void BtEditarGrupo_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormGruposAltInsert GruposAltInsert = new FormGruposAltInsert(IdSelecionado);
                GruposAltInsert.ShowDialog();

                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um registro para alterar");
            }
        }

        private void BtExcluirGrupo_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja Excluir o registro?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new ConexaoBD().ExcluirGrupo(IdSelecionado);
                    MessageBox.Show("Registro excluído com sucesso");
                }

                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir");
            }
        }

        private void BtSairGrupo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Eventos

        #region Métodos

        private void CarregarComboFiltros()
        {
            int index = 0;
            foreach (DataGridViewColumn coluna in DgViewCadGrupos.Columns)
            {
                if (coluna.Visible)
                    cbFiltro.Add(index, coluna.HeaderText);
                index++;
            }
        }
        public void CarregarGrid()
        {
            dsGrid = new ConexaoBD().ConsultarGrupos();
            DgViewCadGrupos.DataSource = dsGrid;
            DgViewCadGrupos.AutoGenerateColumns = false;
            DgViewCadGrupos.DataMember = "Table";
            DgViewCadGrupos.Sort(DgViewCadGrupos.Columns["ID"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void Filtrar()
        {
            base.Filtrar(DgViewCadGrupos, dsGrid, cbFiltro.SelectedIndex, tbFiltro.Text);
        }

        private void TbFiltro_TextoAlterado(object sender, EventArgs e)
        {
            Filtrar();
        }

        #endregion Métodos
    }
}