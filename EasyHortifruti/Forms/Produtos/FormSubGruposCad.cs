using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormSubGruposCad : FormBase
    {
        #region Propriedades

        private DataSet dsGrid;
        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = DgViewCadSubGrupos.SelectedRows;

                if (linhaSelecionada != null && linhaSelecionada.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                if (DgViewCadSubGrupos.SelectedCells.Count == 1)
                    return Convert.ToInt32(DgViewCadSubGrupos.Rows[DgViewCadSubGrupos.SelectedCells[0].RowIndex].Cells["id"].Value);

                return -1;
            }
        }

        #endregion

        #region construtor
        public FormSubGruposCad()
        {
            InitializeComponent();
        }
        #endregion

        private void FormCadSubGrupos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarComboFiltros();
            configuraGridPadrao(DgViewCadSubGrupos);
            // Inscreva-se para o evento TextoAlterado do UserControl
            tbFiltro.TextChanged += TbFiltro_TextoAlterado;
        }

        private void BtIncluirSubGrupo_Click(object sender, EventArgs e)
        {
            FormSubGruposAltInsert SubGruposAltInsert = new FormSubGruposAltInsert();
            SubGruposAltInsert.ShowDialog();

            CarregarGrid();
        }

        private void BtEditarSubGrupo_Click(object sender, EventArgs e)
        {

            if (IdSelecionado >= 0)
            {
                FormSubGruposAltInsert SubGruposAltInsert = new FormSubGruposAltInsert(IdSelecionado);
                SubGruposAltInsert.ShowDialog();

                CarregarGrid();
            }
            else
                MessageBox.Show("Selecione um registro para alterar");
        } 

        private void BtExcluirSubGrupo_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja Excluir o registro?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new ConexaoBD().ExcluirSubGrupo(IdSelecionado);
                    MessageBox.Show("Registro excluído com sucesso");                }

                CarregarGrid();
            }
            else
                MessageBox.Show("Selecione um registro para excluir");
        }

        private void BtSairSubGrupo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Métodos
        private void CarregarComboFiltros()
        {
            int index = 0;
            foreach (DataGridViewColumn coluna in DgViewCadSubGrupos.Columns)
            {
                if (coluna.Visible)
                    cbFiltro.Add(index, coluna.HeaderText);
                index++;
            }
        }

        public void CarregarGrid()
        {
            dsGrid = new ConexaoBD().ConsultarSubGrupo(0);
            DgViewCadSubGrupos.DataSource = dsGrid;
            DgViewCadSubGrupos.DataMember = "Table";
            DgViewCadSubGrupos.AutoGenerateColumns = false;
            DgViewCadSubGrupos.Sort(DgViewCadSubGrupos.Columns["ID"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void Filtrar()
        {
            base.Filtrar(DgViewCadSubGrupos, dsGrid, cbFiltro.SelectedIndex, tbFiltro.Text);
        }

        private void TbFiltro_TextoAlterado(object sender, EventArgs e)
        {
            Filtrar();
        }
        #endregion
    }
}
