using System;
using System.Data;
using System.Windows.Forms;

namespace EasyHortifruti.Forms.Produtos
{
    public partial class FormNcm : Form
    {
        public event EventHandler<string> ValorRetornado;

        private DataSet dsNCM;

        public FormNcm()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            dsNCM = new ConexaoBD().ConsutarNCMs();
            if (dsNCM?.Tables.Count > 0)
                dataGridView1.DataSource = dsNCM.Tables[0];

            cbFiltro.Clear();
            cbFiltro.Add(0, "Número");
            cbFiltro.Add(1, "Descricao");
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Verifica se o formulário está sendo fechado pelo usuário
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (dataGridView1.SelectedCells != null)
                {
                    int indexRow = dataGridView1.SelectedCells[0].RowIndex;
                    ValorRetornado?.Invoke(this, dsNCM.Tables[0].Rows[indexRow]["numero_ncm"].ToString());
                }
            }
        }

        private void AltTextBox1_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text.ToLower(); // Texto digitado no TextBox (convertido para minúsculas)

            // Verifica se o DataGridView possui dados
            if (cbFiltro.SelectedIndex >= 0 && dataGridView1.DataSource != null && dataGridView1.DataSource is DataTable table)
            {
                DataTable dataTable = table;

                // Aplica o filtro nos dados do DataTable
                // Neste exemplo, assumimos que a primeira coluna do DataGridView contém os valores que queremos filtrar
                string filtroExpressao = string.Format("Convert({0}, 'System.String') LIKE '%{1}%'", dataTable.Columns[cbFiltro.SelectedIndex].ColumnName, filtro);
                dataTable.DefaultView.RowFilter = filtroExpressao;
            }
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtFiltro_Load(object sender, EventArgs e)
        {
        }
    }
}