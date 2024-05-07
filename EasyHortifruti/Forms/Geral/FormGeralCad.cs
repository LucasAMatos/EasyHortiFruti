using System;
using System.Data;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormGeralCad : FormBase
    {
        #region Properties

        private DataSet dsGrid;

        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = DgViewCadGeral.SelectedRows;

                if (linhaSelecionada != null && linhaSelecionada.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);
                return -1;
            }
        }
        #endregion

        #region Construtor
        public FormGeralCad()
        {
            InitializeComponent();

            configuraGridPadrao(DgViewCadGeral);
        }
        #endregion

        #region Eventos
        private void BtIncluirCliente_Click(object sender, EventArgs e)
        {
            FormGeralAltInsert GeralAltInsert = new FormGeralAltInsert();

            GeralAltInsert.ShowDialog();
        }

        private void BtEditarCadGeral_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormGeralAltInsert GeralAltInsert = new FormGeralAltInsert(IdSelecionado);
                GeralAltInsert.ShowDialog();

                CarregarGrid();
            }
            else
                MessageBox.Show("Selecione um registro para alterar");
        }

        private void BtExcluirCadGeral_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Excluir", "Cancelar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new ConexaoBD().ExcluirGeral(IdSelecionado);
                    MessageBox.Show("Registro excluído com sucesso");
                }
                CarregarGrid();
            }
            else
                MessageBox.Show("Selecione um registro para excluir");
        }

        private void BtSairCadGeral_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Metodos
        public void CarregarGrid()
        {
            dsGrid = new ConexaoBD().ConsultarGerais();
            DgViewCadGeral.DataSource = dsGrid;
            DgViewCadGeral.AutoGenerateColumns = false;
            DgViewCadGeral.DataMember = "Table";
        }

        public void CarregarComboTipoFonte()
        {
            cbTpFontePesquisa.Items.Clear();
            cbTpFontePesquisa.Items.AddRange(new object[] {
            "Cliente",
            "Entregador",
            "Fornecedor",
            "Funcionário",
            "Sócio"});
        }
        private void CarregarComboFiltros()
        {
            int index = 0;
            foreach (DataGridViewColumn coluna in DgViewCadGeral.Columns)
            {
                if (coluna.Visible)
                    cbFiltro.Add(index, coluna.HeaderText);
                index++;
            }
        }

        private void FormCadGeral_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarComboFiltros();
            // Inscreva-se para o evento TextoAlterado do UserControl
            tbFiltro.TextChanged += TbFiltro_TextoAlterado;
        }

        private void Filtrar()
        {
            base.Filtrar(DgViewCadGeral, dsGrid, cbFiltro.SelectedIndex, tbFiltro.Text);
        }

        private void TbFiltro_TextoAlterado(object sender, EventArgs e)
        {
            Filtrar();
        }
        #endregion
    }
}