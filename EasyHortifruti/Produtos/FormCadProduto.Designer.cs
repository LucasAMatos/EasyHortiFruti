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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3FormCadProdBotoes = new System.Windows.Forms.Panel();
            this.btSairCadProduto = new System.Windows.Forms.Button();
            this.btPesquisarProduto = new System.Windows.Forms.Button();
            this.btImprimirProduto = new System.Windows.Forms.Button();
            this.btExcluirProduto = new System.Windows.Forms.Button();
            this.btEditarProduto = new System.Windows.Forms.Button();
            this.btIncluirProduto = new System.Windows.Forms.Button();
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
            this.dtGridViewCadProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGridViewCadProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewCadProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtGridViewCadProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridViewCadProd.Location = new System.Drawing.Point(0, 127);
            this.dtGridViewCadProd.Name = "dtGridViewCadProd";
            this.dtGridViewCadProd.Size = new System.Drawing.Size(754, 434);
            this.dtGridViewCadProd.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descrição";
            this.Column1.Name = "Column1";
            this.Column1.Width = 240;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unidade";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Vlr Compra";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Vlr Venda";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Margem Lucro";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Grupo";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "SubGrupo";
            this.Column7.Name = "Column7";
            // 
            // panel3FormCadProdBotoes
            // 
            this.panel3FormCadProdBotoes.Controls.Add(this.btSairCadProduto);
            this.panel3FormCadProdBotoes.Controls.Add(this.btPesquisarProduto);
            this.panel3FormCadProdBotoes.Controls.Add(this.btImprimirProduto);
            this.panel3FormCadProdBotoes.Controls.Add(this.btExcluirProduto);
            this.panel3FormCadProdBotoes.Controls.Add(this.btEditarProduto);
            this.panel3FormCadProdBotoes.Controls.Add(this.btIncluirProduto);
            this.panel3FormCadProdBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3FormCadProdBotoes.Location = new System.Drawing.Point(0, 66);
            this.panel3FormCadProdBotoes.Name = "panel3FormCadProdBotoes";
            this.panel3FormCadProdBotoes.Size = new System.Drawing.Size(754, 61);
            this.panel3FormCadProdBotoes.TabIndex = 1;
            // 
            // btSairCadProduto
            // 
            this.btSairCadProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSairCadProduto.BackColor = System.Drawing.Color.Transparent;
            this.btSairCadProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSairCadProduto.BackgroundImage")));
            this.btSairCadProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSairCadProduto.FlatAppearance.BorderSize = 0;
            this.btSairCadProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSairCadProduto.Location = new System.Drawing.Point(696, 4);
            this.btSairCadProduto.Name = "btSairCadProduto";
            this.btSairCadProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btSairCadProduto.Size = new System.Drawing.Size(46, 52);
            this.btSairCadProduto.TabIndex = 5;
            this.btSairCadProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSairCadProduto.UseVisualStyleBackColor = false;
            this.btSairCadProduto.Click += new System.EventHandler(this.btSairCadProduto_Click);
            // 
            // btPesquisarProduto
            // 
            this.btPesquisarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btPesquisarProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPesquisarProduto.BackgroundImage")));
            this.btPesquisarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesquisarProduto.FlatAppearance.BorderSize = 0;
            this.btPesquisarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisarProduto.Location = new System.Drawing.Point(168, 4);
            this.btPesquisarProduto.Name = "btPesquisarProduto";
            this.btPesquisarProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btPesquisarProduto.Size = new System.Drawing.Size(46, 52);
            this.btPesquisarProduto.TabIndex = 4;
            this.btPesquisarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPesquisarProduto.UseVisualStyleBackColor = false;
            // 
            // btImprimirProduto
            // 
            this.btImprimirProduto.BackColor = System.Drawing.Color.Transparent;
            this.btImprimirProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btImprimirProduto.BackgroundImage")));
            this.btImprimirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btImprimirProduto.FlatAppearance.BorderSize = 0;
            this.btImprimirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImprimirProduto.Location = new System.Drawing.Point(220, 4);
            this.btImprimirProduto.Name = "btImprimirProduto";
            this.btImprimirProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btImprimirProduto.Size = new System.Drawing.Size(46, 52);
            this.btImprimirProduto.TabIndex = 3;
            this.btImprimirProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btImprimirProduto.UseVisualStyleBackColor = false;
            this.btImprimirProduto.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btExcluirProduto
            // 
            this.btExcluirProduto.BackColor = System.Drawing.Color.Transparent;
            this.btExcluirProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExcluirProduto.BackgroundImage")));
            this.btExcluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExcluirProduto.FlatAppearance.BorderSize = 0;
            this.btExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluirProduto.Location = new System.Drawing.Point(116, 3);
            this.btExcluirProduto.Name = "btExcluirProduto";
            this.btExcluirProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btExcluirProduto.Size = new System.Drawing.Size(46, 52);
            this.btExcluirProduto.TabIndex = 2;
            this.btExcluirProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluirProduto.UseVisualStyleBackColor = false;
            // 
            // btEditarProduto
            // 
            this.btEditarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btEditarProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEditarProduto.BackgroundImage")));
            this.btEditarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEditarProduto.FlatAppearance.BorderSize = 0;
            this.btEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarProduto.Location = new System.Drawing.Point(64, 3);
            this.btEditarProduto.Name = "btEditarProduto";
            this.btEditarProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btEditarProduto.Size = new System.Drawing.Size(46, 52);
            this.btEditarProduto.TabIndex = 1;
            this.btEditarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEditarProduto.UseVisualStyleBackColor = false;
            // 
            // btIncluirProduto
            // 
            this.btIncluirProduto.BackColor = System.Drawing.Color.Transparent;
            this.btIncluirProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btIncluirProduto.BackgroundImage")));
            this.btIncluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btIncluirProduto.FlatAppearance.BorderSize = 0;
            this.btIncluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIncluirProduto.Location = new System.Drawing.Point(12, 3);
            this.btIncluirProduto.Name = "btIncluirProduto";
            this.btIncluirProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btIncluirProduto.Size = new System.Drawing.Size(46, 52);
            this.btIncluirProduto.TabIndex = 0;
            this.btIncluirProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btIncluirProduto.UseVisualStyleBackColor = false;
            this.btIncluirProduto.Click += new System.EventHandler(this.btIncluirProduto_Click);
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
            this.panel1FormCadProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewCadProd)).EndInit();
            this.panel3FormCadProdBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1FormCadProd;
        private System.Windows.Forms.Panel panelTituloCadProd;
        private System.Windows.Forms.Panel panel3FormCadProdBotoes;
        private System.Windows.Forms.Button btIncluirProduto;
        private System.Windows.Forms.Button btEditarProduto;
        private System.Windows.Forms.Button btExcluirProduto;
        private System.Windows.Forms.Button btImprimirProduto;
        private System.Windows.Forms.Button btPesquisarProduto;
        private System.Windows.Forms.Button btSairCadProduto;
        private System.Windows.Forms.DataGridView dtGridViewCadProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}