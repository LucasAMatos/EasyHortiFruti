using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EasyHortifruti
{
    public partial class FormCadUnidade : System.Windows.Forms.Form
    {
        private readonly object unidadesTableAdapter;

        public FormCadUnidade()
        {
            InitializeComponent();
        }

        private void btSairUnidades_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadUnidade_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btEditarUnidade_Click(object sender, EventArgs e)
        {

        }

        private void btIncluirUnidade_Click(object sender, EventArgs e)
        {
            FormUnidadeInserir FormCadInserirUnidade = new FormUnidadeInserir();

            FormCadInserirUnidade.ShowDialog();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            ConexaoBD conexaoBD = new ConexaoBD();

            dataGridView1.DataSource = conexaoBD.ConsultarTabela("UNIDADES");
            dataGridView1.DataMember = "Table";
        }

        private void btExcluirUnidades_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection ds = dataGridView1.SelectedRows;

            ConexaoBD conexaoBD = new ConexaoBD();
            conexaoBD.DeletarPeloID(Convert.ToInt32(ds[0].Cells["id"].Value), "UNIDADES");

            CarregarGrid();
        }
    }
}
