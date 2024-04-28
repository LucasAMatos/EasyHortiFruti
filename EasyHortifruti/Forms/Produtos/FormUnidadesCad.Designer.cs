namespace EasyHortifruti
{
    partial class FormUnidadeCad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnidadeCad));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.unidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCadUnidades = new System.Windows.Forms.DataGridView();
            this.Abreviação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btSairUnidades = new System.Windows.Forms.Button();
            this.btPesquisarUnidades = new System.Windows.Forms.Button();
            this.btImprimirUnidades = new System.Windows.Forms.Button();
            this.btExcluirUnidades = new System.Windows.Forms.Button();
            this.btEditarUnidades = new System.Windows.Forms.Button();
            this.btIncluirUnidades = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.altComboBox1 = new EasyHortifruti.Componentes.AltComboBox();
            this.altTextBox1 = new EasyHortifruti.Componentes.AltTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadUnidades)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // unidadesBindingSource
            // 
            this.unidadesBindingSource.DataMember = "Unidades";
            // 
            // unidadesBindingSource1
            // 
            this.unidadesBindingSource1.DataMember = "Unidades";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvCadUnidades, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 591);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 43);
            this.panel2.TabIndex = 0;
            // 
            // dgvCadUnidades
            // 
            this.dgvCadUnidades.AllowUserToAddRows = false;
            this.dgvCadUnidades.AllowUserToOrderColumns = true;
            this.dgvCadUnidades.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCadUnidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCadUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadUnidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abreviação,
            this.Descricao,
            this.Observacao,
            this.ID});
            this.dgvCadUnidades.DataSource = this.unidadesBindingSource;
            this.dgvCadUnidades.Location = new System.Drawing.Point(3, 182);
            this.dgvCadUnidades.MultiSelect = false;
            this.dgvCadUnidades.Name = "dgvCadUnidades";
            this.dgvCadUnidades.ReadOnly = true;
            this.dgvCadUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadUnidades.Size = new System.Drawing.Size(566, 406);
            this.dgvCadUnidades.TabIndex = 0;
            // 
            // Abreviação
            // 
            this.Abreviação.DataPropertyName = "abrev_unid";
            this.Abreviação.HeaderText = "Abreviação";
            this.Abreviação.Name = "Abreviação";
            this.Abreviação.ReadOnly = true;
            this.Abreviação.Width = 80;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "desc_unid";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 200;
            // 
            // Observacao
            // 
            this.Observacao.DataPropertyName = "obs_unid";
            this.Observacao.HeaderText = "Observação";
            this.Observacao.Name = "Observacao";
            this.Observacao.ReadOnly = true;
            this.Observacao.Width = 200;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btSairUnidades);
            this.panel3.Controls.Add(this.btPesquisarUnidades);
            this.panel3.Controls.Add(this.btImprimirUnidades);
            this.panel3.Controls.Add(this.btExcluirUnidades);
            this.panel3.Controls.Add(this.btEditarUnidades);
            this.panel3.Controls.Add(this.btIncluirUnidades);
            this.panel3.Location = new System.Drawing.Point(3, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 74);
            this.panel3.TabIndex = 1;
            // 
            // btSairUnidades
            // 
            this.btSairUnidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSairUnidades.BackColor = System.Drawing.Color.Transparent;
            this.btSairUnidades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSairUnidades.BackgroundImage")));
            this.btSairUnidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSairUnidades.FlatAppearance.BorderSize = 0;
            this.btSairUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSairUnidades.Location = new System.Drawing.Point(514, 14);
            this.btSairUnidades.Name = "btSairUnidades";
            this.btSairUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btSairUnidades.Size = new System.Drawing.Size(44, 51);
            this.btSairUnidades.TabIndex = 10;
            this.btSairUnidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSairUnidades.UseVisualStyleBackColor = false;
            this.btSairUnidades.Click += new System.EventHandler(this.btSairUnidades_Click);
            // 
            // btPesquisarUnidades
            // 
            this.btPesquisarUnidades.BackColor = System.Drawing.Color.Transparent;
            this.btPesquisarUnidades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPesquisarUnidades.BackgroundImage")));
            this.btPesquisarUnidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesquisarUnidades.FlatAppearance.BorderSize = 0;
            this.btPesquisarUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisarUnidades.Location = new System.Drawing.Point(168, 13);
            this.btPesquisarUnidades.Name = "btPesquisarUnidades";
            this.btPesquisarUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btPesquisarUnidades.Size = new System.Drawing.Size(46, 52);
            this.btPesquisarUnidades.TabIndex = 9;
            this.btPesquisarUnidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPesquisarUnidades.UseVisualStyleBackColor = false;
            // 
            // btImprimirUnidades
            // 
            this.btImprimirUnidades.BackColor = System.Drawing.Color.Transparent;
            this.btImprimirUnidades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btImprimirUnidades.BackgroundImage")));
            this.btImprimirUnidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btImprimirUnidades.FlatAppearance.BorderSize = 0;
            this.btImprimirUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImprimirUnidades.Location = new System.Drawing.Point(220, 13);
            this.btImprimirUnidades.Name = "btImprimirUnidades";
            this.btImprimirUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btImprimirUnidades.Size = new System.Drawing.Size(46, 52);
            this.btImprimirUnidades.TabIndex = 8;
            this.btImprimirUnidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btImprimirUnidades.UseVisualStyleBackColor = false;
            // 
            // btExcluirUnidades
            // 
            this.btExcluirUnidades.BackColor = System.Drawing.Color.Transparent;
            this.btExcluirUnidades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExcluirUnidades.BackgroundImage")));
            this.btExcluirUnidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExcluirUnidades.FlatAppearance.BorderSize = 0;
            this.btExcluirUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluirUnidades.Location = new System.Drawing.Point(116, 12);
            this.btExcluirUnidades.Name = "btExcluirUnidades";
            this.btExcluirUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btExcluirUnidades.Size = new System.Drawing.Size(46, 52);
            this.btExcluirUnidades.TabIndex = 7;
            this.btExcluirUnidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluirUnidades.UseVisualStyleBackColor = false;
            this.btExcluirUnidades.Click += new System.EventHandler(this.btExcluirUnidades_Click);
            // 
            // btEditarUnidades
            // 
            this.btEditarUnidades.BackColor = System.Drawing.Color.Transparent;
            this.btEditarUnidades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEditarUnidades.BackgroundImage")));
            this.btEditarUnidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEditarUnidades.FlatAppearance.BorderSize = 0;
            this.btEditarUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarUnidades.Location = new System.Drawing.Point(64, 12);
            this.btEditarUnidades.Name = "btEditarUnidades";
            this.btEditarUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btEditarUnidades.Size = new System.Drawing.Size(46, 52);
            this.btEditarUnidades.TabIndex = 6;
            this.btEditarUnidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEditarUnidades.UseVisualStyleBackColor = false;
            this.btEditarUnidades.Click += new System.EventHandler(this.btEditarUnidade_Click);
            // 
            // btIncluirUnidades
            // 
            this.btIncluirUnidades.BackColor = System.Drawing.Color.Transparent;
            this.btIncluirUnidades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btIncluirUnidades.BackgroundImage")));
            this.btIncluirUnidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btIncluirUnidades.FlatAppearance.BorderSize = 0;
            this.btIncluirUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIncluirUnidades.Location = new System.Drawing.Point(12, 12);
            this.btIncluirUnidades.Name = "btIncluirUnidades";
            this.btIncluirUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btIncluirUnidades.Size = new System.Drawing.Size(46, 52);
            this.btIncluirUnidades.TabIndex = 5;
            this.btIncluirUnidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btIncluirUnidades.UseVisualStyleBackColor = false;
            this.btIncluirUnidades.Click += new System.EventHandler(this.btIncluirUnidade_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.altComboBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.altTextBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 132);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(566, 44);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // altComboBox1
            // 
            this.altComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.altComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.altComboBox1.Caption = "Campo para Filtrar";
            this.altComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.altComboBox1.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altComboBox1.FormattingEnabled = true;
            this.altComboBox1.Location = new System.Drawing.Point(3, 3);
            this.altComboBox1.Name = "altComboBox1";
            this.altComboBox1.Obrigatorio = false;
            this.altComboBox1.SelectedIndex = -1;
            this.altComboBox1.SelectedItem = null;
            this.altComboBox1.SelectedText = "";
            this.altComboBox1.Size = new System.Drawing.Size(163, 38);
            this.altComboBox1.TabIndex = 0;
            // 
            // altTextBox1
            // 
            this.altTextBox1.Caption = "Digite para Filtrar";
            this.altTextBox1.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altTextBox1.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altTextBox1.Location = new System.Drawing.Point(172, 3);
            this.altTextBox1.MaxLength = 32767;
            this.altTextBox1.Multiline = true;
            this.altTextBox1.Name = "altTextBox1";
            this.altTextBox1.Obrigatorio = false;
            this.altTextBox1.ReadOnly = false;
            this.altTextBox1.SelectionLength = 0;
            this.altTextBox1.SelectionStart = 0;
            this.altTextBox1.Size = new System.Drawing.Size(391, 36);
            this.altTextBox1.TabIndex = 1;
            this.altTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.altTextBox1.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(573, 591);
            this.panel4.TabIndex = 2;
            // 
            // FormUnidadeCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 591);
            this.Controls.Add(this.panel4);
            this.Name = "FormUnidadeCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyHorti - Cadastro de Unidades";
            this.Load += new System.EventHandler(this.FormUnidadeCad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadUnidades)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource unidadesBindingSource;
        private System.Windows.Forms.BindingSource unidadesBindingSource1;
#pragma warning disable CS0169 // O campo "FormUnidadeCad.abreviaturaDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn abreviaturaDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "FormUnidadeCad.abreviaturaDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "FormUnidadeCad.descricaoDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "FormUnidadeCad.descricaoDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "FormUnidadeCad.observacaoDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "FormUnidadeCad.observacaoDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "FormUnidadeCad.códigoDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "FormUnidadeCad.códigoDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observação;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCadUnidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abreviação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btSairUnidades;
        private System.Windows.Forms.Button btPesquisarUnidades;
        private System.Windows.Forms.Button btImprimirUnidades;
        private System.Windows.Forms.Button btExcluirUnidades;
        private System.Windows.Forms.Button btEditarUnidades;
        private System.Windows.Forms.Button btIncluirUnidades;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private Componentes.AltComboBox altComboBox1;
        private Componentes.AltTextBox altTextBox1;
    }
}