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
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

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

        private void btIncluirProduto_Click(object sender, EventArgs e)
        {
            FormProdutosAltInsert FormInserirProduto = new FormProdutosAltInsert();
            FormInserirProduto.ShowDialog();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btSairCadProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEditarProduto_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormProdutosAltInsert FormProdutosAltInsert = new FormProdutosAltInsert();
                FormProdutosAltInsert.Id = IdSelecionado;
                FormProdutosAltInsert.ShowDialog();
            }
            else
                MessageBox.Show("Selecione um registro para alterar");
        }

        public void CarregarGrid()
        {
            dtGridViewCadProd.DataSource = new ConexaoBD().ConsultarTabela(NomeTabelaBD);
            dtGridViewCadProd.DataMember = "Table";
        }

        private void btExcluirProduto_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Excluir", "Cancelar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new ConexaoBD().ExcluirUnidade(IdSelecionado, NomeTabelaBD);
                    MessageBox.Show("Registro excluído com sucesso");
                }
                CarregarGrid();
            }
            else
                MessageBox.Show("Selecione um registro para excluir");
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            NomeTabelaBD = "produtos";
            CarregarGrid();
        }
    }
}
