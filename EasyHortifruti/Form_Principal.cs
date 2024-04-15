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
    public partial class FormPrincipal : System.Windows.Forms.Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btCadGeral_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do FormSecundario
            FormCadastroCliente FormCadastroCliente = new FormCadastroCliente();

            // Exibir o FormSecundario
            FormCadastroCliente.Show();
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do FormSecundario
            FormCadastroProduto FormCadastroProduto = new FormCadastroProduto();

            // Exibir o FormSecundario
            FormCadastroProduto.Show();
        }

        private void btPedidos_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do FormSecundario
            FormPedidos FormPedidos = new FormPedidos();

            // Exibir o FormSecundario
            FormPedidos.Show();
        }

        private void btFinanceiro_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do FormSecundario
            FormCtasReceber FormCtasReceber = new FormCtasReceber();

            // Exibir o FormSecundario
            FormCtasReceber.Show();
        }

        private void btSairPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
