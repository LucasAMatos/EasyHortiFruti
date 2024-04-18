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
    public partial class FormGruposAltInsert : FormBase
    {
        public FormGruposAltInsert()
        {
            InitializeComponent();
        }

        private void FormGruposAltInsert_Load(object sender, EventArgs e)
        {
            if (idgrupo > 0)
            {
                DataSet ds = new ConexaoBD().ConsultarTabelaPorId(idgrupo, "GRUPO");

                TbDescGrupo.Text = ds.Tables[0].Rows[0]["nome_grupo"].ToString();
                TbObsGrupo.Text = ds.Tables[0].Rows[0]["Obs_grupo"].ToString();
                TbMargemGrupo.Text = ds.Tables[0].Rows[0]["margem_grupo"].ToString();
                LbIDGrupo.Text = ds.Tables[0].Rows[0]["id_recno"].ToString();
            }
        }

        private void BtGravarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                string Descricao = TbDescGrupo.Text; // Obtém o texto do TextBox
                string Observacao = TbObsGrupo.Text; // Obtém o texto do TextBox
                string MargemLucro = TbMargemGrupo.Text; // Obtém o texto do TextBox

                if (idgrupo > 0 )
                {
                    new ConexaoBD().AlterarGrupo(idgrupo, Descricao, Observacao, MargemLucro);
                }
                else
                {
                    new ConexaoBD().InserirGrupo( Descricao, Observacao, MargemLucro);
                }

                MessageBox.Show("gravou");
                this.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void BtCancelGrupo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
