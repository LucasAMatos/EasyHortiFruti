using EasyHortifruti.DML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EasyHortifruti
{
    public partial class FormPedidoAltInsert : FormBase
    {
        #region propriedades
        Dictionary<string, int> geral;

        Dictionary<string, int> produtos;

        Dictionary<string, int> unidade;

        #endregion

        private Timer timer;
        private Color originalColor;
        private Color warningColor = Color.Red; // Cor de aviso (vermelho)
        private bool warningDisplayed = false;

        public FormPedidoAltInsert()
        {
            geral = new Dictionary<string, int>();
            produtos = new Dictionary<String, int>();
            unidade = new Dictionary<String, int>();

            InitializeComponent();

            // Armazenar a cor original do label
            originalColor = LbAviso.ForeColor;

            // Configurar o Timer
            timer = new Timer();
            timer.Interval = 500; // Intervalo em milissegundos
            timer.Tick += Timer_Tick;

            // Iniciar o Timer
            timer.Start();
        }
        public FormPedidoAltInsert(int pId)
        {
            Id = pId;
            geral = new Dictionary<string, int>();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Alternar entre a cor original e a cor de aviso
            if (warningDisplayed)
            {
                LbAviso.ForeColor = originalColor;
            }
            else
            {
                LbAviso.ForeColor = warningColor;
            }

            // Inverter o estado
            warningDisplayed = !warningDisplayed;
        }

        private void BtBuscaClientePedido_Click(object sender, EventArgs e)
        {
            FormGeralCad BuscaCliente = new FormGeralCad();
            BuscaCliente.ShowDialog();
        }
        private void CarregarGridNomeCliente()
        {
            CbNomeCliente.Items.Clear();
            geral.Clear();
            DataSet ds = new ConexaoBD().ConsultarGerais();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                geral.Add(dr["razaosocial"].ToString(), Convert.ToInt32(dr["id_recno"]));
                CbNomeCliente.Items.Add(dr["razaosocial"].ToString());
            }
            CbNomeCliente.SelectedText = string.Empty;
        }

        private void CarregarComboStatusPedido()
        {
            CbStatusPedido.CarregarValoresEnum<StatusPedido>();
        }

        private void FormPedidoAltInsert_Load(object sender, EventArgs e)
        {
            base.LimparCampos();
            CarregarComboStatusPedido();
            CarregarGridNomeCliente();
            CarregarComboProdutos();
            CarregarComboUnidades();
        }
        
        private void CarregarComboProdutos()
        {
            CbProdutos.Items.Clear();
            produtos.Clear();
            DataSet ds = new ConexaoBD().ConsultarProdutos();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                produtos.Add(dr["nome_produto"].ToString(), Convert.ToInt32(dr["id_recno"]));
                CbProdutos.Items.Add(dr["nome_produto"].ToString());
            }
            CbProdutos.SelectedText = string.Empty;
        }

        private void CbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifique se algum item está selecionado no ComboBox
            if (CbProdutos.SelectedItem != null)
            {
                DataSet ds = new ConexaoBD().ConsultarProdutos();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    produtos.Add(dr["pcocompra_produto"].ToString(), Convert.ToInt32(dr["id_recno"]));
                    TbVlCompra.Text = (dr["pcocompra_produto"].ToString());
                    produtos.Add(dr["margem_produto"].ToString(), Convert.ToInt32(dr["id_recno"]));
                    TbMargemLucro.Text = (dr["margem_produto"].ToString());
                }
            }
        }
        
        private void CarregarComboUnidades()
        {
            CbUnidPedido.Items.Clear();
            unidade.Clear();
            DataSet ds = new ConexaoBD().ConsultarUnidades();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                unidade.Add(dr["abrev_unid"].ToString(), Convert.ToInt32(dr["id_recno"]));
                CbUnidPedido.Items.Add(dr["abrev_unid"].ToString());
            }
            CbUnidPedido.SelectedText = string.Empty;
        }

        private void CalcularValorFinal()
        {
            // Verifica se os TextBoxes têm valores válidos
            if (decimal.TryParse(TbQtdPedido.Text, out decimal quantidade) &&
                decimal.TryParse(TbVlCompra.Text, out decimal valorCompra) &&
                decimal.TryParse(TbMargemLucro.Text, out decimal margemLucro))
            {
                // Calcula o valor da margem de lucro
                decimal valorFinal = valorCompra * (1 + (margemLucro / 100)) * quantidade;

                // Exibir a margem de lucro no TextBox de resultado
                TbTotProdPedido.Text = valorFinal.ToString();
            }
            else
            {
                // Se os TextBoxes não tiverem valores válidos, limpa o TextBox da margem de lucro
                TbTotProdPedido.Text = string.Empty;
            }
        }

        private void BtCancelarPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbQtdPedido_TextChanged(object sender, EventArgs e)
        {
            CalcularValorFinal();
        }

        private void TbVlCompra_TextChanged(object sender, EventArgs e)
        {
            CalcularValorFinal();
        }

        private void TbMargemLucro_TextChanged(object sender, EventArgs e)
        {
            CalcularValorFinal();
        }

        private void CbNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbNomeCliente.SelectedItem != null)
            {
                DataSet ds = new ConexaoBD().ConsultarGerais();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    geral.Add(dr["celular"].ToString(), Convert.ToInt32(dr["id_recno"]));
                    TbCelular.Text = (dr["celular"].ToString());

                }
            }
        }

        private void CbTpDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbTpDocumento.SelectedItem != null)
            {
                // Verifique qual opção está selecionada no ComboBox
               String opcaoSelecionada = CbTpDocumento.SelectedItem.ToString();

                if (opcaoSelecionada == "1")
                {
                    PanelPfPedido.Visible = true;
                    PanelPJPedido.Visible = false;
                }
                 else
                {
                    PanelPfPedido.Visible = false;
                    PanelPJPedido.Visible = true;
                }
            }
        }
    }
}
