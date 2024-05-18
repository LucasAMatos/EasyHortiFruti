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
    public partial class FormCtasPagarAltInsert : Form
    {
        public FormCtasPagarAltInsert()
        {
            InitializeComponent();
        }

        private void PanelTop2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelTop3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCtasPagarAltInsert_Load(object sender, EventArgs e)
        {
            CarregarComboPeriodicidade();
            CarregarTipoDocumento();
            CarregarComboCredorFornecedor();
        }

        private void CarregarComboPeriodicidade()
        {
            CbTpConta.Clear();
            CbTpConta.Add(0, "Eventual");
            CbTpConta.Add(1, "Mensal");
            CbTpConta.SelectedIndex = 0;
        }

        private void CarregarComboCredorFornecedor()
        {
            DataSet dsFornecedor = new ConexaoBD().ConsultarGeralPorClassificacao(DML.Classificacao.Fornecedor);
            CbCredorFornecedor.Clear();

            foreach (DataRow dr in dsFornecedor.Tables[0].Rows)
            {
                CbCredorFornecedor.Add(Convert.ToInt32(dr["id_recno"]), dr["razaosocial"].ToString());
            }
        }

        private void CarregarTipoDocumento()
        {
            DataSet dsTiposConta = new ConexaoBD().ConsultarTiposConta();
            CbTpDocumento.Clear();
            foreach (DataRow dr in dsTiposConta.Tables[0].Rows)
            {
                CbTpDocumento.Add(Convert.ToInt32(dr["id_recno"]), dr["descricao"].ToString());
            }
        }

        private void BtCancelarCPInserir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtGravarCPAltInsert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conta cadastrada com Sucesso!");
            this.Close();
        }
    }
}
