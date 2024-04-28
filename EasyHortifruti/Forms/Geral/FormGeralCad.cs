using System;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormGeralCad : FormBase
    {
        public FormGeralCad()
        {
            InitializeComponent();
            CarregarComboTipoFonte();
        }

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

        private void BtIncluirCliente_Click(object sender, EventArgs e)
        {
            FormGeralAltInsert GeralAltInsert = new FormGeralAltInsert();

            GeralAltInsert.ShowDialog();
        }

        private void BtSairCadGeral_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtEditarCadGeral_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormGeralAltInsert GeralAltInsert = new FormGeralAltInsert
                {
                    Id = IdSelecionado
                };
                GeralAltInsert.ShowDialog();
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

        public void CarregarGrid()
        {
            DgViewCadGeral.DataSource = new ConexaoBD().ConsultarGerais();
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
        private void FormCadGeral_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}