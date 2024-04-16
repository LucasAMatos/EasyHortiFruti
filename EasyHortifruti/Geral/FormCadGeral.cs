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
    public partial class FormCadastroCliente : FormBase
    {
        public FormCadastroCliente()
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

            GeralAltInsert.Show();
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
                GeralAltInsert.Show();
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
                    MessageBox.Show("Registro excluído com sucesso");
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

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            NomeTabelaBD = "GERAL";
            CarregarGrid();
        }
    }
}
