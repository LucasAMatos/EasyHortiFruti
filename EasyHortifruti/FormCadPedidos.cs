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
    public partial class FormPedidos : System.Windows.Forms.Form
    {
        public FormPedidos()
        {
            InitializeComponent();
        }

        private void btIncluirPedido_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do FormSecundario
            FormInserirPedido FormInserirPedido = new FormInserirPedido();

            // Exibir o FormSecundario
            FormInserirPedido.Show();
        }

        private void btSairPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
