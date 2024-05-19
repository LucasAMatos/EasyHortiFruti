using EasyHortifruti.DML;
using EasyHortifruti.Forms.Produtos;
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
        readonly Dictionary<string, int> grupo;

        readonly Dictionary<string, int> subGrupo;

        readonly Dictionary<string, int> unidade;
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
            CarregarComboUnidades();
        }

        private void BtCadGrupo_Click(object sender, EventArgs e)
        {
            FormGruposCad cadGrupos = new FormGruposCad();
            cadGrupos.ShowDialog();
            CarregarComboGrupo();
        }

        private void BtCadSubGrupo_Click(object sender, EventArgs e)
        {
            FormSubGruposCad cadSubGrupos = new FormSubGruposCad();
            cadSubGrupos.ShowDialog();
            CarregarComboSubGrupo();
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

                Criticar();

                Produto produto = new Produto
                {
                    Descricao = tbDescricaoProduto.Text,
                    PrecoDeCompra = Convert.ToDouble(MtbPrecoCompra.Text),
                    PrecoDeVenda = Convert.ToDouble(MtbPrecoVenda.Text),
                    MargemLucro = Convert.ToDouble(MtbMargemLucro.Text),
                    IdSubGrupo = idSubGrupo,
                    IdGrupo = idGrupo,
                    IdUnidade = idUnidade,
                    NCM = txtNCM.Text
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
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MtbMargemLucro_TextChanged(object sender, EventArgs e)
        {
            CalcularMargemLucro();
        }
        private void MtbPrecoCompra_TextChanged(object sender, EventArgs e)
        {
            CalcularMargemLucro();
        }
        #endregion

        #region Metodos
        private void CarregarComboUnidades()
        {
            cbUnidProduto.Items.Clear();
            unidade.Clear();
            DataSet ds = new ConexaoBD().ConsultarUnidades();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                unidade.Add(dr["abrev_unid"].ToString(), Convert.ToInt32(dr["id_recno"]));
                cbUnidProduto.Items.Add(dr["abrev_unid"].ToString());
            }
            cbUnidProduto.SelectedText = string.Empty;
        }

        private void CarregarComboGrupo()
        {
            cbGrupoProduto.Items.Clear();
            cbGrupoProduto.Items.Add(string.Empty);
            grupo.Clear();
            DataSet ds = new ConexaoBD().ConsultarGrupos();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                grupo.Add(dr["nome_grupo"].ToString(), Convert.ToInt32(dr["id_recno"]));
                cbGrupoProduto.Items.Add(dr["nome_grupo"].ToString());
            }
        }

        private void CarregarComboSubGrupo()
        {
            cbSubGrupoProduto.Items.Clear();
            cbSubGrupoProduto.Items.Add(string.Empty);
            subGrupo.Clear();
            DataSet ds = new ConexaoBD().ConsultarSubGrupos();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                subGrupo.Add(dr["nome_subgrupo"].ToString(), Convert.ToInt32(dr["id_recno"]));
                cbSubGrupoProduto.Items.Add(dr["nome_subgrupo"].ToString());
            }
        }

        private void LimparCampos()
        {
            base.LimparCampos();
            CarregarComboUnidades();
            CarregarComboGrupo();
            CarregarComboSubGrupo();
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
                    MtbPrecoCompra.Text = produto.PrecoDeCompra.ToString("N2");
                    MtbPrecoVenda.Text = produto.PrecoDeVenda.ToString("N2");
                    MtbMargemLucro.Text = produto.MargemLucro.ToString();
                    cbUnidProduto.SelecionarIndexPeloConteudo(produto.Unidade);
                    cbGrupoProduto.SelecionarIndexPeloConteudo(produto.Grupo);
                    cbSubGrupoProduto.SelecionarIndexPeloConteudo(produto.SubGrupo);
                    txtNCM.Text = produto.NCM;
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

                // Exibe o valor da margem de lucro no TextBox
                MtbPrecoVenda.Text = valorMargemLucro.ToString("0.00");
            }
            else
            {
                // Se os TextBoxes não tiverem valores válidos, limpa o TextBox da margem de lucro
                MtbPrecoVenda.Text = string.Empty;
            }
        }

        #endregion

        private void BtCadNCM_Click(object sender, EventArgs e)
        {
            FormNcm NCM = new FormNcm();
            NCM.ValorRetornado += (_, valorRetornado) => txtNCM.Text = valorRetornado;
            NCM.Show();
        }
    }
}
