using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormUnidadeInserir : System.Windows.Forms.Form
    {
        public FormUnidadeInserir()
        {
            InitializeComponent();
        }

        private void BtGravarUnidade_Click(object sender, EventArgs e)
        {
            try
            {
                string Abreviatura = tbCadAbreviUni.Text; // Obtém o texto do TextBox
                string Descricao = tbCadDescricaoUni.Text; // Obtém o texto do TextBox
                string Observacao = tbCadObsUni.Text; // Obtém o texto do TextBox

                new ConexaoBD().InserirUnidades(Abreviatura, Descricao, Observacao);

                this.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void BtCancelCadUnidade_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
