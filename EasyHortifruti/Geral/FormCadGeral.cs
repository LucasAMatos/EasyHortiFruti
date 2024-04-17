using System;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormCadGeral : FormBase
    {
        public FormCadGeral()
        {
            InitializeComponent();
        }

        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = dtGridViewCadGeral.SelectedRows;

                if (linhaSelecionada != null && linhaSelecionada.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                return -1;
            }
        }

        private void btIncluirCliente_Click(object sender, EventArgs e)
        {
            FormGeralAltInsert GeralAltInsert = new FormGeralAltInsert();

            GeralAltInsert.ShowDialog();
        }

        private void btSairCadGeral_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEditarCadGeral_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormGeralAltInsert GeralAltInsert = new FormGeralAltInsert();
                GeralAltInsert.Id = IdSelecionado;
                GeralAltInsert.ShowDialog();
            }
            else
                MessageBox.Show("Selecione um registro para alterar");

        }

        private void btExcluirCadGeral_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Excluir", "Cancelar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Registro deletado com sucesso");
                }

                CarregarGrid();
            }
            else
                MessageBox.Show("Selecione um registro para excluir");
        }

        public void CarregarGrid()
        {
            dtGridViewCadGeral.DataSource = new ConexaoBD().ConsultarTabela(NomeTabelaBD);
            dtGridViewCadGeral.DataMember = "Table";
        }

        private void FormCadGeral_Load(object sender, EventArgs e)
        {
            NomeTabelaBD = "GERAL";
            CarregarGrid();
        }
    }
}
