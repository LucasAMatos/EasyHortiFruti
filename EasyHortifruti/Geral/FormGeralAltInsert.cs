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

        private void RbPessoaFisica_CheckedChanged_1(object sender, EventArgs e)
        {
            PanelPF.Visible = RbPessoaFisica.Checked;
        }

        private void RbPessoaJuridica_CheckedChanged_1(object sender, EventArgs e)
        {
            PanelPJ.Visible = RbPessoaJuridica.Checked;
        }
        private void BtCancelarGeralInserir_Click(object sender, EventArgs e)
        {
                this.Close();
        }        
    }
}
