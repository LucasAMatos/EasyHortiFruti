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

        private void btSairSubGrupo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btIncluirSubGrupo_Click(object sender, EventArgs e)
        {
            FormGruposAltInsert GruposAltInsert = new FormGruposAltInsert();
            GruposAltInsert.ShowDialog();

        }

        private void btEditarSubGrupo_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormGruposAltInsert GruposAltInsert = new FormGruposAltInsert();
                GruposAltInsert.Id = IdSelecionado;
                GruposAltInsert.ShowDialog();
            }
            else
                MessageBox.Show("Selecione um registro para alterar");
        }

        private void btExcluirSubGrupo_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Excluir", "Cancelar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Registro excluído com sucesso");
                }

                CarregarGrid();
            }
            else
                MessageBox.Show("Selecione um registro para excluir");

        }

        public void CarregarGrid()
        {
            dataGridView1.DataSource = new ConexaoBD().ConsultarTabela(NomeTabelaBD);
            dataGridView1.DataMember = "Table";
        }

        private void FormCadSubGrupos_Load(object sender, EventArgs e)
        {
            NomeTabelaBD = "SUBGRUPOS";
            CarregarGrid();
        }
    }
}
