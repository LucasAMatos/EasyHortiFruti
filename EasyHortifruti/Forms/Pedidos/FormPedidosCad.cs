using System;
using System.Data;
using System.Windows.Forms;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Reporting.WinForms;
using EasyHortifruti.DML;
using EasyHortifruti.Componentes;
using System.Web.UI.WebControls;

namespace EasyHortifruti
{
    public partial class FormPedidos : FormBase
    {
        #region Propriedades

        private DataView dvGrid;
        private DataTable dataTable;

        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = DgvPedidos.SelectedRows;

                if (linhaSelecionada?.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                return -1;
            }
        }

        #endregion Propriedades

        #region Construtor

        public FormPedidos()
        {
            InitializeComponent();

            ConfiguraGridPadrao(DgvPedidos);           
        }


        #endregion Construtor

        #region Eventos

        private void BtIncluirPedido_Click(object sender, EventArgs e)
        {
            FormPedidoAltInsert InserirPedido = new FormPedidoAltInsert();
            InserirPedido.ShowDialog();

            CarregarGrid();
        }

        private void BtEditarPedido_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormPedidoAltInsert FormInserirPedido = new FormPedidoAltInsert
                {
                    Id = IdSelecionado
                };
                FormInserirPedido.ShowDialog();

                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um registro para alterar");
            }
        }

        private void BtExcluirPedido_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Excluir", "Cancelar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new ConexaoBD().ExcluirPedido(IdSelecionado);
                    MessageBox.Show("Registro excluído com sucesso");
                }
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir");
            }
        }

        private void BtSairPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Eventos

        #region Metodos

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarComboFiltros();
            TbFiltro.TextChanged += TbFiltro_TextChanged;
            cbFiltro.SelectedIndex = 1;
            DateChanged(null, null);
        }

        public void CarregarGrid()
        {
            dataTable = new ConexaoBD().ConsultarPedidos().Tables[0];
            DgvPedidos.DataSource = dataTable;
            DgvPedidos.AutoGenerateColumns = false;
        }

        private void CarregarComboFiltros()
        {
            cbFiltro.Add(0, "Cliente");
            cbFiltro.Add(15, "nomefantasia");
            cbFiltro.Add(16, "razaosocial");
        }

        private void Filtrar(DataTable dt, int filtroIndex, string filtroTexto)
        {
            //base.Filtrar(DgvPedidos, dataTable, cbFiltro.SelectedIndex, tbFiltro.Text);

            // Crie um DataView a partir do DataTable original
            DataView dv = new DataView(dt);

            // Construa a expressão de filtro com base no índice e no texto do filtro
            string filtro = string.Empty;
            switch (filtroIndex)
            {
                case 0: // Supondo que o índice 0 seja o filtro pelo nome do cliente
                    filtro = $"nCliente LIKE '%{filtroTexto}%'";
                    break;

                case 1: // Supondo que o índice 1 seja o filtro pelo ID do pedido
                    filtro = $"ID = {filtroTexto}";
                    break;
                // Adicione outros casos conforme necessário
                default:
                    filtro = string.Empty;
                    break;
            }

            // Aplique o filtro ao DataView
            dv.RowFilter = filtro;

            // Atualize o DataGridView com os dados filtrados
            DgvPedidos.DataSource = dv;
        }

        //private void TbFiltro_TextoAlterado(object sender, EventArgs e)
        private void TbFiltro_TextChanged(object sender, EventArgs e)
        {
            // Chame a função Filtrar quando o texto do filtro for alterado
            Filtrar(DgvPedidos, dataTable, 1, TbFiltro.Text);
        }

        private void DateChanged(object sender, EventArgs e)
        {
            // Filtro aplicado ao DataTable com base nos DateTimePickers
            dvGrid = dataTable.DefaultView;
            dvGrid.RowFilter = $"datapedido >= #{DtInicio.Value.ToString("yyyy-MM-dd")}# AND datapedido <= #{DtFim.Value.ToString("yyyy-MM-dd")}#";

            // Atualiza o DataGridView
            DgvPedidos.DataSource = dvGrid;
        }

        #endregion Metodos

        private void btImprimirPedido_Click(object sender, EventArgs e)
        {
            try
            {
                // Caminho do arquivo RDL
                string rdlPath = $"{Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "")}\\Relatorios\\Pedidos.rdlc";

                // Cria uma instância do LocalReport
                LocalReport report = new LocalReport();
                report.ReportPath = rdlPath;

                List<Pedido> todosPedidos = new ConexaoBD().ConsultarObjetoPedidos();
                List<Pedido> filtroPedidos = new List<Pedido>();
                foreach (DataGridViewRow dr in DgvPedidos.Rows)
                {
                    filtroPedidos.Add(todosPedidos.First(x => x.ID == Convert.ToInt32(dr.Cells["ID"].Value)));
                }

                report.DataSources.Add(new ReportDataSource("PedidosDS", filtroPedidos));

                RelatorioInfo relatorioInfo = new RelatorioInfo
                {
                    DataInicial = DtInicio.Value,
                    DataFinal = DtFim.Value
                };

                List<RelatorioInfo> relatorioInfoList = new List<RelatorioInfo> { relatorioInfo };
                report.DataSources.Add(new ReportDataSource("RelatorioInfoDS", relatorioInfoList));

                // Renderiza o relatório em formato PDF
                byte[] pdfContent;
                string mimeType, encoding, fileNameExtension;
                string[] streams;
                Warning[] warnings;

                pdfContent = report.Render(
                    "PDF", null, out mimeType, out encoding, out fileNameExtension,
                    out streams, out warnings);

                // Salva o conteúdo do PDF em um arquivo temporário
                string tempFilePath = Path.GetTempFileName() + ".pdf";
                File.WriteAllBytes(tempFilePath, pdfContent);

                // Abre o PDF no visualizador padrão do sistema
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = tempFilePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chame a função Filtrar quando o índice do filtro for alterado
            Filtrar(DgvPedidos, dataTable, 1, TbFiltro.Text);
        }

    }

}