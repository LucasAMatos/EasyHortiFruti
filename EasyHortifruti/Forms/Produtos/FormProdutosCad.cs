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
    public partial class FormCadastroProduto : FormBase
    {
        #region Propriedades

        private DataSet dsGrid;
        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = dtGridViewCadProd.SelectedRows;

                if (linhaSelecionada?.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                return -1;
            }
        }

        #endregion

        #region Construtor
        public FormCadastroProduto()
        {
            InitializeComponent();
            ConfiguraGridPadrao(dtGridViewCadProd);
        }
        #endregion

        #region Metodos
        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarComboFiltros();
            // Inscreva-se para o evento TextoAlterado do UserControl
            tbFiltro.TextChanged += TbFiltro_TextoAlterado;
        }
        private void BtIncluirProduto_Click(object sender, EventArgs e)
        {
            FormProdutosAltInsert InserirProduto = new FormProdutosAltInsert();
            InserirProduto.ShowDialog();
            CarregarGrid();
        }

        private void BtEditarProduto_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormProdutosAltInsert FormProdutosAltInsert = new FormProdutosAltInsert
                {
                    Id = IdSelecionado
                };
                FormProdutosAltInsert.ShowDialog();
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um registro para alterar");
            }
        }

        private void BtExcluirProduto_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Excluir", "Cancelar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new ConexaoBD().ExcluirProduto(IdSelecionado);
                    MessageBox.Show("Registro excluído com sucesso");
                }
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir");
            }
        }

        private void BtImprimir_Click(object sender, EventArgs e)
        {
        }

        private void BtSairCadProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodos

        private void CarregarComboFiltros()
        {
            int index = 0;
            foreach (DataGridViewColumn coluna in dtGridViewCadProd.Columns)
            {
                if (coluna.Visible)
                    cbFiltro.Add(index, coluna.HeaderText);
                index++;
            }
        }

        public void CarregarGrid()
        {
            dsGrid = new ConexaoBD().ConsultarProdutos();
            dtGridViewCadProd.DataSource = dsGrid;
            dtGridViewCadProd.AutoGenerateColumns = false;
            dtGridViewCadProd.DataMember = "Table";
        }

        private void Filtrar()
        {
            base.Filtrar(dtGridViewCadProd, dsGrid, cbFiltro.SelectedIndex, tbFiltro.Text);
        }

        private void TbFiltro_TextoAlterado(object sender, EventArgs e)
        {
            Filtrar();
        }
        #endregion
    }
}
