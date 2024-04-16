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
    public partial class FormCadGrupos : FormBase
    {
        public FormCadGrupos()
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
        private void FormCadGrupos_Load(object sender, EventArgs e)
        {
            NomeTabelaBD = "GRUPOS";
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            dataGridView1.DataSource = new ConexaoBD().ConsultarTabela(NomeTabelaBD);
            dataGridView1.DataMember = "Table";
        }

        private void BtIncluirGrupo_Click(object sender, EventArgs e)
        {
            FormGruposAltInsert GruposAltInsert = new FormGruposAltInsert();
            GruposAltInsert.ShowDialog();
        }

        private void BtEditarGrupo_Click(object sender, EventArgs e)
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

        private void BtExcluirGrupo_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Excluir", "Cancelar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new ConexaoBD().ExcluirUnidade(IdSelecionado, NomeTabelaBD);
                    MessageBox.Show("Registro excluído com sucesso");
                }

                CarregarGrid();
            }
            else
                MessageBox.Show("Selecione um registro para excluir");

        }
    }
}
