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
            this.Close(); // Fecha o formulário atual
        }

        private void FormProdutosAltInsert_Load(object sender, EventArgs e)
        {
            NomeTabelaBD = TabelasScript.TabelaUnidades;
            CarregarGridUnidades();
            CarregarGridGrupo();
            CarregarGridSubGrupo();
        }

        private void BtCadUnidade_Click_1(object sender, EventArgs e)
        {
            FormCadUnidade FormCadUnidade = new FormCadUnidade();
            FormCadUnidade.ShowDialog();
        }

        private void BtCadGrupo_Click(object sender, EventArgs e)
        {
            FormCadGrupos cadGrupos = new FormCadGrupos();
            cadGrupos.ShowDialog();
        }

        private void BtCadSubGrupo_Click(object sender, EventArgs e)
        {
            FormCadSubGrupos cadSubGrupos = new FormCadSubGrupos();
            cadSubGrupos.ShowDialog();
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
            DataSet ds = new ConexaoBD().ConsultarTabela(TabelasScript.TabelaGrupos);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cbGrupoProduto.Items.Add(dr["desc_grupo"].ToString());
            }
        }

        private void CarregarGridSubGrupo()
        {
            cbSubGrupoProduto.Items.Clear();
            DataSet ds = new ConexaoBD().ConsultarTabela(TabelasScript.TabelaSubGrupos);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cbSubGrupoProduto.Items.Add(dr["nome_subgrupo"].ToString());
            }
        }
    }
}
