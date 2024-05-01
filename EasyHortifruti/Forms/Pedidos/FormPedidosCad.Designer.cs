namespace EasyHortifruti
{
    partial class FormPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbFiltro = new EasyHortifruti.Componentes.AltComboBox();
            this.tbFiltro = new EasyHortifruti.Componentes.AltTextBox();
            this.panelBotoesCadPedidos = new System.Windows.Forms.Panel();
            this.btSairPedido = new System.Windows.Forms.Button();
            this.btImprimirPedido = new System.Windows.Forms.Button();
            this.btExcluirPedido = new System.Windows.Forms.Button();
            this.btEditarPedido = new System.Windows.Forms.Button();
            this.btIncluirPedido = new System.Windows.Forms.Button();
            this.panelCadPedidos = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTituloCadPedidos = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelBotoesCadPedidos.SuspendLayout();
            this.panelCadPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 563);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelBotoesCadPedidos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelCadPedidos, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelTituloCadPedidos, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 563);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.cbFiltro, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbFiltro, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 128);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(737, 44);
            this.tableLayoutPanel2.TabIndex = 5;
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
            this.cbFiltro.SelectedItem = null;
            this.cbFiltro.SelectedText = "";
            this.cbFiltro.Size = new System.Drawing.Size(215, 38);
            this.cbFiltro.TabIndex = 0;
            // 
            // tbFiltro
            // 
            this.tbFiltro.Caption = "Digite para Filtrar";
            this.tbFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFiltro.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbFiltro.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.Location = new System.Drawing.Point(224, 3);
            this.tbFiltro.MaxLength = 32767;
            this.tbFiltro.Multiline = true;
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Obrigatorio = false;
            this.tbFiltro.ReadOnly = false;
            this.tbFiltro.SelectionLength = 0;
            this.tbFiltro.SelectionStart = 0;
            this.tbFiltro.Size = new System.Drawing.Size(510, 38);
            this.tbFiltro.TabIndex = 1;
            this.tbFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFiltro.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // panelBotoesCadPedidos
            // 
            this.panelBotoesCadPedidos.Controls.Add(this.btSairPedido);
            this.panelBotoesCadPedidos.Controls.Add(this.btImprimirPedido);
            this.panelBotoesCadPedidos.Controls.Add(this.btExcluirPedido);
            this.panelBotoesCadPedidos.Controls.Add(this.btEditarPedido);
            this.panelBotoesCadPedidos.Controls.Add(this.btIncluirPedido);
            this.panelBotoesCadPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotoesCadPedidos.Location = new System.Drawing.Point(3, 63);
            this.panelBotoesCadPedidos.Name = "panelBotoesCadPedidos";
            this.panelBotoesCadPedidos.Size = new System.Drawing.Size(737, 59);
            this.panelBotoesCadPedidos.TabIndex = 3;
            // 
            // btSairPedido
            // 
            this.btSairPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSairPedido.BackColor = System.Drawing.Color.Transparent;
            this.btSairPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSairPedido.BackgroundImage")));
            this.btSairPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSairPedido.FlatAppearance.BorderSize = 0;
            this.btSairPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSairPedido.Location = new System.Drawing.Point(677, 3);
            this.btSairPedido.Name = "btSairPedido";
            this.btSairPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btSairPedido.Size = new System.Drawing.Size(46, 53);
            this.btSairPedido.TabIndex = 5;
            this.btSairPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSairPedido.UseVisualStyleBackColor = false;
            this.btSairPedido.Click += new System.EventHandler(this.btSairPedido_Click);
            // 
            // btImprimirPedido
            // 
            this.btImprimirPedido.BackColor = System.Drawing.Color.Transparent;
            this.btImprimirPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btImprimirPedido.BackgroundImage")));
            this.btImprimirPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btImprimirPedido.FlatAppearance.BorderSize = 0;
            this.btImprimirPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImprimirPedido.Location = new System.Drawing.Point(173, 4);
            this.btImprimirPedido.Name = "btImprimirPedido";
            this.btImprimirPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btImprimirPedido.Size = new System.Drawing.Size(46, 52);
            this.btImprimirPedido.TabIndex = 3;
            this.btImprimirPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btImprimirPedido.UseVisualStyleBackColor = false;
            // 
            // btExcluirPedido
            // 
            this.btExcluirPedido.BackColor = System.Drawing.Color.Transparent;
            this.btExcluirPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExcluirPedido.BackgroundImage")));
            this.btExcluirPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExcluirPedido.FlatAppearance.BorderSize = 0;
            this.btExcluirPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluirPedido.Location = new System.Drawing.Point(116, 3);
            this.btExcluirPedido.Name = "btExcluirPedido";
            this.btExcluirPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btExcluirPedido.Size = new System.Drawing.Size(46, 52);
            this.btExcluirPedido.TabIndex = 2;
            this.btExcluirPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluirPedido.UseVisualStyleBackColor = false;
            this.btExcluirPedido.Click += new System.EventHandler(this.btExcluirPedido_Click);
            // 
            // btEditarPedido
            // 
            this.btEditarPedido.BackColor = System.Drawing.Color.Transparent;
            this.btEditarPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEditarPedido.BackgroundImage")));
            this.btEditarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEditarPedido.FlatAppearance.BorderSize = 0;
            this.btEditarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarPedido.Location = new System.Drawing.Point(64, 3);
            this.btEditarPedido.Name = "btEditarPedido";
            this.btEditarPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btEditarPedido.Size = new System.Drawing.Size(46, 52);
            this.btEditarPedido.TabIndex = 1;
            this.btEditarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEditarPedido.UseVisualStyleBackColor = false;
            this.btEditarPedido.Click += new System.EventHandler(this.btEditarPedido_Click);
            // 
            // btIncluirPedido
            // 
            this.btIncluirPedido.BackColor = System.Drawing.Color.Transparent;
            this.btIncluirPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btIncluirPedido.BackgroundImage")));
            this.btIncluirPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btIncluirPedido.FlatAppearance.BorderSize = 0;
            this.btIncluirPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIncluirPedido.Location = new System.Drawing.Point(12, 3);
            this.btIncluirPedido.Name = "btIncluirPedido";
            this.btIncluirPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btIncluirPedido.Size = new System.Drawing.Size(46, 52);
            this.btIncluirPedido.TabIndex = 0;
            this.btIncluirPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btIncluirPedido.UseVisualStyleBackColor = false;
            this.btIncluirPedido.Click += new System.EventHandler(this.btIncluirPedido_Click);
            // 
            // panelCadPedidos
            // 
            this.panelCadPedidos.Controls.Add(this.dataGridView1);
            this.panelCadPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadPedidos.Location = new System.Drawing.Point(3, 178);
            this.panelCadPedidos.Name = "panelCadPedidos";
            this.panelCadPedidos.Size = new System.Drawing.Size(737, 382);
            this.panelCadPedidos.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 375);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cliente";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Data";
            this.Column2.Name = "Column2";
            // 
            // panelTituloCadPedidos
            // 
            this.panelTituloCadPedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTituloCadPedidos.BackgroundImage")));
            this.panelTituloCadPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelTituloCadPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTituloCadPedidos.Location = new System.Drawing.Point(3, 3);
            this.panelTituloCadPedidos.Name = "panelTituloCadPedidos";
            this.panelTituloCadPedidos.Size = new System.Drawing.Size(737, 54);
            this.panelTituloCadPedidos.TabIndex = 0;
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 563);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyHortifruti - Pedidos";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelBotoesCadPedidos.ResumeLayout(false);
            this.panelCadPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTituloCadPedidos;
        private System.Windows.Forms.Panel panelBotoesCadPedidos;
        private System.Windows.Forms.Button btSairPedido;
        private System.Windows.Forms.Button btImprimirPedido;
        private System.Windows.Forms.Button btExcluirPedido;
        private System.Windows.Forms.Button btEditarPedido;
        private System.Windows.Forms.Button btIncluirPedido;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelCadPedidos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Componentes.AltComboBox cbFiltro;
        private Componentes.AltTextBox tbFiltro;
    }
}