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
    public partial class FormPedidos : FormBase
    {
        public FormPedidos()
        {
            InitializeComponent();
        }

        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = dataGridView1.SelectedRows;

                if (linhaSelecionada != null && linhaSelecionada.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                return -1;
            }
        }

        private void btIncluirPedido_Click(object sender, EventArgs e)
        {
            FormPedidoAltInsert InserirPedido = new FormPedidoAltInsert();
            InserirPedido.ShowDialog();
        }

        private void btSairPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEditarPedido_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormGeralAltInsert FormInserirPedido = new FormGeralAltInsert();
                FormInserirPedido.Id = IdSelecionado;
                FormInserirPedido.ShowDialog();
            }
            else
                MessageBox.Show("Selecione um registro para alterar");
        }

        private void btExcluirPedido_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Excluir", "Cancelar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new ConexaoBD().ExcluirPedido(IdSelecionado);
                    MessageBox.Show("Registro excluído com sucesso");
                }
                CarregarGrid();
            }
            else
                MessageBox.Show("Selecione um registro para excluir");
        }

        public void CarregarGrid()
        {
            dataGridView1.DataSource = new ConexaoBD().ConsultarPedidos();
            dataGridView1.DataMember = "Table";
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
