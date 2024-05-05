namespace EasyHortifruti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            this.panel1FormCadProd = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbFiltro = new EasyHortifruti.Componentes.AltComboBox();
            this.tbFiltro = new EasyHortifruti.Componentes.AltTextBox();
            this.dtGridViewCadProd = new System.Windows.Forms.DataGridView();
            this.lbDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbVlrCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbVlrVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbVlrMargem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbSubGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3FormCadProdBotoes = new System.Windows.Forms.Panel();
            this.BtSairCadProduto = new System.Windows.Forms.Button();
            this.BtImprimirProduto = new System.Windows.Forms.Button();
            this.BtExcluirProduto = new System.Windows.Forms.Button();
            this.BtEditarProduto = new System.Windows.Forms.Button();
            this.BtIncluirProduto = new System.Windows.Forms.Button();
            this.panelTituloCadProd = new System.Windows.Forms.Panel();
            this.panel1FormCadProd.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewCadProd)).BeginInit();
            this.panel3FormCadProdBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1FormCadProd
            // 
            this.panel1FormCadProd.Controls.Add(this.tableLayoutPanel2);
            this.panel1FormCadProd.Controls.Add(this.dtGridViewCadProd);
            this.panel1FormCadProd.Controls.Add(this.panel3FormCadProdBotoes);
            this.panel1FormCadProd.Controls.Add(this.panelTituloCadProd);
            this.panel1FormCadProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1FormCadProd.Location = new System.Drawing.Point(0, 0);
            this.panel1FormCadProd.Name = "panel1FormCadProd";
            this.panel1FormCadProd.Size = new System.Drawing.Size(705, 561);
            this.panel1FormCadProd.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.cbFiltro, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbFiltro, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 127);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(705, 44);
            this.tableLayoutPanel2.TabIndex = 7;
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
            this.cbFiltro.Location = new System.Drawing.Point(3, 3);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Obrigatorio = false;
            this.cbFiltro.SelectedIndex = -1;
            this.cbFiltro.SelectedText = "";
            this.cbFiltro.Size = new System.Drawing.Size(205, 41);
            this.cbFiltro.TabIndex = 0;
            // 
            // tbFiltro
            // 
            this.tbFiltro.Caption = "Digite para Filtrar";
            this.tbFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFiltro.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbFiltro.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.Location = new System.Drawing.Point(214, 3);
            this.tbFiltro.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tbFiltro.MaxLength = 32767;
            this.tbFiltro.Multiline = true;
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Obrigatorio = false;
            this.tbFiltro.ReadOnly = false;
            this.tbFiltro.SelectionLength = 0;
            this.tbFiltro.SelectionStart = 0;
            this.tbFiltro.Size = new System.Drawing.Size(488, 35);
            this.tbFiltro.TabIndex = 1;
            this.tbFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFiltro.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // dtGridViewCadProd
            // 
            this.dtGridViewCadProd.AllowUserToAddRows = false;
            this.dtGridViewCadProd.AllowUserToDeleteRows = false;
            this.dtGridViewCadProd.AllowUserToResizeRows = false;
            this.dtGridViewCadProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.dtGridViewCadProd.Location = new System.Drawing.Point(0, 173);
            this.dtGridViewCadProd.Name = "dtGridViewCadProd";
            this.dtGridViewCadProd.ReadOnly = true;
            this.dtGridViewCadProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewCadProd.Size = new System.Drawing.Size(702, 388);
            this.dtGridViewCadProd.TabIndex = 2;
            // 
            // lbDescricao
            // 
            this.lbDescricao.DataPropertyName = "nome_produto";
            this.lbDescricao.HeaderText = "Descrição";
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.ReadOnly = true;
            this.lbDescricao.Width = 180;
            // 
            // lbUnidade
            // 
            this.lbUnidade.DataPropertyName = "abrev_unid";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.lbUnidade.DefaultCellStyle = dataGridViewCellStyle6;
            this.lbUnidade.HeaderText = "Unidade";
            this.lbUnidade.Name = "lbUnidade";
            this.lbUnidade.ReadOnly = true;
            this.lbUnidade.Width = 60;
            // 
            // lbVlrCompra
            // 
            this.lbVlrCompra.DataPropertyName = "pcocompra_produto";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.lbVlrCompra.DefaultCellStyle = dataGridViewCellStyle7;
            this.lbVlrCompra.HeaderText = "Vlr Compra";
            this.lbVlrCompra.Name = "lbVlrCompra";
            this.lbVlrCompra.ReadOnly = true;
            this.lbVlrCompra.Width = 85;
            // 
            // lbVlrVenda
            // 
            this.lbVlrVenda.DataPropertyName = "pcovenda_produto";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.lbVlrVenda.DefaultCellStyle = dataGridViewCellStyle8;
            this.lbVlrVenda.HeaderText = "Vlr Venda";
            this.lbVlrVenda.Name = "lbVlrVenda";
            this.lbVlrVenda.ReadOnly = true;
            this.lbVlrVenda.Width = 80;
            // 
            // lbVlrMargem
            // 
            this.lbVlrMargem.DataPropertyName = "margem_produto";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.lbVlrMargem.DefaultCellStyle = dataGridViewCellStyle9;
            this.lbVlrMargem.HeaderText = "% Lucro";
            this.lbVlrMargem.Name = "lbVlrMargem";
            this.lbVlrMargem.ReadOnly = true;
            this.lbVlrMargem.Width = 70;
            // 
            // lbGrupo
            // 
            this.lbGrupo.DataPropertyName = "nome_grupo";
            this.lbGrupo.HeaderText = "Grupo";
            this.lbGrupo.Name = "lbGrupo";
            this.lbGrupo.ReadOnly = true;
            this.lbGrupo.Width = 70;
            // 
            // lbSubGrupo
            // 
            this.lbSubGrupo.DataPropertyName = "nome_subgrupo";
            this.lbSubGrupo.HeaderText = "SubGrupo";
            this.lbSubGrupo.Name = "lbSubGrupo";
            this.lbSubGrupo.ReadOnly = true;
            this.lbSubGrupo.Width = 70;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_recno";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle10;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 30;
            // 
            // panel3FormCadProdBotoes
            // 
            this.panel3FormCadProdBotoes.Controls.Add(this.BtSairCadProduto);
            this.panel3FormCadProdBotoes.Controls.Add(this.BtImprimirProduto);
            this.panel3FormCadProdBotoes.Controls.Add(this.BtExcluirProduto);
            this.panel3FormCadProdBotoes.Controls.Add(this.BtEditarProduto);
            this.panel3FormCadProdBotoes.Controls.Add(this.BtIncluirProduto);
            this.panel3FormCadProdBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3FormCadProdBotoes.Location = new System.Drawing.Point(0, 66);
            this.panel3FormCadProdBotoes.Name = "panel3FormCadProdBotoes";
            this.panel3FormCadProdBotoes.Size = new System.Drawing.Size(705, 61);
            this.panel3FormCadProdBotoes.TabIndex = 1;
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
            this.BtSairCadProduto.Location = new System.Drawing.Point(647, 4);
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
            this.BtImprimirProduto.Location = new System.Drawing.Point(172, 4);
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
            this.BtExcluirProduto.Location = new System.Drawing.Point(116, 3);
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
            this.BtEditarProduto.Location = new System.Drawing.Point(64, 3);
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
            this.BtIncluirProduto.Location = new System.Drawing.Point(12, 3);
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
            this.panelTituloCadProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloCadProd.Location = new System.Drawing.Point(0, 0);
            this.panelTituloCadProd.Name = "panelTituloCadProd";
            this.panelTituloCadProd.Size = new System.Drawing.Size(705, 66);
            this.panelTituloCadProd.TabIndex = 0;
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 561);
            this.Controls.Add(this.panel1FormCadProd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyHortifruti - Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FormCadastroProduto_Load);
            this.panel1FormCadProd.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewCadProd)).EndInit();
            this.panel3FormCadProdBotoes.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dtGridViewCadProd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Componentes.AltComboBox cbFiltro;
        private Componentes.AltTextBox tbFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbVlrCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbVlrVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbVlrMargem;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbSubGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}