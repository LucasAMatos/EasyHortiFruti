﻿using Npgsql;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EasyHortifruti
{
    public partial class FormSubGrupoAltInsert : FormBase
    {
        #region propriedades
        Dictionary<int, string> grupos;
        #endregion

        #region construtor
        public FormSubGrupoAltInsert()
        {
            InitializeComponent();
            grupos = new Dictionary<int, string>();
        }
        public FormSubGrupoAltInsert(int pId)
        {
            InitializeComponent();
            Id = pId;
            grupos = new Dictionary<int, string>();
        }
        #endregion

        #region Eventos
        private void FormSubGrupoAltInsert_Load(object sender, EventArgs e)
        {
            LimpaCampos();

            PreencheCampos();
        }


        private void BtGravarSubGrupo_Click(object sender, EventArgs e)
        {
            try
            {

                string Descricao = TbDescSubGrupo.Text; // Obtém o texto do TextBox
                string MargemLucro = TbMargemSubGrupo.Text; // Obtém o texto do TextBox
                int pGrupo = grupos.FirstOrDefault(x => x.Value == CbGrupo.Text).Key;

                if (string.IsNullOrEmpty(TbDescSubGrupo.Text))
                    throw new Exception("Descrição é Obrigatório");
                if (pGrupo < 1)
                    throw new Exception("SubGrupos precisam pertencer a um grupo");

                if (Alterar)
                {
                    new ConexaoBD().AlterarSubGrupo(Id, Descricao, pGrupo, MargemLucro);

                    MessageBox.Show(string.Format("SubGrupo Alterado com Sucesso!"));
                    this.Close();
                }
                else
                {
                    new ConexaoBD().InserirSubGrupo(Descricao, pGrupo, MargemLucro);

                    DialogResult pNovaUnidade = MessageBox.Show(string.Format("SubGrupo {0} criado com sucesso! Deseja cadastrar uma nova unidade?", Descricao), string.Empty, MessageBoxButtons.YesNo);
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

        private void BtCancelSubGrupo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodos
        private void CarregarComboGrupo()
        {
            CbGrupo.Items.Clear();
            DataSet ds = new ConexaoBD().ConsultarTabela(TabelasScript.TabelaGrupos);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                grupos.Add(Convert.ToInt16(dr["id_recno"]), dr["nome_grupo"].ToString());
                CbGrupo.Items.Add(dr["nome_grupo"].ToString());
            }
        }
        private void LimpaCampos()
        {
            TbDescSubGrupo.Text = string.Empty;
            TbMargemSubGrupo.Text = string.Empty;
            CarregarComboGrupo();
            LbIDSubGrupo.Visible = Alterar;
        }

        private void PreencheCampos()
        {
            if (Id > 0)
            {
                DataSet ds = new ConexaoBD().ConsultarSubGrupo(Id);

                TbDescSubGrupo.Text = ds.Tables[0].Rows[0]["nome_subgrupo"].ToString();
                CbGrupo.Text = ds.Tables[0].Rows[0]["nome_grupo"].ToString();
                TbMargemSubGrupo.Text = ds.Tables[0].Rows[0]["margem_subgrupo"].ToString();
                LbIDSubGrupo.Text = ds.Tables[0].Rows[0]["id_recno"].ToString();
            }
        }
        #endregion
    }
}
