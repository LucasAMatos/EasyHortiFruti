﻿namespace EasyHortifruti
{
    partial class FormCadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            this.panel1FormCadProd = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtGridViewCadProd = new System.Windows.Forms.DataGridView();
            this.lbDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbVlrCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbVlrVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbVlrMargem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbSubGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbFiltro = new EasyHortifruti.Componentes.AltComboBox();
            this.tbFiltro = new EasyHortifruti.Componentes.AltTextBox();
            this.panel3FormCadProdBotoes = new System.Windows.Forms.Panel();
            this.BtAtualizaPrecos = new System.Windows.Forms.Button();
            this.BtSairCadProduto = new System.Windows.Forms.Button();
            this.BtImprimirProduto = new System.Windows.Forms.Button();
            this.BtExcluirProduto = new System.Windows.Forms.Button();
            this.BtEditarProduto = new System.Windows.Forms.Button();
            this.BtIncluirProduto = new System.Windows.Forms.Button();
            this.panelTituloCadProd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1FormCadProd.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewCadProd)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3FormCadProdBotoes.SuspendLayout();
            this.panelTituloCadProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1FormCadProd
            // 
            this.panel1FormCadProd.Controls.Add(this.panel3);
            this.panel1FormCadProd.Controls.Add(this.panel1);
            this.panel1FormCadProd.Controls.Add(this.panel3FormCadProdBotoes);
            this.panel1FormCadProd.Controls.Add(this.panelTituloCadProd);
            this.panel1FormCadProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1FormCadProd.Location = new System.Drawing.Point(0, 0);
            this.panel1FormCadProd.Name = "panel1FormCadProd";
            this.panel1FormCadProd.Size = new System.Drawing.Size(784, 661);
            this.panel1FormCadProd.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtGridViewCadProd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 480);
            this.panel3.TabIndex = 9;
            // 
            // dtGridViewCadProd
            // 
            this.dtGridViewCadProd.AllowUserToAddRows = false;
            this.dtGridViewCadProd.AllowUserToDeleteRows = false;
            this.dtGridViewCadProd.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGridViewCadProd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dtGridViewCadProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewCadProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtGridViewCadProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewCadProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lbDescricao,
            this.lbUnidade,
            this.lbVlrCompra,
            this.lbVlrVenda,
            this.lbVlrMargem,
            this.lbGrupo,
            this.lbSubGrupo,
            this.ID});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewCadProd.DefaultCellStyle = dataGridViewCellStyle20;
            this.dtGridViewCadProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridViewCadProd.Location = new System.Drawing.Point(0, 0);
            this.dtGridViewCadProd.Name = "dtGridViewCadProd";
            this.dtGridViewCadProd.ReadOnly = true;
            this.dtGridViewCadProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewCadProd.Size = new System.Drawing.Size(784, 480);
            this.dtGridViewCadProd.TabIndex = 3;
            // 
            // lbDescricao
            // 
            this.lbDescricao.DataPropertyName = "nome_produto";
            this.lbDescricao.HeaderText = "Descrição";
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.ReadOnly = true;
            this.lbDescricao.Width = 200;
            // 
            // lbUnidade
            // 
            this.lbUnidade.DataPropertyName = "abrev_unid";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.lbUnidade.DefaultCellStyle = dataGridViewCellStyle13;
            this.lbUnidade.HeaderText = "Unidade";
            this.lbUnidade.Name = "lbUnidade";
            this.lbUnidade.ReadOnly = true;
            this.lbUnidade.Width = 60;
            // 
            // lbVlrCompra
            // 
            this.lbVlrCompra.DataPropertyName = "pcocompra_produto";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.lbVlrCompra.DefaultCellStyle = dataGridViewCellStyle14;
            this.lbVlrCompra.HeaderText = "Vlr Compra";
            this.lbVlrCompra.Name = "lbVlrCompra";
            this.lbVlrCompra.ReadOnly = true;
            // 
            // lbVlrVenda
            // 
            this.lbVlrVenda.DataPropertyName = "pcovenda_produto";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Format = "C2";
            dataGridViewCellStyle15.NullValue = null;
            this.lbVlrVenda.DefaultCellStyle = dataGridViewCellStyle15;
            this.lbVlrVenda.HeaderText = "Vlr Venda";
            this.lbVlrVenda.Name = "lbVlrVenda";
            this.lbVlrVenda.ReadOnly = true;
            // 
            // lbVlrMargem
            // 
            this.lbVlrMargem.DataPropertyName = "margem_produto";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Format = "N0";
            dataGridViewCellStyle16.NullValue = null;
            this.lbVlrMargem.DefaultCellStyle = dataGridViewCellStyle16;
            this.lbVlrMargem.HeaderText = "% Lucro";
            this.lbVlrMargem.Name = "lbVlrMargem";
            this.lbVlrMargem.ReadOnly = true;
            this.lbVlrMargem.Width = 80;
            // 
            // lbGrupo
            // 
            this.lbGrupo.DataPropertyName = "nome_grupo";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.lbGrupo.DefaultCellStyle = dataGridViewCellStyle17;
            this.lbGrupo.HeaderText = "Grupo";
            this.lbGrupo.Name = "lbGrupo";
            this.lbGrupo.ReadOnly = true;
            // 
            // lbSubGrupo
            // 
            this.lbSubGrupo.DataPropertyName = "nome_subgrupo";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.lbSubGrupo.DefaultCellStyle = dataGridViewCellStyle18;
            this.lbSubGrupo.HeaderText = "SubGrupo";
            this.lbSubGrupo.Name = "lbSubGrupo";
            this.lbSubGrupo.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_recno";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle19;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 54);
            this.panel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.cbFiltro, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbFiltro, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 51);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // cbFiltro
            // 
            this.cbFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cbFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cbFiltro.Caption = "Campo para Filtrar";
            this.cbFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbFiltro.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(15, 3);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(15, 3, 3, 0);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Obrigatorio = false;
            this.cbFiltro.SelectedIndex = -1;
            this.cbFiltro.SelectedItem = null;
            this.cbFiltro.SelectedText = "";
            this.cbFiltro.Size = new System.Drawing.Size(217, 48);
            this.cbFiltro.TabIndex = 0;
            // 
            // tbFiltro
            // 
            this.tbFiltro.Caption = "Digite para Filtrar";
            this.tbFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFiltro.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbFiltro.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.Location = new System.Drawing.Point(255, 3);
            this.tbFiltro.Margin = new System.Windows.Forms.Padding(20, 3, 15, 3);
            this.tbFiltro.MaxLength = 32767;
            this.tbFiltro.Multiline = true;
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Obrigatorio = false;
            this.tbFiltro.ReadOnly = false;
            this.tbFiltro.SelectionLength = 0;
            this.tbFiltro.SelectionStart = 0;
            this.tbFiltro.Size = new System.Drawing.Size(514, 39);
            this.tbFiltro.TabIndex = 1;
            this.tbFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFiltro.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // panel3FormCadProdBotoes
            // 
            this.panel3FormCadProdBotoes.Controls.Add(this.BtAtualizaPrecos);
            this.panel3FormCadProdBotoes.Controls.Add(this.BtSairCadProduto);
            this.panel3FormCadProdBotoes.Controls.Add(this.BtImprimirProduto);
            this.panel3FormCadProdBotoes.Controls.Add(this.BtExcluirProduto);
            this.panel3FormCadProdBotoes.Controls.Add(this.BtEditarProduto);
            this.panel3FormCadProdBotoes.Controls.Add(this.BtIncluirProduto);
            this.panel3FormCadProdBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3FormCadProdBotoes.Location = new System.Drawing.Point(0, 66);
            this.panel3FormCadProdBotoes.Name = "panel3FormCadProdBotoes";
            this.panel3FormCadProdBotoes.Size = new System.Drawing.Size(784, 61);
            this.panel3FormCadProdBotoes.TabIndex = 1;
            // 
            // BtAtualizaPrecos
            // 
            this.BtAtualizaPrecos.BackColor = System.Drawing.Color.Transparent;
            this.BtAtualizaPrecos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtAtualizaPrecos.BackgroundImage")));
            this.BtAtualizaPrecos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtAtualizaPrecos.FlatAppearance.BorderSize = 0;
            this.BtAtualizaPrecos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAtualizaPrecos.Location = new System.Drawing.Point(221, 6);
            this.BtAtualizaPrecos.Name = "BtAtualizaPrecos";
            this.BtAtualizaPrecos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtAtualizaPrecos.Size = new System.Drawing.Size(55, 52);
            this.BtAtualizaPrecos.TabIndex = 12;
            this.BtAtualizaPrecos.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtAtualizaPrecos.UseVisualStyleBackColor = false;
            this.BtAtualizaPrecos.Click += new System.EventHandler(this.BtAtualizaPrecos_Click);
            // 
            // BtSairCadProduto
            // 
            this.BtSairCadProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSairCadProduto.BackColor = System.Drawing.Color.Transparent;
            this.BtSairCadProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtSairCadProduto.BackgroundImage")));
            this.BtSairCadProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtSairCadProduto.FlatAppearance.BorderSize = 0;
            this.BtSairCadProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSairCadProduto.Location = new System.Drawing.Point(723, 4);
            this.BtSairCadProduto.Name = "BtSairCadProduto";
            this.BtSairCadProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtSairCadProduto.Size = new System.Drawing.Size(46, 52);
            this.BtSairCadProduto.TabIndex = 5;
            this.BtSairCadProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtSairCadProduto.UseVisualStyleBackColor = false;
            this.BtSairCadProduto.Click += new System.EventHandler(this.BtSairCadProduto_Click);
            // 
            // BtImprimirProduto
            // 
            this.BtImprimirProduto.BackColor = System.Drawing.Color.Transparent;
            this.BtImprimirProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtImprimirProduto.BackgroundImage")));
            this.BtImprimirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtImprimirProduto.FlatAppearance.BorderSize = 0;
            this.BtImprimirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtImprimirProduto.Location = new System.Drawing.Point(169, 4);
            this.BtImprimirProduto.Name = "BtImprimirProduto";
            this.BtImprimirProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtImprimirProduto.Size = new System.Drawing.Size(46, 52);
            this.BtImprimirProduto.TabIndex = 3;
            this.BtImprimirProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtImprimirProduto.UseVisualStyleBackColor = false;
            this.BtImprimirProduto.Click += new System.EventHandler(this.BtImprimir_Click);
            // 
            // BtExcluirProduto
            // 
            this.BtExcluirProduto.BackColor = System.Drawing.Color.Transparent;
            this.BtExcluirProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtExcluirProduto.BackgroundImage")));
            this.BtExcluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtExcluirProduto.FlatAppearance.BorderSize = 0;
            this.BtExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExcluirProduto.Location = new System.Drawing.Point(113, 3);
            this.BtExcluirProduto.Name = "BtExcluirProduto";
            this.BtExcluirProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtExcluirProduto.Size = new System.Drawing.Size(46, 52);
            this.BtExcluirProduto.TabIndex = 2;
            this.BtExcluirProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtExcluirProduto.UseVisualStyleBackColor = false;
            this.BtExcluirProduto.Click += new System.EventHandler(this.BtExcluirProduto_Click);
            // 
            // BtEditarProduto
            // 
            this.BtEditarProduto.BackColor = System.Drawing.Color.Transparent;
            this.BtEditarProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtEditarProduto.BackgroundImage")));
            this.BtEditarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEditarProduto.FlatAppearance.BorderSize = 0;
            this.BtEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEditarProduto.Location = new System.Drawing.Point(61, 3);
            this.BtEditarProduto.Name = "BtEditarProduto";
            this.BtEditarProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtEditarProduto.Size = new System.Drawing.Size(46, 52);
            this.BtEditarProduto.TabIndex = 1;
            this.BtEditarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEditarProduto.UseVisualStyleBackColor = false;
            this.BtEditarProduto.Click += new System.EventHandler(this.BtEditarProduto_Click);
            // 
            // BtIncluirProduto
            // 
            this.BtIncluirProduto.BackColor = System.Drawing.Color.Transparent;
            this.BtIncluirProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtIncluirProduto.BackgroundImage")));
            this.BtIncluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtIncluirProduto.FlatAppearance.BorderSize = 0;
            this.BtIncluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtIncluirProduto.Location = new System.Drawing.Point(12, 4);
            this.BtIncluirProduto.Name = "BtIncluirProduto";
            this.BtIncluirProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtIncluirProduto.Size = new System.Drawing.Size(46, 52);
            this.BtIncluirProduto.TabIndex = 0;
            this.BtIncluirProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtIncluirProduto.UseVisualStyleBackColor = false;
            this.BtIncluirProduto.Click += new System.EventHandler(this.BtIncluirProduto_Click);
            // 
            // panelTituloCadProd
            // 
            this.panelTituloCadProd.BackColor = System.Drawing.Color.Transparent;
            this.panelTituloCadProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTituloCadProd.BackgroundImage")));
            this.panelTituloCadProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTituloCadProd.Controls.Add(this.label1);
            this.panelTituloCadProd.Controls.Add(this.panel2);
            this.panelTituloCadProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloCadProd.Location = new System.Drawing.Point(0, 0);
            this.panelTituloCadProd.Name = "panelTituloCadProd";
            this.panelTituloCadProd.Size = new System.Drawing.Size(784, 66);
            this.panelTituloCadProd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 66);
            this.panel2.TabIndex = 0;
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.panel1FormCadProd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyHortifruti - Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FormCadastroProduto_Load);
            this.panel1FormCadProd.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewCadProd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3FormCadProdBotoes.ResumeLayout(false);
            this.panelTituloCadProd.ResumeLayout(false);
            this.panelTituloCadProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1FormCadProd;
        private System.Windows.Forms.Panel panelTituloCadProd;
        private System.Windows.Forms.Panel panel3FormCadProdBotoes;
        private System.Windows.Forms.Button BtIncluirProduto;
        private System.Windows.Forms.Button BtEditarProduto;
        private System.Windows.Forms.Button BtExcluirProduto;
        private System.Windows.Forms.Button BtImprimirProduto;
        private System.Windows.Forms.Button BtSairCadProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Componentes.AltComboBox cbFiltro;
        private Componentes.AltTextBox tbFiltro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtGridViewCadProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbVlrCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbVlrVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbVlrMargem;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbSubGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button BtAtualizaPrecos;
    }
}