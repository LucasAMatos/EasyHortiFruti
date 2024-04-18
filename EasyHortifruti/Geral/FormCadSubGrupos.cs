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
    public partial class FormCadSubGrupos : FormBase
    {
        public FormCadSubGrupos()
        {
            InitializeComponent();
        }

        private void FormCadSubGrupos_Load(object sender, EventArgs e)
        {
            NomeTabelaBD = "SUBGRUPO";
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            DgViewCadSubGrupos.DataSource = new ConexaoBD().ConsultarMultiTabelas(Id, NomeTabelaBD);
            DgViewCadSubGrupos.DataMember = "Table";
        }

        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = DgViewCadSubGrupos.SelectedRows;

                if (linhaSelecionada != null && linhaSelecionada.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                return -1;
            }
        }

        private void BtIncluirSubGrupo_Click(object sender, EventArgs e)
        {
            FormSubGrupoAltInsert SubGruposAltInsert = new FormSubGrupoAltInsert();
            SubGruposAltInsert.ShowDialog();
        }

        private void BtEditarSubGrupo_Click(object sender, EventArgs e)
        {

            if (IdSelecionado >= 0)
            {
                FormSubGrupoAltInsert SubGruposAltInsert = new FormSubGrupoAltInsert();
                SubGruposAltInsert.idsubgrupo = IdSelecionado;
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
                DialogResult dialogResult = MessageBox.Show("Excluir", "Cancelar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new ConexaoBD().ExcluirUnidade(IdSelecionado, NomeTabelaBD);
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
    }
}
