namespace EasyHortifruti.Forms.Financeiro
{
    partial class FormCtasPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCtasPagar));
            this.PanelTopTítulo = new System.Windows.Forms.Panel();
            this.panel3CtasReceberFiltros = new System.Windows.Forms.Panel();
            this.CbFiltroCtasPagar = new EasyHortifruti.Componentes.AltComboBox();
            this.CbFiltroSituação = new EasyHortifruti.Componentes.AltComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DataInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5CtasReceberBotoes = new System.Windows.Forms.Panel();
            this.BtBaixaCtaRecebto = new System.Windows.Forms.Button();
            this.BtImprimirCtaRecebto = new System.Windows.Forms.Button();
            this.BtExcluirCtaRecebto = new System.Windows.Forms.Button();
            this.BtEditarCtaRecebto = new System.Windows.Forms.Button();
            this.BtIncluirCtaRecebto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3CtasReceberFiltros.SuspendLayout();
            this.panel5CtasReceberBotoes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTopTítulo
            // 
            this.PanelTopTítulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelTopTítulo.BackgroundImage")));
            this.PanelTopTítulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelTopTítulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopTítulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTopTítulo.Name = "PanelTopTítulo";
            this.PanelTopTítulo.Size = new System.Drawing.Size(815, 69);
            this.PanelTopTítulo.TabIndex = 0;
            // 
            // panel3CtasReceberFiltros
            // 
            this.panel3CtasReceberFiltros.Controls.Add(this.CbFiltroCtasPagar);
            this.panel3CtasReceberFiltros.Controls.Add(this.CbFiltroSituação);
            this.panel3CtasReceberFiltros.Controls.Add(this.label4);
            this.panel3CtasReceberFiltros.Controls.Add(this.DateFinal);
            this.panel3CtasReceberFiltros.Controls.Add(this.label3);
            this.panel3CtasReceberFiltros.Controls.Add(this.DataInicio);
            this.panel3CtasReceberFiltros.Controls.Add(this.label1);
            this.panel3CtasReceberFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3CtasReceberFiltros.Location = new System.Drawing.Point(0, 69);
            this.panel3CtasReceberFiltros.Name = "panel3CtasReceberFiltros";
            this.panel3CtasReceberFiltros.Size = new System.Drawing.Size(815, 69);
            this.panel3CtasReceberFiltros.TabIndex = 2;
            // 
            // CbFiltroCtasPagar
            // 
            this.CbFiltroCtasPagar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CbFiltroCtasPagar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CbFiltroCtasPagar.Caption = "Cliente";
            this.CbFiltroCtasPagar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbFiltroCtasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CbFiltroCtasPagar.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.CbFiltroCtasPagar.FormattingEnabled = true;
            this.CbFiltroCtasPagar.Location = new System.Drawing.Point(7, 17);
            this.CbFiltroCtasPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbFiltroCtasPagar.Name = "CbFiltroCtasPagar";
            this.CbFiltroCtasPagar.Obrigatorio = false;
            this.CbFiltroCtasPagar.SelectedIndex = -1;
            this.CbFiltroCtasPagar.SelectedItem = null;
            this.CbFiltroCtasPagar.SelectedText = "";
            this.CbFiltroCtasPagar.Size = new System.Drawing.Size(230, 42);
            this.CbFiltroCtasPagar.TabIndex = 2;
            // 
            // CbFiltroSituação
            // 
            this.CbFiltroSituação.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CbFiltroSituação.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CbFiltroSituação.Caption = "Situação";
            this.CbFiltroSituação.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbFiltroSituação.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CbFiltroSituação.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.CbFiltroSituação.FormattingEnabled = true;
            this.CbFiltroSituação.Location = new System.Drawing.Point(513, 16);
            this.CbFiltroSituação.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbFiltroSituação.Name = "CbFiltroSituação";
            this.CbFiltroSituação.Obrigatorio = false;
            this.CbFiltroSituação.SelectedIndex = -1;
            this.CbFiltroSituação.SelectedItem = null;
            this.CbFiltroSituação.SelectedText = "";
            this.CbFiltroSituação.Size = new System.Drawing.Size(181, 42);
            this.CbFiltroSituação.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Final";
            // 
            // DateFinal
            // 
            this.DateFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFinal.Location = new System.Drawing.Point(384, 34);
            this.DateFinal.Name = "DateFinal";
            this.DateFinal.Size = new System.Drawing.Size(110, 24);
            this.DateFinal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Início";
            // 
            // DataInicio
            // 
            this.DataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataInicio.Location = new System.Drawing.Point(256, 34);
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Size = new System.Drawing.Size(111, 24);
            this.DataInicio.TabIndex = 3;
            this.DataInicio.Value = new System.DateTime(2024, 3, 21, 10, 44, 8, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro";
            // 
            // panel5CtasReceberBotoes
            // 
            this.panel5CtasReceberBotoes.Controls.Add(this.BtBaixaCtaRecebto);
            this.panel5CtasReceberBotoes.Controls.Add(this.BtImprimirCtaRecebto);
            this.panel5CtasReceberBotoes.Controls.Add(this.BtExcluirCtaRecebto);
            this.panel5CtasReceberBotoes.Controls.Add(this.BtEditarCtaRecebto);
            this.panel5CtasReceberBotoes.Controls.Add(this.BtIncluirCtaRecebto);
            this.panel5CtasReceberBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5CtasReceberBotoes.Location = new System.Drawing.Point(0, 138);
            this.panel5CtasReceberBotoes.Name = "panel5CtasReceberBotoes";
            this.panel5CtasReceberBotoes.Size = new System.Drawing.Size(815, 61);
            this.panel5CtasReceberBotoes.TabIndex = 4;
            // 
            // BtBaixaCtaRecebto
            // 
            this.BtBaixaCtaRecebto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtBaixaCtaRecebto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtBaixaCtaRecebto.BackgroundImage")));
            this.BtBaixaCtaRecebto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtBaixaCtaRecebto.FlatAppearance.BorderSize = 0;
            this.BtBaixaCtaRecebto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBaixaCtaRecebto.Location = new System.Drawing.Point(174, 6);
            this.BtBaixaCtaRecebto.Name = "BtBaixaCtaRecebto";
            this.BtBaixaCtaRecebto.Size = new System.Drawing.Size(56, 49);
            this.BtBaixaCtaRecebto.TabIndex = 5;
            this.BtBaixaCtaRecebto.UseVisualStyleBackColor = true;
            this.BtBaixaCtaRecebto.Click += new System.EventHandler(this.BtBaixaCtaRecebto_Click);
            // 
            // BtImprimirCtaRecebto
            // 
            this.BtImprimirCtaRecebto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtImprimirCtaRecebto.BackColor = System.Drawing.Color.Transparent;
            this.BtImprimirCtaRecebto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtImprimirCtaRecebto.BackgroundImage")));
            this.BtImprimirCtaRecebto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtImprimirCtaRecebto.FlatAppearance.BorderSize = 0;
            this.BtImprimirCtaRecebto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtImprimirCtaRecebto.Location = new System.Drawing.Point(236, 3);
            this.BtImprimirCtaRecebto.Name = "BtImprimirCtaRecebto";
            this.BtImprimirCtaRecebto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtImprimirCtaRecebto.Size = new System.Drawing.Size(47, 52);
            this.BtImprimirCtaRecebto.TabIndex = 3;
            this.BtImprimirCtaRecebto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtImprimirCtaRecebto.UseVisualStyleBackColor = false;
            // 
            // BtExcluirCtaRecebto
            // 
            this.BtExcluirCtaRecebto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtExcluirCtaRecebto.BackColor = System.Drawing.Color.Transparent;
            this.BtExcluirCtaRecebto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtExcluirCtaRecebto.BackgroundImage")));
            this.BtExcluirCtaRecebto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtExcluirCtaRecebto.FlatAppearance.BorderSize = 0;
            this.BtExcluirCtaRecebto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExcluirCtaRecebto.Location = new System.Drawing.Point(121, 3);
            this.BtExcluirCtaRecebto.Name = "BtExcluirCtaRecebto";
            this.BtExcluirCtaRecebto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtExcluirCtaRecebto.Size = new System.Drawing.Size(47, 52);
            this.BtExcluirCtaRecebto.TabIndex = 2;
            this.BtExcluirCtaRecebto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtExcluirCtaRecebto.UseVisualStyleBackColor = false;
            // 
            // BtEditarCtaRecebto
            // 
            this.BtEditarCtaRecebto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtEditarCtaRecebto.BackColor = System.Drawing.Color.Transparent;
            this.BtEditarCtaRecebto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtEditarCtaRecebto.BackgroundImage")));
            this.BtEditarCtaRecebto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEditarCtaRecebto.FlatAppearance.BorderSize = 0;
            this.BtEditarCtaRecebto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEditarCtaRecebto.Location = new System.Drawing.Point(66, 3);
            this.BtEditarCtaRecebto.Name = "BtEditarCtaRecebto";
            this.BtEditarCtaRecebto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtEditarCtaRecebto.Size = new System.Drawing.Size(47, 52);
            this.BtEditarCtaRecebto.TabIndex = 1;
            this.BtEditarCtaRecebto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEditarCtaRecebto.UseVisualStyleBackColor = false;
            // 
            // BtIncluirCtaRecebto
            // 
            this.BtIncluirCtaRecebto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtIncluirCtaRecebto.BackColor = System.Drawing.Color.Transparent;
            this.BtIncluirCtaRecebto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtIncluirCtaRecebto.BackgroundImage")));
            this.BtIncluirCtaRecebto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtIncluirCtaRecebto.FlatAppearance.BorderSize = 0;
            this.BtIncluirCtaRecebto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtIncluirCtaRecebto.Location = new System.Drawing.Point(8, 3);
            this.BtIncluirCtaRecebto.Name = "BtIncluirCtaRecebto";
            this.BtIncluirCtaRecebto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtIncluirCtaRecebto.Size = new System.Drawing.Size(50, 52);
            this.BtIncluirCtaRecebto.TabIndex = 0;
            this.BtIncluirCtaRecebto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtIncluirCtaRecebto.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 411);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 411);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(148, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 411);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormCtasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5CtasReceberBotoes);
            this.Controls.Add(this.panel3CtasReceberFiltros);
            this.Controls.Add(this.PanelTopTítulo);
            this.Name = "FormCtasPagar";
            this.Text = "Form1";
            this.panel3CtasReceberFiltros.ResumeLayout(false);
            this.panel3CtasReceberFiltros.PerformLayout();
            this.panel5CtasReceberBotoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopTítulo;
        private System.Windows.Forms.Panel panel3CtasReceberFiltros;
        private Componentes.AltComboBox CbFiltroCtasPagar;
        private Componentes.AltComboBox CbFiltroSituação;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DataInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5CtasReceberBotoes;
        private System.Windows.Forms.Button BtBaixaCtaRecebto;
        private System.Windows.Forms.Button BtImprimirCtaRecebto;
        private System.Windows.Forms.Button BtExcluirCtaRecebto;
        private System.Windows.Forms.Button BtEditarCtaRecebto;
        private System.Windows.Forms.Button BtIncluirCtaRecebto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
    }
}