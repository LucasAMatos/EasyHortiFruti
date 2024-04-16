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
                DataGridViewSelectedRowCollection linhaSelecionada = DgvCadSubGrupo.SelectedRows;

                if (linhaSelecionada != null && linhaSelecionada.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                return -1;
            }
        }
        private void FormCadSubGrupos_Load(object sender, EventArgs e)
        {
            NomeTabelaBD = "SUBGRUPOS";
            CarregarGrid();
        }
        public void CarregarGrid()
        {
            DgvCadSubGrupo.DataSource = new ConexaoBD().ConsultarTabela(NomeTabelaBD);
            DgvCadSubGrupo.DataMember = "Table";
        }


        private void BtIncluirSubGrupo_Click(object sender, EventArgs e)
        {
            FormGruposAltInsert GruposAltInsert = new FormGruposAltInsert();
            GruposAltInsert.ShowDialog();

        }

        private void BtEditarSubGrupo_Click(object sender, EventArgs e)
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

        private void BtExcluirSubGrupo_Click(object sender, EventArgs e)
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

        private void BtSairSubGrupo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
