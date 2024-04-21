using EasyHortifruti.Componentes;

namespace EasyHortifruti
{
    partial class FormGeralCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeralCad));
            this.panelCadGeralForm = new System.Windows.Forms.Panel();
            this.panelFormCadGeral = new System.Windows.Forms.Panel();
            this.DgViewCadGeral = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPesquisarCadGeral = new System.Windows.Forms.Panel();
            this.tbPesquisaGeral = new System.Windows.Forms.TextBox();
            this.cbTpFontePesquisa = new AltComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3FormCadGeralBotoes = new System.Windows.Forms.Panel();
            this.BtSairCadGeral = new System.Windows.Forms.Button();
            this.BtPesquisarCadGeral = new System.Windows.Forms.Button();
            this.BtImprimirCadGeral = new System.Windows.Forms.Button();
            this.BtExcluirCadGeral = new System.Windows.Forms.Button();
            this.BtEditarCadGeral = new System.Windows.Forms.Button();
            this.BtIncluirCadGeral = new System.Windows.Forms.Button();
            this.panelTituloCadGeral = new System.Windows.Forms.Panel();
            this.panelCadGeralForm.SuspendLayout();
            this.panelFormCadGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCadGeral)).BeginInit();
            this.panelPesquisarCadGeral.SuspendLayout();
            this.panel3FormCadGeralBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCadGeralForm
            // 
            this.panelCadGeralForm.Controls.Add(this.panelFormCadGeral);
            this.panelCadGeralForm.Controls.Add(this.panelPesquisarCadGeral);
            this.panelCadGeralForm.Controls.Add(this.panel3FormCadGeralBotoes);
            this.panelCadGeralForm.Controls.Add(this.panelTituloCadGeral);
            this.panelCadGeralForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadGeralForm.Location = new System.Drawing.Point(0, 0);
            this.panelCadGeralForm.Name = "panelCadGeralForm";
            this.panelCadGeralForm.Size = new System.Drawing.Size(884, 561);
            this.panelCadGeralForm.TabIndex = 0;
            // 
            // panelFormCadGeral
            // 
            this.panelFormCadGeral.Controls.Add(this.DgViewCadGeral);
            this.panelFormCadGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormCadGeral.Location = new System.Drawing.Point(0, 157);
            this.panelFormCadGeral.Name = "panelFormCadGeral";
            this.panelFormCadGeral.Size = new System.Drawing.Size(884, 404);
            this.panelFormCadGeral.TabIndex = 5;
            // 
            // DgViewCadGeral
            // 
            this.DgViewCadGeral.AllowUserToAddRows = false;
            this.DgViewCadGeral.AllowUserToDeleteRows = false;
            this.DgViewCadGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewCadGeral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.DgViewCadGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgViewCadGeral.Location = new System.Drawing.Point(0, 0);
            this.DgViewCadGeral.Name = "DgViewCadGeral";
            this.DgViewCadGeral.Size = new System.Drawing.Size(884, 404);
            this.DgViewCadGeral.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome / Fantasia";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Razão Social";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CNPJ / CPF";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "I.E. / RG.";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Endereço";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nº";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Complemento";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Bairro";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Cidade";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "UF";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Fone";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Celular";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "E-mail";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "ID";
            this.Column14.Name = "Column14";
            // 
            // panelPesquisarCadGeral
            // 
            this.panelPesquisarCadGeral.Controls.Add(this.tbPesquisaGeral);
            this.panelPesquisarCadGeral.Controls.Add(this.cbTpFontePesquisa);
            this.panelPesquisarCadGeral.Controls.Add(this.label2);
            this.panelPesquisarCadGeral.Controls.Add(this.label1);
            this.panelPesquisarCadGeral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPesquisarCadGeral.Location = new System.Drawing.Point(0, 120);
            this.panelPesquisarCadGeral.Name = "panelPesquisarCadGeral";
            this.panelPesquisarCadGeral.Size = new System.Drawing.Size(884, 37);
            this.panelPesquisarCadGeral.TabIndex = 4;
            // 
            // tbPesquisaGeral
            // 
            this.tbPesquisaGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesquisaGeral.Location = new System.Drawing.Point(71, 7);
            this.tbPesquisaGeral.Name = "tbPesquisaGeral";
            this.tbPesquisaGeral.Size = new System.Drawing.Size(298, 23);
            this.tbPesquisaGeral.TabIndex = 4;
            // 
            // cbTpFontePesquisa
            // 
            this.cbTpFontePesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTpFontePesquisa.FormattingEnabled = true;
            this.cbTpFontePesquisa.Items.AddRange(new object[] {
            "Cliente",
            "Entregador",
            "Fornecedor",
            "Funcionário",
            "Sócio"});
            this.cbTpFontePesquisa.Location = new System.Drawing.Point(476, 7);
            this.cbTpFontePesquisa.Name = "cbTpFontePesquisa";
            this.cbTpFontePesquisa.Size = new System.Drawing.Size(152, 24);
            this.cbTpFontePesquisa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Fonte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar";
            // 
            // panel3FormCadGeralBotoes
            // 
            this.panel3FormCadGeralBotoes.Controls.Add(this.BtSairCadGeral);
            this.panel3FormCadGeralBotoes.Controls.Add(this.BtPesquisarCadGeral);
            this.panel3FormCadGeralBotoes.Controls.Add(this.BtImprimirCadGeral);
            this.panel3FormCadGeralBotoes.Controls.Add(this.BtExcluirCadGeral);
            this.panel3FormCadGeralBotoes.Controls.Add(this.BtEditarCadGeral);
            this.panel3FormCadGeralBotoes.Controls.Add(this.BtIncluirCadGeral);
            this.panel3FormCadGeralBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3FormCadGeralBotoes.Location = new System.Drawing.Point(0, 59);
            this.panel3FormCadGeralBotoes.Name = "panel3FormCadGeralBotoes";
            this.panel3FormCadGeralBotoes.Size = new System.Drawing.Size(884, 61);
            this.panel3FormCadGeralBotoes.TabIndex = 2;
            // 
            // BtSairCadGeral
            // 
            this.BtSairCadGeral.BackColor = System.Drawing.Color.Transparent;
            this.BtSairCadGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtSairCadGeral.BackgroundImage")));
            this.BtSairCadGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtSairCadGeral.FlatAppearance.BorderSize = 0;
            this.BtSairCadGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSairCadGeral.Location = new System.Drawing.Point(826, 4);
            this.BtSairCadGeral.Name = "BtSairCadGeral";
            this.BtSairCadGeral.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtSairCadGeral.Size = new System.Drawing.Size(46, 52);
            this.BtSairCadGeral.TabIndex = 5;
            this.BtSairCadGeral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtSairCadGeral.UseVisualStyleBackColor = false;
            this.BtSairCadGeral.Click += new System.EventHandler(this.BtSairCadGeral_Click);
            // 
            // BtPesquisarCadGeral
            // 
            this.BtPesquisarCadGeral.BackColor = System.Drawing.Color.Transparent;
            this.BtPesquisarCadGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtPesquisarCadGeral.BackgroundImage")));
            this.BtPesquisarCadGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtPesquisarCadGeral.FlatAppearance.BorderSize = 0;
            this.BtPesquisarCadGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPesquisarCadGeral.Location = new System.Drawing.Point(168, 4);
            this.BtPesquisarCadGeral.Name = "BtPesquisarCadGeral";
            this.BtPesquisarCadGeral.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtPesquisarCadGeral.Size = new System.Drawing.Size(46, 52);
            this.BtPesquisarCadGeral.TabIndex = 4;
            this.BtPesquisarCadGeral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtPesquisarCadGeral.UseVisualStyleBackColor = false;
            // 
            // BtImprimirCadGeral
            // 
            this.BtImprimirCadGeral.BackColor = System.Drawing.Color.Transparent;
            this.BtImprimirCadGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtImprimirCadGeral.BackgroundImage")));
            this.BtImprimirCadGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtImprimirCadGeral.FlatAppearance.BorderSize = 0;
            this.BtImprimirCadGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtImprimirCadGeral.Location = new System.Drawing.Point(220, 4);
            this.BtImprimirCadGeral.Name = "BtImprimirCadGeral";
            this.BtImprimirCadGeral.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtImprimirCadGeral.Size = new System.Drawing.Size(46, 52);
            this.BtImprimirCadGeral.TabIndex = 3;
            this.BtImprimirCadGeral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtImprimirCadGeral.UseVisualStyleBackColor = false;
            // 
            // BtExcluirCadGeral
            // 
            this.BtExcluirCadGeral.BackColor = System.Drawing.Color.Transparent;
            this.BtExcluirCadGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtExcluirCadGeral.BackgroundImage")));
            this.BtExcluirCadGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtExcluirCadGeral.FlatAppearance.BorderSize = 0;
            this.BtExcluirCadGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExcluirCadGeral.Location = new System.Drawing.Point(116, 3);
            this.BtExcluirCadGeral.Name = "BtExcluirCadGeral";
            this.BtExcluirCadGeral.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtExcluirCadGeral.Size = new System.Drawing.Size(46, 52);
            this.BtExcluirCadGeral.TabIndex = 2;
            this.BtExcluirCadGeral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtExcluirCadGeral.UseVisualStyleBackColor = false;
            this.BtExcluirCadGeral.Click += new System.EventHandler(this.BtExcluirCadGeral_Click);
            // 
            // BtEditarCadGeral
            // 
            this.BtEditarCadGeral.BackColor = System.Drawing.Color.Transparent;
            this.BtEditarCadGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtEditarCadGeral.BackgroundImage")));
            this.BtEditarCadGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEditarCadGeral.FlatAppearance.BorderSize = 0;
            this.BtEditarCadGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEditarCadGeral.Location = new System.Drawing.Point(64, 3);
            this.BtEditarCadGeral.Name = "BtEditarCadGeral";
            this.BtEditarCadGeral.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtEditarCadGeral.Size = new System.Drawing.Size(46, 52);
            this.BtEditarCadGeral.TabIndex = 1;
            this.BtEditarCadGeral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEditarCadGeral.UseVisualStyleBackColor = false;
            this.BtEditarCadGeral.Click += new System.EventHandler(this.BtEditarCadGeral_Click);
            // 
            // BtIncluirCadGeral
            // 
            this.BtIncluirCadGeral.BackColor = System.Drawing.Color.Transparent;
            this.BtIncluirCadGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtIncluirCadGeral.BackgroundImage")));
            this.BtIncluirCadGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtIncluirCadGeral.FlatAppearance.BorderSize = 0;
            this.BtIncluirCadGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtIncluirCadGeral.Location = new System.Drawing.Point(12, 3);
            this.BtIncluirCadGeral.Name = "BtIncluirCadGeral";
            this.BtIncluirCadGeral.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtIncluirCadGeral.Size = new System.Drawing.Size(46, 52);
            this.BtIncluirCadGeral.TabIndex = 0;
            this.BtIncluirCadGeral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtIncluirCadGeral.UseVisualStyleBackColor = false;
            this.BtIncluirCadGeral.Click += new System.EventHandler(this.BtIncluirCliente_Click);
            // 
            // panelTituloCadGeral
            // 
            this.panelTituloCadGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTituloCadGeral.BackgroundImage")));
            this.panelTituloCadGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTituloCadGeral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloCadGeral.Location = new System.Drawing.Point(0, 0);
            this.panelTituloCadGeral.Name = "panelTituloCadGeral";
            this.panelTituloCadGeral.Size = new System.Drawing.Size(884, 59);
            this.panelTituloCadGeral.TabIndex = 0;
            // 
            // FormCadGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelCadGeralForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyHortifruti - Cadastro de Clientes, Fornecedores, Funcionarios";
            this.Load += new System.EventHandler(this.FormCadGeral_Load);
            this.panelCadGeralForm.ResumeLayout(false);
            this.panelFormCadGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCadGeral)).EndInit();
            this.panelPesquisarCadGeral.ResumeLayout(false);
            this.panelPesquisarCadGeral.PerformLayout();
            this.panel3FormCadGeralBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCadGeralForm;
        private System.Windows.Forms.Panel panelTituloCadGeral;
        private System.Windows.Forms.Panel panel3FormCadGeralBotoes;
        private System.Windows.Forms.Button BtSairCadGeral;
        private System.Windows.Forms.Button BtPesquisarCadGeral;
        private System.Windows.Forms.Button BtImprimirCadGeral;
        private System.Windows.Forms.Button BtExcluirCadGeral;
        private System.Windows.Forms.Button BtEditarCadGeral;
        private System.Windows.Forms.Button BtIncluirCadGeral;
        private System.Windows.Forms.Panel panelPesquisarCadGeral;
        private System.Windows.Forms.Panel panelFormCadGeral;
        private System.Windows.Forms.DataGridView DgViewCadGeral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private AltComboBox cbTpFontePesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPesquisaGeral;
    }
}