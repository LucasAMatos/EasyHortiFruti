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

        private void btIncluirProduto_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do FormSecundario
            FormProdutosInserir FormInserirProduto = new FormProdutosInserir();

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
    }
}
