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
    public partial class FormInserirPedido : System.Windows.Forms.Form
    {
        public FormInserirPedido()
        {
            InitializeComponent();
        }

        private void btCancelarPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
