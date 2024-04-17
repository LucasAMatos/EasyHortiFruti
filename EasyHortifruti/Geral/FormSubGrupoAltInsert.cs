using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EasyHortifruti
{
    public partial class FormSubGrupoAltInsert : FormBase
    {
        public FormSubGrupoAltInsert()
        {
            InitializeComponent();
        }
        private void FormSubGrupoAltInsert_Load(object sender, EventArgs e)
        {
            NomeTabelaBD = "GRUPO";
            CarregarGridGrupo();
        }

        private void CarregarGridGrupo()
        {
            CbGrupo.Items.Clear();
            DataSet ds = new ConexaoBD().ConsultarTabela("GRUPO");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                CbGrupo.Items.Add(dr["nome_grupo"].ToString());
            }
        }

        private void BtGravarSubGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                string Descricao = TbDescSubGrupo.Text; // Obtém o texto do TextBox
                string Grupo = CbGrupo.Text; // Obtém o texto do TextBox
                string MargemLucro = TbMargemSubGrupo.Text; // Obtém o texto do TextBox

                if (idsubgrupo > 0)
                {
                    new ConexaoBD().AlterarSubGrupo(idgrupo, Descricao, Grupo, MargemLucro);
                }
                else
                {
                    new ConexaoBD().InserirSubGrupo(Descricao, Grupo, MargemLucro);
                }

                MessageBox.Show("GRAVOU");
                this.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void BtCancelSubGrupo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
