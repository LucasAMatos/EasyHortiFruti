using System;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormGruposCad : FormBase
    {
        public FormGruposCad()
        {
            InitializeComponent();
        }

        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = DgViewCadGrupos.SelectedRows;

                if (linhaSelecionada != null && linhaSelecionada.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                return -1;
            }
        }

        private void BtIncluirGrupo_Click(object sender, EventArgs e)
        {
            FormGruposAltInsert formGruposAltInsert = new FormGruposAltInsert();
            formGruposAltInsert.ShowDialog();

            CarregarGrid();
        }

        private void BtEditarGrupo_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormGruposAltInsert GruposAltInsert = new FormGruposAltInsert();
                GruposAltInsert.idgrupo = IdSelecionado;
                GruposAltInsert.ShowDialog();

                CarregarGrid();
            }            
            else
                MessageBox.Show("Selecione um registro para alterar");
        }

        private void BtExcluirGrupo_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Excluir", "Cancelar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new ConexaoBD().ExcluirUnidade(IdSelecionado, TabelasScript.TabelaGrupos);
                    MessageBox.Show("Registro excluído com sucesso");
                }

                CarregarGrid();
            }
            else
                MessageBox.Show("Selecione um registro para excluir");

        }

        public void CarregarGrid()
        {
            DgViewCadGrupos.DataSource = new ConexaoBD().ConsultarTabela(TabelasScript.TabelaGrupos);
            DgViewCadGrupos.DataMember = "Table";
        }

        private void FormCadGrupos_Load(object sender, EventArgs e)
        {
            CarregarGrid();

        }

        private void BtSairGrupo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
