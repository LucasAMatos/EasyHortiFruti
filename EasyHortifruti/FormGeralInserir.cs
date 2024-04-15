using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EasyHortifruti
{
    public partial class FormInserirCliente : System.Windows.Forms.Form
    {
        public FormInserirCliente()
        {
            InitializeComponent();
        }

        private void brPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            panelPessoaFisica.Visible = rbPessoaFisica.Checked;
        }

        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica se o radioButton rbPessoaJuridica está selecionado
            if (rbPessoaJuridica.Checked)
            {
                // Mostra o panel1
                panelPessoaJuridica.Visible = true;
            }
            else
            {
                // Esconde o panel1
                panelPessoaJuridica.Visible = false;
            }
        }

        private void btCancelarInserirCadGeral_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual
            this.Close();
        }
    }
}
