namespace EasyHortifruti
{
    partial class FormCadUnidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadUnidade));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btSairUnidades = new System.Windows.Forms.Button();
            this.btPesquisarUnidades = new System.Windows.Forms.Button();
            this.btImprimirUnidades = new System.Windows.Forms.Button();
            this.btExcluirUnidades = new System.Windows.Forms.Button();
            this.btEditarUnidades = new System.Windows.Forms.Button();
            this.btIncluirUnidades = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvCadUnidades = new System.Windows.Forms.DataGridView();
            this.unidadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.unidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Abreviação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 122);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btSairUnidades);
            this.panel3.Controls.Add(this.btPesquisarUnidades);
            this.panel3.Controls.Add(this.btImprimirUnidades);
            this.panel3.Controls.Add(this.btExcluirUnidades);
            this.panel3.Controls.Add(this.btEditarUnidades);
            this.panel3.Controls.Add(this.btIncluirUnidades);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(569, 77);
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
            this.btSairUnidades.Location = new System.Drawing.Point(508, 11);
            this.btSairUnidades.Name = "btSairUnidades";
            this.btSairUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btSairUnidades.Size = new System.Drawing.Size(44, 52);
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
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 45);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvCadUnidades);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(569, 469);
            this.panel4.TabIndex = 2;
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
            this.Descrição,
            this.Observação,
            this.ID});
            this.dgvCadUnidades.DataSource = this.unidadesBindingSource;
            this.dgvCadUnidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCadUnidades.Location = new System.Drawing.Point(0, 0);
            this.dgvCadUnidades.Name = "dgvCadUnidades";
            this.dgvCadUnidades.Size = new System.Drawing.Size(569, 469);
            this.dgvCadUnidades.TabIndex = 0;
            // 
            // unidadesBindingSource1
            // 
            this.unidadesBindingSource1.DataMember = "Unidades";
            // 
            // unidadesBindingSource
            // 
            this.unidadesBindingSource.DataMember = "Unidades";
            // 
            // Abreviação
            // 
            this.Abreviação.DataPropertyName = "abrev_unid";
            this.Abreviação.HeaderText = "Abreviação";
            this.Abreviação.Name = "Abreviação";
            this.Abreviação.Width = 80;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "desc_unid";
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.Width = 200;
            // 
            // Observação
            // 
            this.Observação.DataPropertyName = "obs_unid";
            this.Observação.HeaderText = "Observação";
            this.Observação.Name = "Observação";
            this.Observação.Width = 200;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_recno";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // FormCadUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 591);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "FormCadUnidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyHorti - Cadastro de Unidades";
            this.Load += new System.EventHandler(this.FormCadUnidade_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btPesquisarUnidades;
        private System.Windows.Forms.Button btImprimirUnidades;
        private System.Windows.Forms.Button btExcluirUnidades;
        private System.Windows.Forms.Button btEditarUnidades;
        private System.Windows.Forms.Button btIncluirUnidades;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btSairUnidades;
        private System.Windows.Forms.DataGridView dgvCadUnidades;
        private System.Windows.Forms.BindingSource unidadesBindingSource;
        private System.Windows.Forms.BindingSource unidadesBindingSource1;
#pragma warning disable CS0169 // O campo "FormCadUnidade.abreviaturaDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn abreviaturaDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "FormCadUnidade.abreviaturaDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "FormCadUnidade.descricaoDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "FormCadUnidade.descricaoDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "FormCadUnidade.observacaoDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "FormCadUnidade.observacaoDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "FormCadUnidade.códigoDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "FormCadUnidade.códigoDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn Abreviação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observação;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}