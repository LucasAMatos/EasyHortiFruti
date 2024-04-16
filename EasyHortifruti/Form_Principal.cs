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
            FormCadGeral FormCadGeral = new FormCadGeral();
            FormCadGeral.ShowDialog();
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            FormCadastroProduto FormCadastroProduto = new FormCadastroProduto();
            FormCadastroProduto.ShowDialog();
        }

        private void btPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos FormPedidos = new FormPedidos();
            FormPedidos.ShowDialog();
        }

        private void btFinanceiro_Click(object sender, EventArgs e)
        {
            FormCtasReceber FormCtasReceber = new FormCtasReceber();
            FormCtasReceber.ShowDialog();
        }

        private void btSairPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btRelatórios_Click(object sender, EventArgs e)
        {

        }
    }
}
