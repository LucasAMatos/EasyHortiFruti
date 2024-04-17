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

        private void BtSairSubGrupo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtIncluirSubGrupo_Click(object sender, EventArgs e)
        {
            FormSubGrupoAltInsert SubGruposAltInsert = new FormSubGrupoAltInsert();
            SubGruposAltInsert.ShowDialog();
        }

        private void BtEditarSubGrupo_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection ds = DgViewCadSubGrupos.SelectedRows;

            // Criar uma nova instância do FormSecundario
            FormSubGrupoAltInsert SubGrupoAltInsert = new FormSubGrupoAltInsert();

            if (ds.Count != 1)
                MessageBox.Show("Selecione a linha para poder alterar!");
            else
            {
                SubGrupoAltInsert.idgrupo = Convert.ToInt32(ds[0].Cells["id"].Value);

                // Exibir o FormSecundario
                SubGrupoAltInsert.ShowDialog();
                CarregarGrid();
            }
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

        public void CarregarGrid()
        {
            DgViewCadSubGrupos.DataSource = new ConexaoBD().ConsultarTabela(NomeTabelaBD);
            DgViewCadSubGrupos.DataMember = "Table";
        }

    }
}
