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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtSairUnidades = new System.Windows.Forms.Button();
            this.BtPesquisarUnidades = new System.Windows.Forms.Button();
            this.BtImprimirUnidades = new System.Windows.Forms.Button();
            this.BtExcluirUnidades = new System.Windows.Forms.Button();
            this.BtEditarUnidades = new System.Windows.Forms.Button();
            this.BtIncluirUnidades = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvCadUnidades = new System.Windows.Forms.DataGridView();
            this.Abreviação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource1)).BeginInit();
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
            this.panel3.Controls.Add(this.BtSairUnidades);
            this.panel3.Controls.Add(this.BtPesquisarUnidades);
            this.panel3.Controls.Add(this.BtImprimirUnidades);
            this.panel3.Controls.Add(this.BtExcluirUnidades);
            this.panel3.Controls.Add(this.BtEditarUnidades);
            this.panel3.Controls.Add(this.BtIncluirUnidades);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(569, 77);
            this.panel3.TabIndex = 1;
            // 
            // BtSairUnidades
            // 
            this.BtSairUnidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSairUnidades.BackColor = System.Drawing.Color.Transparent;
            this.BtSairUnidades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtSairUnidades.BackgroundImage")));
            this.BtSairUnidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtSairUnidades.FlatAppearance.BorderSize = 0;
            this.BtSairUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSairUnidades.Location = new System.Drawing.Point(508, 11);
            this.BtSairUnidades.Name = "BtSairUnidades";
            this.BtSairUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtSairUnidades.Size = new System.Drawing.Size(44, 52);
            this.BtSairUnidades.TabIndex = 10;
            this.BtSairUnidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtSairUnidades.UseVisualStyleBackColor = false;
            this.BtSairUnidades.Click += new System.EventHandler(this.BtSairUnidades_Click);
            // 
            // BtPesquisarUnidades
            // 
            this.BtPesquisarUnidades.BackColor = System.Drawing.Color.Transparent;
            this.BtPesquisarUnidades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtPesquisarUnidades.BackgroundImage")));
            this.BtPesquisarUnidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtPesquisarUnidades.FlatAppearance.BorderSize = 0;
            this.BtPesquisarUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPesquisarUnidades.Location = new System.Drawing.Point(168, 13);
            this.BtPesquisarUnidades.Name = "BtPesquisarUnidades";
            this.BtPesquisarUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtPesquisarUnidades.Size = new System.Drawing.Size(46, 52);
            this.BtPesquisarUnidades.TabIndex = 9;
            this.BtPesquisarUnidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtPesquisarUnidades.UseVisualStyleBackColor = false;
            // 
            // BtImprimirUnidades
            // 
            this.BtImprimirUnidades.BackColor = System.Drawing.Color.Transparent;
            this.BtImprimirUnidades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtImprimirUnidades.BackgroundImage")));
            this.BtImprimirUnidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtImprimirUnidades.FlatAppearance.BorderSize = 0;
            this.BtImprimirUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtImprimirUnidades.Location = new System.Drawing.Point(220, 13);
            this.BtImprimirUnidades.Name = "BtImprimirUnidades";
            this.BtImprimirUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtImprimirUnidades.Size = new System.Drawing.Size(46, 52);
            this.BtImprimirUnidades.TabIndex = 8;
            this.BtImprimirUnidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtImprimirUnidades.UseVisualStyleBackColor = false;
            // 
            // BtExcluirUnidades
            // 
            this.BtExcluirUnidades.BackColor = System.Drawing.Color.Transparent;
            this.BtExcluirUnidades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtExcluirUnidades.BackgroundImage")));
            this.BtExcluirUnidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtExcluirUnidades.FlatAppearance.BorderSize = 0;
            this.BtExcluirUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExcluirUnidades.Location = new System.Drawing.Point(116, 12);
            this.BtExcluirUnidades.Name = "BtExcluirUnidades";
            this.BtExcluirUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtExcluirUnidades.Size = new System.Drawing.Size(46, 52);
            this.BtExcluirUnidades.TabIndex = 7;
            this.BtExcluirUnidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtExcluirUnidades.UseVisualStyleBackColor = false;
            this.BtExcluirUnidades.Click += new System.EventHandler(this.BtExcluirUnidades_Click);
            // 
            // BtEditarUnidades
            // 
            this.BtEditarUnidades.BackColor = System.Drawing.Color.Transparent;
            this.BtEditarUnidades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtEditarUnidades.BackgroundImage")));
            this.BtEditarUnidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEditarUnidades.FlatAppearance.BorderSize = 0;
            this.BtEditarUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEditarUnidades.Location = new System.Drawing.Point(64, 12);
            this.BtEditarUnidades.Name = "BtEditarUnidades";
            this.BtEditarUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtEditarUnidades.Size = new System.Drawing.Size(46, 52);
            this.BtEditarUnidades.TabIndex = 6;
            this.BtEditarUnidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEditarUnidades.UseVisualStyleBackColor = false;
            this.BtEditarUnidades.Click += new System.EventHandler(this.BtEditarUnidade_Click);
            // 
            // BtIncluirUnidades
            // 
            this.BtIncluirUnidades.BackColor = System.Drawing.Color.Transparent;
            this.BtIncluirUnidades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtIncluirUnidades.BackgroundImage")));
            this.BtIncluirUnidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtIncluirUnidades.FlatAppearance.BorderSize = 0;
            this.BtIncluirUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtIncluirUnidades.Location = new System.Drawing.Point(12, 12);
            this.BtIncluirUnidades.Name = "BtIncluirUnidades";
            this.BtIncluirUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtIncluirUnidades.Size = new System.Drawing.Size(46, 52);
            this.BtIncluirUnidades.TabIndex = 5;
            this.BtIncluirUnidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtIncluirUnidades.UseVisualStyleBackColor = false;
            this.BtIncluirUnidades.Click += new System.EventHandler(this.BtIncluirUnidade_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCadUnidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCadUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadUnidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abreviação,
            this.ID});
            this.dgvCadUnidades.DataSource = this.unidadesBindingSource;
            this.dgvCadUnidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCadUnidades.Location = new System.Drawing.Point(0, 0);
            this.dgvCadUnidades.Name = "dgvCadUnidades";
            this.dgvCadUnidades.Size = new System.Drawing.Size(569, 469);
            this.dgvCadUnidades.TabIndex = 0;
            // 
            // Abreviação
            // 
            this.Abreviação.DataPropertyName = "abrev_unid";
            this.Abreviação.HeaderText = "Abreviação";
            this.Abreviação.Name = "Abreviação";
            this.Abreviação.Width = 80;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_recno";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // unidadesBindingSource
            // 
            this.unidadesBindingSource.DataMember = "Unidades";
            // 
            // unidadesBindingSource1
            // 
            this.unidadesBindingSource1.DataMember = "Unidades";
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
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtPesquisarUnidades;
        private System.Windows.Forms.Button BtImprimirUnidades;
        private System.Windows.Forms.Button BtExcluirUnidades;
        private System.Windows.Forms.Button BtEditarUnidades;
        private System.Windows.Forms.Button BtIncluirUnidades;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtSairUnidades;
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