namespace EasyHortifruti.Forms.Produtos
{
    partial class FormNcm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descricao_ncm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_ncm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtFiltro = new EasyHortifruti.Componentes.AltTextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricao_ncm,
            this.numero_ncm});
            this.dataGridView1.Location = new System.Drawing.Point(5, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(323, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // descricao_ncm
            // 
            this.descricao_ncm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.descricao_ncm.DataPropertyName = "descricao_ncm";
            this.descricao_ncm.HeaderText = "Categoria";
            this.descricao_ncm.Name = "descricao_ncm";
            this.descricao_ncm.ReadOnly = true;
            this.descricao_ncm.Width = 77;
            // 
            // numero_ncm
            // 
            this.numero_ncm.DataPropertyName = "numero_ncm";
            this.numero_ncm.HeaderText = "numero_ncm";
            this.numero_ncm.Name = "numero_ncm";
            this.numero_ncm.ReadOnly = true;
            this.numero_ncm.Visible = false;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(5, 329);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(323, 23);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Caption = null;
            this.txtFiltro.Location = new System.Drawing.Point(5, 40);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Obrigatorio = false;
            this.txtFiltro.Size = new System.Drawing.Size(323, 20);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            this.txtFiltro.TextChanged += new System.EventHandler(this.altTextBox1_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(9, 18);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(106, 13);
            this.lblPesquisar.TabIndex = 4;
            this.lblPesquisar.Text = "Digite para pesquisar";
            // 
            // FormNcm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 358);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormNcm";
            this.Load += new System.EventHandler(this.form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao_ncm;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_ncm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSelecionar;
        private Componentes.AltTextBox txtFiltro;
        private System.Windows.Forms.Label lblPesquisar;
    }
}
