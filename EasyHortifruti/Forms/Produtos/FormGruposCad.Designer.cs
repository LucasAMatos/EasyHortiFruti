namespace EasyHortifruti
{
    partial class FormGruposCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGruposCad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgViewCadGrupos = new System.Windows.Forms.DataGridView();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Margem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbFiltro = new EasyHortifruti.Componentes.AltComboBox();
            this.tbFiltro = new EasyHortifruti.Componentes.AltTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtSairGrupo = new System.Windows.Forms.Button();
            this.BtImprimirGrupo = new System.Windows.Forms.Button();
            this.BtExcluirGrupo = new System.Windows.Forms.Button();
            this.BtEditarGrupo = new System.Windows.Forms.Button();
            this.BtIncluirGrupo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCadGrupos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgViewCadGrupos);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 495);
            this.panel1.TabIndex = 0;
            // 
            // DgViewCadGrupos
            // 
            this.DgViewCadGrupos.AllowUserToAddRows = false;
            this.DgViewCadGrupos.AllowUserToDeleteRows = false;
            this.DgViewCadGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewCadGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.observacao,
            this.Margem,
            this.id});
            this.DgViewCadGrupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgViewCadGrupos.Location = new System.Drawing.Point(0, 165);
            this.DgViewCadGrupos.MultiSelect = false;
            this.DgViewCadGrupos.Name = "DgViewCadGrupos";
            this.DgViewCadGrupos.ReadOnly = true;
            this.DgViewCadGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgViewCadGrupos.Size = new System.Drawing.Size(481, 330);
            this.DgViewCadGrupos.TabIndex = 0;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "nome_grupo";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 120;
            // 
            // observacao
            // 
            this.observacao.DataPropertyName = "obs_grupo";
            this.observacao.HeaderText = "Observação";
            this.observacao.Name = "observacao";
            this.observacao.ReadOnly = true;
            this.observacao.Width = 220;
            // 
            // Margem
            // 
            this.Margem.DataPropertyName = "margem_grupo";
            this.Margem.HeaderText = "Margem Lucro";
            this.Margem.Name = "Margem";
            this.Margem.ReadOnly = true;
            this.Margem.Width = 110;
            // 
            // id
            // 
            this.id.DataPropertyName = "id_recno";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 50;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.cbFiltro, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbFiltro, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 121);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(481, 44);
            this.tableLayoutPanel2.TabIndex = 6;
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
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Obrigatorio = false;
            this.cbFiltro.SelectedIndex = -1;
            this.cbFiltro.SelectedText = "";
            this.cbFiltro.Size = new System.Drawing.Size(138, 38);
            this.cbFiltro.TabIndex = 0;
            // 
            // tbFiltro
            // 
            this.tbFiltro.Caption = "Digite para Filtrar";
            this.tbFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFiltro.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbFiltro.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.Location = new System.Drawing.Point(147, 3);
            this.tbFiltro.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tbFiltro.MaxLength = 32767;
            this.tbFiltro.Multiline = true;
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Obrigatorio = false;
            this.tbFiltro.ReadOnly = false;
            this.tbFiltro.SelectionLength = 0;
            this.tbFiltro.SelectionStart = 0;
            this.tbFiltro.Size = new System.Drawing.Size(331, 35);
            this.tbFiltro.TabIndex = 1;
            this.tbFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFiltro.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtSairGrupo);
            this.panel3.Controls.Add(this.BtImprimirGrupo);
            this.panel3.Controls.Add(this.BtExcluirGrupo);
            this.panel3.Controls.Add(this.BtEditarGrupo);
            this.panel3.Controls.Add(this.BtIncluirGrupo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 64);
            this.panel3.TabIndex = 1;
            // 
            // BtSairGrupo
            // 
            this.BtSairGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSairGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtSairGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtSairGrupo.BackgroundImage")));
            this.BtSairGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtSairGrupo.FlatAppearance.BorderSize = 0;
            this.BtSairGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSairGrupo.Location = new System.Drawing.Point(418, 6);
            this.BtSairGrupo.Name = "BtSairGrupo";
            this.BtSairGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtSairGrupo.Size = new System.Drawing.Size(44, 52);
            this.BtSairGrupo.TabIndex = 15;
            this.BtSairGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtSairGrupo.UseVisualStyleBackColor = false;
            this.BtSairGrupo.Click += new System.EventHandler(this.BtSairGrupo_Click);
            // 
            // BtImprimirGrupo
            // 
            this.BtImprimirGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtImprimirGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtImprimirGrupo.BackgroundImage")));
            this.BtImprimirGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtImprimirGrupo.FlatAppearance.BorderSize = 0;
            this.BtImprimirGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtImprimirGrupo.Location = new System.Drawing.Point(177, 7);
            this.BtImprimirGrupo.Name = "BtImprimirGrupo";
            this.BtImprimirGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtImprimirGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtImprimirGrupo.TabIndex = 13;
            this.BtImprimirGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtImprimirGrupo.UseVisualStyleBackColor = false;
            // 
            // BtExcluirGrupo
            // 
            this.BtExcluirGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtExcluirGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtExcluirGrupo.BackgroundImage")));
            this.BtExcluirGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtExcluirGrupo.FlatAppearance.BorderSize = 0;
            this.BtExcluirGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExcluirGrupo.Location = new System.Drawing.Point(119, 6);
            this.BtExcluirGrupo.Name = "BtExcluirGrupo";
            this.BtExcluirGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtExcluirGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtExcluirGrupo.TabIndex = 12;
            this.BtExcluirGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtExcluirGrupo.UseVisualStyleBackColor = false;
            this.BtExcluirGrupo.Click += new System.EventHandler(this.BtExcluirGrupo_Click);
            // 
            // BtEditarGrupo
            // 
            this.BtEditarGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtEditarGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtEditarGrupo.BackgroundImage")));
            this.BtEditarGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEditarGrupo.FlatAppearance.BorderSize = 0;
            this.BtEditarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEditarGrupo.Location = new System.Drawing.Point(67, 6);
            this.BtEditarGrupo.Name = "BtEditarGrupo";
            this.BtEditarGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtEditarGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtEditarGrupo.TabIndex = 11;
            this.BtEditarGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEditarGrupo.UseVisualStyleBackColor = false;
            this.BtEditarGrupo.Click += new System.EventHandler(this.BtEditarGrupo_Click);
            // 
            // BtIncluirGrupo
            // 
            this.BtIncluirGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtIncluirGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtIncluirGrupo.BackgroundImage")));
            this.BtIncluirGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtIncluirGrupo.FlatAppearance.BorderSize = 0;
            this.BtIncluirGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtIncluirGrupo.Location = new System.Drawing.Point(15, 6);
            this.BtIncluirGrupo.Name = "BtIncluirGrupo";
            this.BtIncluirGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtIncluirGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtIncluirGrupo.TabIndex = 10;
            this.BtIncluirGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtIncluirGrupo.UseVisualStyleBackColor = false;
            this.BtIncluirGrupo.Click += new System.EventHandler(this.BtIncluirGrupo_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 57);
            this.panel2.TabIndex = 0;
            // 
            // FormGruposCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 497);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGruposCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Hortifruti - Cadastro de Grupos";
            this.Load += new System.EventHandler(this.FormCadGrupos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCadGrupos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgViewCadGrupos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtImprimirGrupo;
        private System.Windows.Forms.Button BtExcluirGrupo;
        private System.Windows.Forms.Button BtEditarGrupo;
        private System.Windows.Forms.Button BtIncluirGrupo;
        private System.Windows.Forms.Button BtSairGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Margem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Componentes.AltComboBox cbFiltro;
        private Componentes.AltTextBox tbFiltro;
    }
}