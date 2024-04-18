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
    public partial class FormUnidadeCad : FormBase
    {
        #region Propriedades
        
        DataSet dsUnidades;

        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = dgvCadUnidades.SelectedRows;

                if (linhaSelecionada != null && linhaSelecionada.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                if (dgvCadUnidades.SelectedCells.Count == 1)
                    return Convert.ToInt32(dgvCadUnidades.Rows[dgvCadUnidades.SelectedCells[0].RowIndex].Cells["id"].Value);

                return -1;
            }
        }
        #endregion

        #region Construtor
        public FormUnidadeCad()
        {
            InitializeComponent();
            dsUnidades = new DataSet();
        }
        #endregion

        #region Eventos
        private void btSairUnidades_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUnidadeCad_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btEditarUnidade_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormUnidadeAltInsert UnidadeAltInsert = new FormUnidadeAltInsert();
                UnidadeAltInsert.idunidade = IdSelecionado;

                // Exibir o FormSecundario
                UnidadeAltInsert.ShowDialog();
                CarregarGrid();
            }
            else
                MessageBox.Show("selecione o registro para alterar!");
        }

        private void btIncluirUnidade_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do FormSecundario
            FormUnidadeAltInsert UnidadeAltInsert = new FormUnidadeAltInsert();

            // Exibir o FormSecundario
            UnidadeAltInsert.ShowDialog();
            CarregarGrid();

        }
        private void btExcluirUnidades_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja Excluir o registro?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new ConexaoBD().ExcluirUnidade(IdSelecionado, TabelasScript.TabelaUnidades);
                    MessageBox.Show("Registro excluído com sucesso");
                }
                CarregarGrid();
            }
            else
                MessageBox.Show("Selecione um registro para excluir");
        }
        #endregion

        #region Metodos
        private void CarregarGrid()
        {
            ConexaoBD conexaoBD = new ConexaoBD();

            dsUnidades = conexaoBD.ConsultarTabela(TabelasScript.TabelaUnidades);
            dgvCadUnidades.DataSource = dsUnidades; // dataset
            dgvCadUnidades.DataMember = "Table"; // nome da tabela

            // Especifica qual coluna deve ser usada para ordenação
            DataGridViewColumn colunaParaOrdenar = dgvCadUnidades.Columns["ID"];

            // Ordena os dados na coluna especificada
            dgvCadUnidades.Sort(colunaParaOrdenar, System.ComponentModel.ListSortDirection.Ascending);

        }
        #endregion
    }
}
