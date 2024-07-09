using EasyHortifruti.Forms.Financeiro;
using EasyHortifruti.Utilitarios;
using System;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormPrincipal : System.Windows.Forms.Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            CriarTabelas();
        }

        private void BtCadUnidade_Click(object sender, EventArgs e)
        {
            FormUnidadeCad FormUnidadeCad = new FormUnidadeCad();
            FormUnidadeCad.ShowDialog();
        }

        private void BtCadGrupos_Click(object sender, EventArgs e)
        {
            FormGruposCad cadGrupos = new FormGruposCad();
            cadGrupos.ShowDialog();
        }

        private void BtCadSubGrupos_Click(object sender, EventArgs e)
        {
            FormSubGruposCad cadSubGrupos = new FormSubGruposCad();
            cadSubGrupos.ShowDialog();
        }

        private void BtCadGeral_Click(object sender, EventArgs e)
        {
            FormGeralCad FormCadGeral = new FormGeralCad();
            FormCadGeral.ShowDialog();
        }

        private void BtProdutos_Click(object sender, EventArgs e)
        {
            FormCadastroProduto CadastroProduto = new FormCadastroProduto();
            CadastroProduto.ShowDialog();
        }

        private void BtPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos FormPedidos = new FormPedidos();
            FormPedidos.ShowDialog();
        }

        private void BtRelatórios_Click(object sender, EventArgs e)
        {

        }

        private void BtSairPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CriarTabelas()
        {
            new ConexaoBD().CriaTabelasBD();
        }

        private void BtCtasPagar_Click(object sender, EventArgs e)
        {
            FormCtasPagar CtasPagar= new FormCtasPagar();
            CtasPagar.ShowDialog();
        }

        private void BtCtasReceber_Click(object sender, EventArgs e)
        {
            FormCtasReceber CtasReceber = new FormCtasReceber();
            CtasReceber.ShowDialog();
        }

        private void BtBackup_Click(object sender, EventArgs e)
        {
            FormBackupDiario BackupAgora = new FormBackupDiario();
            BackupAgora.ShowDialog();
        }
    }
}