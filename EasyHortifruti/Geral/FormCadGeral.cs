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
    public partial class FormCadastroCliente : System.Windows.Forms.Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void btIncluirCliente_Click(object sender, EventArgs e)
        {
            FormInserirCliente FormInserirCliente = new FormInserirCliente();

            FormInserirCliente.Show();
        }

        private void btSairCadGeral_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
