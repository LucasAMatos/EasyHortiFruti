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
        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = dtGridViewCadProd.SelectedRows;

                if (linhaSelecionada != null && linhaSelecionada.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                return -1;
            }
        }

        #endregion

        #region Construtor
        public FormCadastroProduto()
        {
            InitializeComponent();
            configuraGridPadrao(dtGridViewCadProd);
        }
        #endregion

        #region Metodos
        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            CarregarGrid();
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
                FormProdutosAltInsert FormProdutosAltInsert = new FormProdutosAltInsert();
                FormProdutosAltInsert.Id = IdSelecionado;
                FormProdutosAltInsert.ShowDialog();
                CarregarGrid();
            }
            else
                MessageBox.Show("Selecione um registro para alterar");
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
                MessageBox.Show("Selecione um registro para excluir");
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

        public void CarregarGrid()
        {
            dtGridViewCadProd.DataSource = new ConexaoBD().ConsultarProdutos();
            dtGridViewCadProd.AutoGenerateColumns = false;
            dtGridViewCadProd.DataMember = "Table";
        }
        #endregion
    }
}
