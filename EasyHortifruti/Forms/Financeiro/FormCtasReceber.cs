using EasyHortifruti.DML;
using System;
using System.Data;

namespace EasyHortifruti
{
    public partial class FormCtasReceber : System.Windows.Forms.Form
    {
        private DataSet dsGrid;

        public FormCtasReceber()
        {
            InitializeComponent();
        }

        private void BtSairCtasReceber_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCtasReceber_Load(object sender, EventArgs e)
        {
            CarregarComboCliente();
            CarregarComboStatusPedido();

            CarregarGrid();
        }

        private void CarregarComboCliente()
        {
            CbFiltroCliente.Clear();
            DataSet gerais = new ConexaoBD().ConsultarGerais();

            foreach (DataRow dr in gerais.Tables[0].Rows)
            {
                CbFiltroCliente.Add(Convert.ToInt32(dr["id_recno"]), dr["razaosocial"].ToString());
            }
        }

        private void CarregarComboStatusPedido()
        {
            CbFiltroSituação.CarregarDescricoesEnum<StatusPedido>();
            CbFiltroSituação.SelectedText = "Todos";
        }

        private void CarregarGrid()
        {
            dsGrid = new ConexaoBD().ConsultarPedidosComFiltros(-1, string.Empty);

            lstBoxHoje.Items.Clear();
            lstBoxProxSemana.Items.Clear();

            lblQtdPedido.Text = $"{dsGrid.Tables[0].Rows.Count} Pedidos";

            double total = 0.0;

            foreach (DataRow row in dsGrid.Tables[0].Rows)
            {
                total += Convert.ToDouble(row["totalvenda"]);
                DateTime pDataConclusao = Convert.ToDateTime(row["dataconclusao"]);
                if(IsToday(pDataConclusao))
                    lstBoxHoje.Items.Add(row["id_recno"]);

                if(IsNextWeek(pDataConclusao))
                    lstBoxProxSemana.Items.Add(row["id_recno"]);
            }

            lblValor.Text = "R$ " + total.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
            dtGridViewCtasReceber.DataSource = dsGrid;
            dtGridViewCtasReceber.AutoGenerateColumns = false;
            dtGridViewCtasReceber.DataMember = "Table";
        }

        private bool IsNextWeek(DateTime pData)
        {
            DateTime domingo = DateTime.Now.Date.AddDays(1);
            while (domingo.DayOfWeek != DayOfWeek.Sunday)
                domingo = domingo.AddDays(1);
            DateTime sabado = domingo.AddDays(6);

            return pData >= domingo && pData <= sabado;
        }

        private bool IsToday(DateTime pData)
        {
            return pData >= DateTime.Now.Date && pData <= DateTime.Now.Date.AddDays(1);
        }
    }
}