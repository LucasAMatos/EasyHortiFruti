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
    public partial class FormCadastroProduto : System.Windows.Forms.Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = dtGridViewCadProd.SelectedRows;

                if (linhaSelecionada != null && linhaSelecionada.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                return -1;
            }
        }

        private void btIncluirProduto_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do FormSecundario
            FormProdutosAltInsert FormInserirProduto = new FormProdutosAltInsert();

            // Exibir o FormSecundario
            FormInserirProduto.Show();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btSairCadProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEditarProduto_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormProdutosAltInsert FormProdutosAltInsert = new FormProdutosAltInsert();
                FormProdutosAltInsert.Id = IdSelecionado;
                FormProdutosAltInsert.Show();
            }
            else
                MessageBox.Show("Selecione um registro para alterar");
        }
    }
}
