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
    public partial class FormGeralAltInsert : FormBase
    {
        public FormGeralAltInsert()
        {
            InitializeComponent();
        }

        private void brPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            panelPessoaFisica.Visible = rbPessoaFisica.Checked;
        }

        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            panelPessoaJuridica.Visible = rbPessoaJuridica.Checked;
        }

        private void btCancelarInserirCadGeral_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
