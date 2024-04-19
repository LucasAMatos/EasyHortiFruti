﻿using System;
using System.Data;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormUnidadeAltInsert : FormBase
    {
        #region propriedades

        #endregion

        #region Construtor
        public FormUnidadeAltInsert()
        {
            InitializeComponent();
        }
        public FormUnidadeAltInsert(int pID)
        {
            Id = pID;
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void FormUnidadeAltInsert_Load(object sender, EventArgs e)
        {
            LimpaCampos();

            PreencheCampos();
        }

        private void BtGravarUnidade_Click(object sender, EventArgs e)
        {
            try
            {
                string Abreviatura = tbCadAbreviUni.Text; // Obtém o texto do TextBox
                string Descricao = tbCadDescricaoUni.Text; // Obtém o texto do TextBox
                string Observacao = tbCadObsUni.Text; // Obtém o texto do TextBox

                if (string.IsNullOrEmpty(tbCadAbreviUni.Text))
                    throw new Exception("Abreviatura é Obrigatório");
                if (string.IsNullOrEmpty(tbCadAbreviUni.Text))
                    throw new Exception("Descrição é Obrigatório");

                if (Alterar)
                {
                    new ConexaoBD().AlterarUnidades(Id, Abreviatura, Descricao, Observacao);

                    MessageBox.Show(string.Format("Unidade Alterada com Sucesso!"));
                    this.Close();
                }
                else
                {
                    new ConexaoBD().InserirUnidades(Abreviatura, Descricao, Observacao);

                    DialogResult pNovaUnidade = MessageBox.Show(string.Format("Unidade {0} criada com sucesso! Deseja cadastrar uma nova unidade?", Descricao), string.Empty, MessageBoxButtons.YesNo);
                    if (pNovaUnidade == DialogResult.Yes)
                    {
                        LimpaCampos();
                    }
                    else
                        this.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void BtCancelCadUnidade_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodos
        private void LimpaCampos()
        {
            tbCadAbreviUni.Text = string.Empty;
            tbCadDescricaoUni.Text = string.Empty;
            tbCadObsUni.Text = string.Empty;
            lbIDCadUnidade.Visible = Alterar;
        }

        private void PreencheCampos()
        {
            if (Alterar)
            {
                DataSet ds = new ConexaoBD().ConsultarTabelaPorId(Id, TabelasScript.TabelaUnidades);

                tbCadAbreviUni.Text = ds.Tables[0].Rows[0]["abrev_unid"].ToString();
                lbIDCadUnidade.Text = ds.Tables[0].Rows[0]["id_recno"].ToString();
                tbCadDescricaoUni.Text = ds.Tables[0].Rows[0]["desc_unid"].ToString();
                tbCadObsUni.Text = ds.Tables[0].Rows[0]["obs_unid"].ToString();
            }
        }
        #endregion
    }
}
