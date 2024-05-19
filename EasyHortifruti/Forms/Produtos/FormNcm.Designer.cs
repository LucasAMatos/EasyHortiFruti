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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtFiltro = new EasyHortifruti.Componentes.AltTextBox();
            this.cbFiltro = new EasyHortifruti.Componentes.AltComboBox();
            this.numero_ncm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao_ncm = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.numero_ncm,
            this.descricao_ncm});
            this.dataGridView1.Location = new System.Drawing.Point(5, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(434, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(5, 329);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(434, 23);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Caption = "Digite para pesquisar";
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltro.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtFiltro.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltro.Location = new System.Drawing.Point(135, 21);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltro.MaxLength = 32767;
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Obrigatorio = false;
            this.txtFiltro.ReadOnly = false;
            this.txtFiltro.SelectionLength = 0;
            this.txtFiltro.SelectionStart = 0;
            this.txtFiltro.Size = new System.Drawing.Size(304, 48);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFiltro.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            this.txtFiltro.TextChanged += new System.EventHandler(this.AltTextBox1_TextChanged);
            this.txtFiltro.Load += new System.EventHandler(this.txtFiltro_Load);
            // 
            // cbFiltro
            // 
            this.cbFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cbFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cbFiltro.Caption = "Campo para Filtrar";
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbFiltro.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(5, 29);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Obrigatorio = false;
            this.cbFiltro.SelectedIndex = -1;
            this.cbFiltro.SelectedItem = null;
            this.cbFiltro.SelectedText = "";
            this.cbFiltro.Size = new System.Drawing.Size(123, 46);
            this.cbFiltro.TabIndex = 6;
            // 
            // numero_ncm
            // 
            this.numero_ncm.DataPropertyName = "numero_ncm";
            this.numero_ncm.HeaderText = "numero_ncm";
            this.numero_ncm.Name = "numero_ncm";
            this.numero_ncm.ReadOnly = true;
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
            // FormNcm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 358);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormNcm";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSelecionar;
        private Componentes.AltTextBox txtFiltro;
        private Componentes.AltComboBox cbFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_ncm;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao_ncm;
    }
}
