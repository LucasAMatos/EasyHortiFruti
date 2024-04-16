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
    public partial class FormProdutosAltInsert : FormBase
    {
        public FormProdutosAltInsert()
        {
            InitializeComponent();
        }

        private void BtCancelaProduto_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual
            this.Close();
        }

        private void BtCadUnidade_Click_1(object sender, EventArgs e)
        {
            // Criar uma nova instância do FormSecundario
            FormCadUnidade FormCadUnidade = new FormCadUnidade();

            // Exibir o FormSecundario
            FormCadUnidade.Show();
        }

        private void BtCadGrupo_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do FormSecundario
            FormCadGrupos CadGrupos = new FormCadGrupos();

            // Exibir o FormSecundario
            CadGrupos.Show();
        }

        private void BtCadSubGrupo_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do FormSecundario
            FormCadSubGrupos CadSubGrupos = new FormCadSubGrupos();

            // Exibir o FormSecundario
            CadSubGrupos.Show();
        }
    }
}
