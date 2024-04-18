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
        Dictionary<int, string> grupos;

        public FormSubGrupoAltInsert()
        {
            InitializeComponent();
            grupos = new Dictionary<int, string>();
        }
        private void FormSubGrupoAltInsert_Load(object sender, EventArgs e)
        {
            if (idsubgrupo > 0)
            {
                DataSet ds = new ConexaoBD().ConsultarMultiTabelas(idsubgrupo, "SUBGRUPO");

                TbDescSubGrupo.Text = ds.Tables[0].Rows[0]["nome_subgrupo"].ToString();
                CbGrupo.Text = ds.Tables[0].Rows[0]["nome_grupo"].ToString();
                TbMargemSubGrupo.Text = ds.Tables[0].Rows[0]["margem_subgrupo"].ToString();
                LbIDSubGrupo.Text = ds.Tables[0].Rows[0]["id_recno"].ToString();
            }
            CarregarGridGrupo();
        }

        private void CarregarGridGrupo()
        {
            CbGrupo.Items.Clear();
            DataSet ds = new ConexaoBD().ConsultarTabela("GRUPO");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                grupos.Add(Convert.ToInt16(dr["id_recno"]), dr["nome_grupo"].ToString());
                CbGrupo.Items.Add(dr["nome_grupo"].ToString());
            }
        }

        private void BtGravarSubGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                string Descricao = TbDescSubGrupo.Text; // Obtém o texto do TextBox
                string MargemLucro = TbMargemSubGrupo.Text; // Obtém o texto do TextBox
                int pGrupo = grupos.FirstOrDefault(x => x.Value == CbGrupo.Text).Key;

                if (idsubgrupo > 0)
                {
                    new ConexaoBD().AlterarSubGrupo(idsubgrupo, Descricao, pGrupo, MargemLucro);
                }
                else
                {
                    new ConexaoBD().InserirSubGrupo(Descricao, pGrupo, MargemLucro);
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
