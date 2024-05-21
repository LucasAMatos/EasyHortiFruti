using System;
using System.Data;
using System.Windows.Forms;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;
using FastReport;
using FastReport.Utils;
using FastReport.Export.PdfSimple;
using System.IO;

namespace EasyHortifruti
{
    public partial class FormPedidos : FormBase
    {
        #region Propriedades

        private DataView dvGrid;

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

        // Supondo que você tenha uma DataTable como fonte de dados
        private DataTable dataTable;

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
            tbFiltro.TextChanged += TbFiltro_TextoAlterado;

            DateChanged(null, null);
        }

        public void CarregarGrid()
        {
            dataTable = new ConexaoBD().ConsultarClientePedido().Tables[0];
            DgvPedidos.DataSource = dataTable;
            DgvPedidos.AutoGenerateColumns = false;
        }

        private void CarregarComboFiltros()
        {
            cbFiltro.Add(0, "Cliente");
            cbFiltro.Add(15, "nomefantasia");
            cbFiltro.Add(16, "razaosocial");
        }

        private void Filtrar()
        {
            base.Filtrar(DgvPedidos, dataTable, cbFiltro.SelectedIndex, tbFiltro.Text);
        }

        private void TbFiltro_TextoAlterado(object sender, EventArgs e)
        {
            Filtrar();
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
            // Crie um objeto de relatório
            Report report = new Report();

            // Carregue o modelo do relatório a partir de um arquivo .frx
            report.Load($"{Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "")}\\Relatorios\\arquivo.frx");

            // Opcional: passe dados para o relatório (se necessário)
            report.RegisterData(dvGrid, "dvGrid");

            // Opcional: configure parâmetros do relatório (se necessário)
            report.SetParameterValue("NomeRelatorio", "relatório teste");

            // Prepare o relatório para impressão
            report.Prepare();

            using (FileStream stream = new FileStream("C:\\temp\\pdftaste.pdf", FileMode.Create))
            {
                PDFSimpleExport export = new PDFSimpleExport();
                report.Export(export, stream);
            }

            // Opcional: abra o arquivo PDF após a exportação
            System.Diagnostics.Process.Start("C:\\temp\\pdftaste.pdf");
        }
    }
}