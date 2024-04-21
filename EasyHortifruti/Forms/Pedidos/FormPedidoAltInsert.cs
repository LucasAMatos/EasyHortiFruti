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
    public partial class FormPedidoAltInsert : FormBase
    {
        #region propriedades
        Dictionary<string, int> geral;

        #endregion

        private Timer timer;
        private Color originalColor;
        private Color warningColor = Color.Red; // Cor de aviso (vermelho)
        private bool warningDisplayed = false;

        public FormPedidoAltInsert()
        {
            geral = new Dictionary<string, int>();

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

        private void BtCancelarPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbTpDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            DataSet ds = new ConexaoBD().ConsultarTabela(TabelasScript.TabelaUnidades);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                geral.Add(dr["razao_social"].ToString(), Convert.ToInt16(dr["id_recno"]));
                CbNomeCliente.Items.Add(dr["razao_social"].ToString());
            }
            CbNomeCliente.SelectedText = string.Empty;
        }
    }
}
