using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Npgsql;

namespace EasyHortifruti.DataSets
{
    public partial class Produtos
    {
#pragma warning disable CS0649 // Campo "Produtos.reportViewer" nunca é atribuído e sempre terá seu valor padrão null
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
#pragma warning restore CS0649 // Campo "Produtos.reportViewer" nunca é atribuído e sempre terá seu valor padrão null

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // Instancia a classe que conecta ao banco de dados e obtém os dados
            ConexaoBD conexao = new ConexaoBD();
            DataSet ds = conexao.ConsultarListaDeProdutos();

            // Verifica se o DataSet contém a tabela 'ProdTable'
            if (ds != null && ds.Tables.Contains("ProdTable"))
            {
                DataTable prodTable = ds.Tables["ProdTable"];

                // Configura o ReportDataSource com os dados da tabela 'ProdTable'
                ReportDataSource rds = new ReportDataSource("ProdTable", prodTable);
                this.reportViewer.LocalReport.DataSources.Clear();
                this.reportViewer.LocalReport.DataSources.Add(rds);
                this.reportViewer.RefreshReport();
            }
            else
            {
                MessageBox.Show("A tabela 'ProdTable' não foi encontrada no DataSet.");
            }
        }
    }
}