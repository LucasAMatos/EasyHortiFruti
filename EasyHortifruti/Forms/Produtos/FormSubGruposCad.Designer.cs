namespace EasyHortifruti
{
    partial class FormSubGruposCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSubGruposCad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DgViewCadSubGrupos = new System.Windows.Forms.DataGridView();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margemlucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbFiltro = new EasyHortifruti.Componentes.AltComboBox();
            this.tbFiltro = new EasyHortifruti.Componentes.AltTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtSairSubGrupo = new System.Windows.Forms.Button();
            this.BtImprimirSubGrupo = new System.Windows.Forms.Button();
            this.BtExcluirSubGrupo = new System.Windows.Forms.Button();
            this.BtEditarSubGrupo = new System.Windows.Forms.Button();
            this.BtIncluirSubGrupo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCadSubGrupos)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 495);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DgViewCadSubGrupos);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 169);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(477, 326);
            this.panel6.TabIndex = 8;
            // 
            // DgViewCadSubGrupos
            // 
            this.DgViewCadSubGrupos.AllowUserToAddRows = false;
            this.DgViewCadSubGrupos.AllowUserToDeleteRows = false;
            this.DgViewCadSubGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewCadSubGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.Grupo,
            this.margemlucro,
            this.ID});
            this.DgViewCadSubGrupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgViewCadSubGrupos.Location = new System.Drawing.Point(0, 0);
            this.DgViewCadSubGrupos.MultiSelect = false;
            this.DgViewCadSubGrupos.Name = "DgViewCadSubGrupos";
            this.DgViewCadSubGrupos.ReadOnly = true;
            this.DgViewCadSubGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgViewCadSubGrupos.Size = new System.Drawing.Size(477, 326);
            this.DgViewCadSubGrupos.TabIndex = 3;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "nome_subgrupo";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 120;
            // 
            // Grupo
            // 
            this.Grupo.DataPropertyName = "nome_grupo";
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            this.Grupo.ReadOnly = true;
            this.Grupo.Width = 120;
            // 
            // margemlucro
            // 
            this.margemlucro.DataPropertyName = "margem_subgrupo";
            this.margemlucro.HeaderText = "Margem Lucro";
            this.margemlucro.Name = "margemlucro";
            this.margemlucro.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_recno";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 121);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(477, 48);
            this.panel5.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.15789F));
            this.tableLayoutPanel2.Controls.Add(this.cbFiltro, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbFiltro, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(477, 48);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // cbFiltro
            // 
            this.cbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cbFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cbFiltro.Caption = "Campo para Filtrar";
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbFiltro.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(15, 1);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(15, 1, 7, 5);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Obrigatorio = false;
            this.cbFiltro.SelectedIndex = -1;
            this.cbFiltro.SelectedItem = null;
            this.cbFiltro.SelectedText = "";
            this.cbFiltro.Size = new System.Drawing.Size(137, 42);
            this.cbFiltro.TabIndex = 0;
            // 
            // tbFiltro
            // 
            this.tbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiltro.Caption = "Digite para Filtrar";
            this.tbFiltro.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbFiltro.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.Location = new System.Drawing.Point(183, 1);
            this.tbFiltro.Margin = new System.Windows.Forms.Padding(8, 1, 15, 5);
            this.tbFiltro.MaxLength = 32767;
            this.tbFiltro.Multiline = true;
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Obrigatorio = false;
            this.tbFiltro.ReadOnly = false;
            this.tbFiltro.SelectionLength = 0;
            this.tbFiltro.SelectionStart = 0;
            this.tbFiltro.Size = new System.Drawing.Size(279, 42);
            this.tbFiltro.TabIndex = 1;
            this.tbFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFiltro.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtSairSubGrupo);
            this.panel3.Controls.Add(this.BtImprimirSubGrupo);
            this.panel3.Controls.Add(this.BtExcluirSubGrupo);
            this.panel3.Controls.Add(this.BtEditarSubGrupo);
            this.panel3.Controls.Add(this.BtIncluirSubGrupo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 66);
            this.panel3.TabIndex = 1;
            // 
            // BtSairSubGrupo
            // 
            this.BtSairSubGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSairSubGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtSairSubGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtSairSubGrupo.BackgroundImage")));
            this.BtSairSubGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtSairSubGrupo.FlatAppearance.BorderSize = 0;
            this.BtSairSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSairSubGrupo.Location = new System.Drawing.Point(422, 7);
            this.BtSairSubGrupo.Name = "BtSairSubGrupo";
            this.BtSairSubGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtSairSubGrupo.Size = new System.Drawing.Size(44, 52);
            this.BtSairSubGrupo.TabIndex = 21;
            this.BtSairSubGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtSairSubGrupo.UseVisualStyleBackColor = false;
            this.BtSairSubGrupo.Click += new System.EventHandler(this.BtSairSubGrupo_Click);
            // 
            // BtImprimirSubGrupo
            // 
            this.BtImprimirSubGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtImprimirSubGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtImprimirSubGrupo.BackgroundImage")));
            this.BtImprimirSubGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtImprimirSubGrupo.FlatAppearance.BorderSize = 0;
            this.BtImprimirSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtImprimirSubGrupo.Location = new System.Drawing.Point(168, 8);
            this.BtImprimirSubGrupo.Name = "BtImprimirSubGrupo";
            this.BtImprimirSubGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtImprimirSubGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtImprimirSubGrupo.TabIndex = 19;
            this.BtImprimirSubGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtImprimirSubGrupo.UseVisualStyleBackColor = false;
            // 
            // BtExcluirSubGrupo
            // 
            this.BtExcluirSubGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtExcluirSubGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtExcluirSubGrupo.BackgroundImage")));
            this.BtExcluirSubGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtExcluirSubGrupo.FlatAppearance.BorderSize = 0;
            this.BtExcluirSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExcluirSubGrupo.Location = new System.Drawing.Point(110, 7);
            this.BtExcluirSubGrupo.Name = "BtExcluirSubGrupo";
            this.BtExcluirSubGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtExcluirSubGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtExcluirSubGrupo.TabIndex = 18;
            this.BtExcluirSubGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtExcluirSubGrupo.UseVisualStyleBackColor = false;
            this.BtExcluirSubGrupo.Click += new System.EventHandler(this.BtExcluirSubGrupo_Click);
            // 
            // BtEditarSubGrupo
            // 
            this.BtEditarSubGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtEditarSubGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtEditarSubGrupo.BackgroundImage")));
            this.BtEditarSubGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEditarSubGrupo.FlatAppearance.BorderSize = 0;
            this.BtEditarSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEditarSubGrupo.Location = new System.Drawing.Point(58, 7);
            this.BtEditarSubGrupo.Name = "BtEditarSubGrupo";
            this.BtEditarSubGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtEditarSubGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtEditarSubGrupo.TabIndex = 17;
            this.BtEditarSubGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEditarSubGrupo.UseVisualStyleBackColor = false;
            this.BtEditarSubGrupo.Click += new System.EventHandler(this.BtEditarSubGrupo_Click);
            // 
            // BtIncluirSubGrupo
            // 
            this.BtIncluirSubGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtIncluirSubGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtIncluirSubGrupo.BackgroundImage")));
            this.BtIncluirSubGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtIncluirSubGrupo.FlatAppearance.BorderSize = 0;
            this.BtIncluirSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtIncluirSubGrupo.Location = new System.Drawing.Point(6, 7);
            this.BtIncluirSubGrupo.Name = "BtIncluirSubGrupo";
            this.BtIncluirSubGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtIncluirSubGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtIncluirSubGrupo.TabIndex = 16;
            this.BtIncluirSubGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtIncluirSubGrupo.UseVisualStyleBackColor = false;
            this.BtIncluirSubGrupo.Click += new System.EventHandler(this.BtIncluirSubGrupo_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 55);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de SubGrupos";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(72, 55);
            this.panel4.TabIndex = 0;
            // 
            // FormSubGruposCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 495);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSubGruposCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Hortifruti";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCadSubGrupos)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtSairSubGrupo;
        private System.Windows.Forms.Button BtImprimirSubGrupo;
        private System.Windows.Forms.Button BtExcluirSubGrupo;
        private System.Windows.Forms.Button BtEditarSubGrupo;
        private System.Windows.Forms.Button BtIncluirSubGrupo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView DgViewCadSubGrupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn margemlucro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Componentes.AltComboBox cbFiltro;
        private Componentes.AltTextBox tbFiltro;
    }
}