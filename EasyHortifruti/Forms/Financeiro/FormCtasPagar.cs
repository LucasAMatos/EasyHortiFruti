using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyHortifruti.Forms.Financeiro
{
    public partial class FormCtasPagar : Form
    {
        public FormCtasPagar()
        {
            InitializeComponent();
        }

        private void BtBaixaCtaRecebto_Click(object sender, EventArgs e)
        {
        }

        private void BtSairCtasPagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtIncluirCtasPagar_Click(object sender, EventArgs e)
        {
            FormCtasPagarAltInsert CtasPagarInsert = new FormCtasPagarAltInsert();
            CtasPagarInsert.ShowDialog();
        }
    }
}