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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            this.panel1FormCadProd = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewCadProd)).BeginInit();
            this.panel3FormCadProdBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1FormCadProd
            // 
            this.panel1FormCadProd.Controls.Add(this.dtGridViewCadProd);
            this.panel1FormCadProd.Controls.Add(this.panel3FormCadProdBotoes);
            this.panel1FormCadProd.Controls.Add(this.panelTituloCadProd);
            this.panel1FormCadProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1FormCadProd.Location = new System.Drawing.Point(0, 0);
            this.panel1FormCadProd.Name = "panel1FormCadProd";
            this.panel1FormCadProd.Size = new System.Drawing.Size(754, 561);
            this.panel1FormCadProd.TabIndex = 0;
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
            this.dtGridViewCadProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridViewCadProd.Location = new System.Drawing.Point(0, 127);
            this.dtGridViewCadProd.Name = "dtGridViewCadProd";
            this.dtGridViewCadProd.ReadOnly = true;
            this.dtGridViewCadProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewCadProd.Size = new System.Drawing.Size(754, 434);
            this.dtGridViewCadProd.TabIndex = 2;
            // 
            // lbDescricao
            // 
            this.lbDescricao.DataPropertyName = "nome_produto";
            this.lbDescricao.HeaderText = "Descrição";
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.ReadOnly = true;
            this.lbDescricao.Width = 240;
            // 
            // lbUnidade
            // 
            this.lbUnidade.DataPropertyName = "abrev_unid";
            this.lbUnidade.HeaderText = "Unidade";
            this.lbUnidade.Name = "lbUnidade";
            this.lbUnidade.ReadOnly = true;
            // 
            // lbVlrCompra
            // 
            this.lbVlrCompra.DataPropertyName = "pcocompra_produto";
            this.lbVlrCompra.HeaderText = "Vlr Compra";
            this.lbVlrCompra.Name = "lbVlrCompra";
            this.lbVlrCompra.ReadOnly = true;
            // 
            // lbVlrVenda
            // 
            this.lbVlrVenda.DataPropertyName = "pcovenda_produto";
            this.lbVlrVenda.HeaderText = "Vlr Venda";
            this.lbVlrVenda.Name = "lbVlrVenda";
            this.lbVlrVenda.ReadOnly = true;
            // 
            // lbVlrMargem
            // 
            this.lbVlrMargem.DataPropertyName = "margem_produto";
            this.lbVlrMargem.HeaderText = "Margem Lucro";
            this.lbVlrMargem.Name = "lbVlrMargem";
            this.lbVlrMargem.ReadOnly = true;
            // 
            // lbGrupo
            // 
            this.lbGrupo.DataPropertyName = "nome_grupo";
            this.lbGrupo.HeaderText = "Grupo";
            this.lbGrupo.Name = "lbGrupo";
            this.lbGrupo.ReadOnly = true;
            // 
            // lbSubGrupo
            // 
            this.lbSubGrupo.DataPropertyName = "nome_subgrupo";
            this.lbSubGrupo.HeaderText = "SubGrupo";
            this.lbSubGrupo.Name = "lbSubGrupo";
            this.lbSubGrupo.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_recno";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
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
            this.panel3FormCadProdBotoes.Size = new System.Drawing.Size(754, 61);
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
            this.BtSairCadProduto.Location = new System.Drawing.Point(696, 4);
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
            this.panelTituloCadProd.Size = new System.Drawing.Size(754, 66);
            this.panelTituloCadProd.TabIndex = 0;
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 561);
            this.Controls.Add(this.panel1FormCadProd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyHortifruti - Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FormCadastroProduto_Load);
            this.panel1FormCadProd.ResumeLayout(false);
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