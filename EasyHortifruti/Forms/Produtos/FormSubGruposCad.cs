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
        }

        private void BtIncluirSubGrupo_Click(object sender, EventArgs e)
        {
            FormSubGrupoAltInsert SubGruposAltInsert = new FormSubGrupoAltInsert();
            SubGruposAltInsert.ShowDialog();

            CarregarGrid();
        }

        private void BtEditarSubGrupo_Click(object sender, EventArgs e)
        {

            if (IdSelecionado >= 0)
            {
                FormSubGrupoAltInsert SubGruposAltInsert = new FormSubGrupoAltInsert(IdSelecionado);
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
                    new ConexaoBD().ExcluirRegistro(IdSelecionado, TabelasScript.TabelaSubGrupos);
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
        public void CarregarGrid()
        {
            DgViewCadSubGrupos.DataSource = new ConexaoBD().ConsultarSubGrupo(0);
            DgViewCadSubGrupos.DataMember = "Table";
            DgViewCadSubGrupos.Sort(DgViewCadSubGrupos.Columns["ID"], System.ComponentModel.ListSortDirection.Ascending);
        }
        #endregion
    }
}
