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

                if (linhaSelecionada?.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);
                return -1;
            }
        }

        #endregion Properties

        #region Construtor

        public FormGeralCad()
        {
            InitializeComponent();

            ConfiguraGridPadrao(DgViewCadGeral);
        }

        #endregion Construtor

        #region Eventos Click

        private void BtIncluirCliente_Click(object sender, EventArgs e)
        {
            FormGeralAltInsert GeralAltInsert = new FormGeralAltInsert();

            GeralAltInsert.ShowDialog();

            CarregarGrid();
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
            {
                MessageBox.Show("Selecione um registro para alterar");
            }
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
            {
                MessageBox.Show("Selecione um registro para excluir");
            }
        }

        private void BtImprimirCadGeral_Click(object sender, EventArgs e)
        {
        }

        private void BtSairCadGeral_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Eventos Click

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
            cbTpFontePesquisa.Clear();
            cbTpFontePesquisa.Add(0, "Todos");
            cbTpFontePesquisa.Add(1, "Cliente");
            cbTpFontePesquisa.Add(2, "Fornecedor");
            cbTpFontePesquisa.Add(3, "Funcionário");
            cbTpFontePesquisa.Add(4, "Sócio");
            cbTpFontePesquisa.Add(5, "Entregador");
        }

        private void CarregarComboFiltros()
        {
            cbFiltro.Add(0, "nomefantasia");
            cbFiltro.Add(1, "Razão Social");
        }

        private void FormCadGeral_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarComboFiltros();
            CarregarComboTipoFonte();
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

        #endregion Metodos

        private void CbTpFontePesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            base.Filtrar(DgViewCadGeral, dsGrid, 14, cbTpFontePesquisa.SelectedIndex == 0 ? string.Empty : cbTpFontePesquisa.SelectedIndex.ToString());
        }
    }
}