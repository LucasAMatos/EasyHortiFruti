using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            FormCadUnidade.ShowDialog();
        }

        private void CarregarGridUnidades()
        { 
            cbUnidProduto.Items.Clear();
            DataSet ds = new ConexaoBD().ConsultarTabela(NomeTabelaBD);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cbUnidProduto.Items.Add(dr["abrev_unid"].ToString());
            }
        }

        private void CarregarGridGrupo()
        { 
            cbGrupoProduto.Items.Clear();
            DataSet ds = new ConexaoBD().ConsultarTabela("GRUPO");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cbSubGrupoProduto.Items.Add(dr["nome_grupo"].ToString());
            }
        }

        private void CarregarGridSubGrupo()
        {
            cbSubGrupoProduto.Items.Clear();
            DataSet ds = new ConexaoBD().ConsultarTabela("SUBGRUPO");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cbSubGrupoProduto.Items.Add(dr["nome_subgrupo"].ToString());
            }
        }

        private void FormProdutosAltInsert_Load(object sender, EventArgs e)
        {
            NomeTabelaBD = "UNIDADES";
            CarregarGridUnidades();
            CarregarGridGrupo();
            CarregarGridSubGrupo();
        }

        private void BtCadGrupo_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do FormSecundario
            FormCadGrupos CadGrupo = new FormCadGrupos();

            // Exibir o FormSecundario
            CadGrupo.ShowDialog();
        }

        private void BtCadSubGrupo_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do FormSecundario
            FormCadSubGrupos CadSubGrupo = new FormCadSubGrupos();

            // Exibir o FormSecundario
            CadSubGrupo.ShowDialog();
        }
    }
}
