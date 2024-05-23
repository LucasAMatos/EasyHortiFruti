using EasyHortifruti.DML;
using FastReport.DataVisualization.Charting;
using FastReport.DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyHortifruti.Forms.Produtos
{

    public partial class FormAlterarPrecoCompra : FormBase
    {
        #region propriedades
        readonly Dictionary<string, int> grupo;

        readonly Dictionary<string, int> subGrupo;

        private object dsGrid;

        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = DgvListaProdutos.SelectedRows;

                if (linhaSelecionada?.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);
                return -1;
            }
        }

        #endregion

        #region Construtor
        public FormAlterarPrecoCompra()
        {
            grupo = new Dictionary<string, int>();
            subGrupo = new Dictionary<string, int>();

            InitializeComponent();
            ConfiguraGridPadrao(DgvListaProdutos);

        }

        public FormAlterarPrecoCompra(int pId)
        {
            Id = pId;
            grupo = new Dictionary<string, int>();
            subGrupo = new Dictionary<string, int>();
        }
        #endregion

        #region Metodos
        private void BtEditarGrupo_Click(object sender, EventArgs e)
        {

        }

        private void BtImprimirGrupo_Click(object sender, EventArgs e)
        {

        }
        private void CarregarComboGrupo()
        {
            CbFiltraGrupo.Items.Clear();
            CbFiltraGrupo.Items.Add(string.Empty);
            grupo.Clear();
            DataSet ds = new ConexaoBD().ConsultarGrupos();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                grupo.Add(dr["nome_grupo"].ToString(), Convert.ToInt32(dr["id_recno"]));
                CbFiltraGrupo.Items.Add(dr["nome_grupo"].ToString());
            }
        }

        private void CarregarComboSubGrupo()
        {
            CbFiltraSubGrupo.Items.Clear();
            CbFiltraSubGrupo.Items.Add(string.Empty);
            subGrupo.Clear();
            DataSet ds = new ConexaoBD().ConsultarSubGrupos();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                subGrupo.Add(dr["nome_subgrupo"].ToString(), Convert.ToInt32(dr["id_recno"]));
                CbFiltraSubGrupo.Items.Add(dr["nome_subgrupo"].ToString());
            }
        }

        private void CarregarGrid()
        {
            dsGrid = new ConexaoBD().ConsultarProdutos();
            DgvListaProdutos.DataSource = dsGrid;
            DgvListaProdutos.AutoGenerateColumns = false;
            DgvListaProdutos.DataMember = "Table";
            
        }    

        #endregion

        private void FormAlterarPrecoCompra_Load(object sender, EventArgs e)
        {
            CarregarComboGrupo();
            CarregarComboSubGrupo();
            CarregarGrid();
            //Filtrar();

        }

        private void BtCancelGrupo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Metodo de Filtro
        private void CarregarComboFiltros()
        {

        }
        private void Filtrar()
        {
 
        }

        #endregion

        private void CbFiltraGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            base.Filtrar(DgvListaProdutos, (DataSet)dsGrid, 14, CbFiltraGrupo.SelectedIndex == 0 ? string.Empty : CbFiltraGrupo.SelectedIndex.ToString());

        }

        private void BtGravarAltPreco_Click(object sender, EventArgs e)
        {

        }
    }
}
