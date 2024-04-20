using EasyHortifruti.DML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormProdutosAltInsert : FormBase
    {
        #region propriedades
        Dictionary<string, int> grupo;

        Dictionary<string, int> subGrupo;

        Dictionary<string, int> unidade;
        #endregion
        
        #region Construtor
        public FormProdutosAltInsert()
        {
            grupo = new Dictionary<string, int>();
            subGrupo = new Dictionary<string, int>();
            unidade = new Dictionary<string, int>();
            
            InitializeComponent();
        }

        public FormProdutosAltInsert(int pId)
        { 
            Id = pId;
            grupo = new Dictionary<string, int>();
            subGrupo = new Dictionary<string, int>();
            unidade = new Dictionary<string, int>();
        }
        #endregion

        #region Eventos
        private void FormProdutosAltInsert_Load(object sender, EventArgs e)
        {
            LimparCampos();

            PreencheCampos();
        }

        private void BtCadUnidade_Click(object sender, EventArgs e)
        {
            FormUnidadeCad FormUnidadeCad = new FormUnidadeCad();
            FormUnidadeCad.ShowDialog();
        }

        private void BtCadGrupo_Click(object sender, EventArgs e)
        {
            FormGruposCad cadGrupos = new FormGruposCad();
            cadGrupos.ShowDialog();
        }

        private void BtCadSubGrupo_Click(object sender, EventArgs e)
        {
            FormSubGruposCad cadSubGrupos = new FormSubGruposCad();
            cadSubGrupos.ShowDialog();
        }

        private void BtCancelaProduto_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void BtGravaAlterProd_Click(object sender, EventArgs e)
        {
            try
            {
                subGrupo.TryGetValue(cbSubGrupoProduto.Text, out int idSubGrupo);
                grupo.TryGetValue(cbGrupoProduto.Text, out int idGrupo);
                unidade.TryGetValue(cbUnidProduto.Text, out int idUnidade);

                CriticarCampos();

                Produto produto = new Produto
                {
                    Descricao = tbDescricaoProduto.Text,
                    PrecoDeCompra = Convert.ToDouble(MtbPrecoCompra.Text),
                    PrecoDeVenda = Convert.ToDouble(MtbPrecoVenda.Text),
                    MargemLucro = Convert.ToDouble(MtbMargemLucro.Text),
                    IdSubGrupo = idSubGrupo,
                    IdGrupo = idGrupo,
                    IdUnidade = idUnidade
                };


                if (Alterar)
                {
                    produto.ID = Convert.ToInt32(labelIDProduto.Text);
                    new ConexaoBD().AlterarProduto(produto);

                    MessageBox.Show(string.Format("Produto Alterado com Sucesso!"));
                    this.Close();
                }
                else
                {
                    new ConexaoBD().IncluirProduto(produto);

                    DialogResult pNovaUnidade = MessageBox.Show(string.Format("Produto {0} criado com sucesso! Deseja cadastrar um novo produto?", produto.Descricao), string.Empty, MessageBoxButtons.YesNo);
                    if (pNovaUnidade == DialogResult.Yes)
                    {
                        LimparCampos();
                    }
                    else
                        this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Metodos
        private void CriticarCampos()
        {
            try
            {
                if (string.IsNullOrEmpty(tbDescricaoProduto.Text))
                    throw new Exception("Descrição é Obrigatório");
                if (cbUnidProduto.SelectedIndex < 0)
                    throw new Exception("Selecione uma Unidade");
                if (string.IsNullOrEmpty(MtbPrecoCompra.Text))
                    throw new Exception("Preço de Compra é Obrigatório");
                if (string.IsNullOrEmpty(MtbPrecoVenda.Text))
                    throw new Exception("Preço de Venda é Obrigatório");
                if (string.IsNullOrEmpty(MtbMargemLucro.Text))
                    throw new Exception("Margem Lucro é Obrigatório");
                //if (cbGrupoProduto.SelectedIndex < 0)
                  //  throw new Exception("Selecione um grupo");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CarregarGridUnidades()
        { 
            cbUnidProduto.Items.Clear();
            unidade.Clear();
            DataSet ds = new ConexaoBD().ConsultarTabela(TabelasScript.TabelaUnidades);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                unidade.Add(dr["abrev_unid"].ToString(), Convert.ToInt16(dr["id_recno"]));
                cbUnidProduto.Items.Add(dr["abrev_unid"].ToString());
            }
            cbUnidProduto.SelectedText = string.Empty;
        }

        private void CarregarGridGrupo()
        { 
            cbGrupoProduto.Items.Clear();
            cbGrupoProduto.Items.Add(string.Empty);
            grupo.Clear();
            DataSet ds = new ConexaoBD().ConsultarTabela(TabelasScript.TabelaGrupos);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                grupo.Add(dr["nome_grupo"].ToString(), Convert.ToInt16(dr["id_recno"]));
                cbGrupoProduto.Items.Add(dr["nome_grupo"].ToString());
            }
        }

        private void CarregarGridSubGrupo()
        {
            cbSubGrupoProduto.Items.Clear();
            cbSubGrupoProduto.Items.Add(string.Empty);
            subGrupo.Clear();
            DataSet ds = new ConexaoBD().ConsultarTabela(TabelasScript.TabelaSubGrupos);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                subGrupo.Add(dr["nome_subgrupo"].ToString(), Convert.ToInt16(dr["id_recno"]));
                cbSubGrupoProduto.Items.Add(dr["nome_subgrupo"].ToString());
            }
        }

        private void LimparCampos()
        {
            tbDescricaoProduto.Text = string.Empty;
            CarregarGridUnidades();
            MtbPrecoCompra.Text = string.Empty;
            MtbPrecoVenda.Text = string.Empty;
            MtbMargemLucro.Text = string.Empty;
            CarregarGridGrupo();
            CarregarGridSubGrupo();
            CalcularMargemLucro();

            labelIDProduto.Visible = Alterar;
        }

        private void PreencheCampos()
        {
            if (Id > 0)
            {
                Produto produto = new ConexaoBD().ConsultarProdutoPorId(Id);

                if (produto != null)
                {
                    tbDescricaoProduto.Text = produto.Descricao;
                    MtbPrecoCompra.Text = produto.PrecoDeCompra.ToString();
                    MtbPrecoVenda.Text = produto.PrecoDeVenda.ToString();
                    MtbMargemLucro.Text = produto.MargemLucro.ToString();
                    cbUnidProduto.Text = produto.Unidade;
                    cbGrupoProduto.Text = produto.Grupo;
                    cbSubGrupoProduto.Text = produto.SubGrupo;

                    labelIDProduto.Text = Id.ToString();
                    CalcularMargemLucro();
                }
            }
        }

        private void CalcularMargemLucro()
        {
            // Verifica se os TextBoxes têm valores válidos
            if (decimal.TryParse(MtbPrecoCompra.Text, out decimal valorCompra) &&
                decimal.TryParse(MtbMargemLucro.Text, out decimal margemLucro))
            {
                // Calcula o valor da margem de lucro
                decimal valorMargemLucro = valorCompra * (1 + (margemLucro / 100));

                // Exibir a margem de lucro no TextBox de resultado
                MtbMargemLucro.Text = margemLucro.ToString();

                // Exibe o valor da margem de lucro no TextBox
                MtbPrecoVenda.Text = valorMargemLucro.ToString();
            }
            else
            {
                // Se os TextBoxes não tiverem valores válidos, limpa o TextBox da margem de lucro
                MtbPrecoVenda.Text = string.Empty;
            }
        }

        private void MtbPrecoVenda_TextChanged(object sender, EventArgs e)
        {
            CalcularMargemLucro();
        }

        private void MtbMargemLucro_TextChanged(object sender, EventArgs e)
        {
            CalcularMargemLucro();
        }

       

        #endregion

    }
}
