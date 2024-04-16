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
            DataGridViewSelectedRowCollection ds = dgvCadUnidades.SelectedRows;

            // Criar uma nova instância do FormSecundario
            FormUnidadeAltInsert UnidadeAltInsert = new FormUnidadeAltInsert();

            if (ds.Count != 1)
                MessageBox.Show("selecione a linha!");
            else
            {
                UnidadeAltInsert.idunidade = Convert.ToInt32(ds[0].Cells["id"].Value);

                // Exibir o FormSecundario
                UnidadeAltInsert.ShowDialog();
                CarregarGrid();
            }
        }

        private void btIncluirUnidade_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do FormSecundario
            FormUnidadeAltInsert UnidadeAltInsert = new FormUnidadeAltInsert();

            // Exibir o FormSecundario
            UnidadeAltInsert.ShowDialog();
            CarregarGrid();

        }

        private void CarregarGrid()
        {
            ConexaoBD conexaoBD = new ConexaoBD();

            dgvCadUnidades.DataSource = conexaoBD.ConsultarTabela("UNIDADES"); // dataset
            dgvCadUnidades.DataMember = "Table"; // nome da tabela

            // Especifica qual coluna deve ser usada para ordenação
            DataGridViewColumn colunaParaOrdenar = dgvCadUnidades.Columns["ID"];

            // Ordena os dados na coluna especificada
            dgvCadUnidades.Sort(colunaParaOrdenar, System.ComponentModel.ListSortDirection.Ascending);

        }

        private void btExcluirUnidades_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection ds = dgvCadUnidades.SelectedRows;

            ConexaoBD conexaoBD = new ConexaoBD();
            conexaoBD.ExcluirUnidade(Convert.ToInt32(ds[0].Cells["id"].Value), "UNIDADES");
            CarregarGrid();
        }
    }
}
