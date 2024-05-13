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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbFiltro = new EasyHortifruti.Componentes.AltTextBox();
            this.cbFiltro = new EasyHortifruti.Componentes.AltComboBox();
            this.panelBotoesCadPedidos = new System.Windows.Forms.Panel();
            this.BtSairPedido = new System.Windows.Forms.Button();
            this.btImprimirPedido = new System.Windows.Forms.Button();
            this.BtExcluirPedido = new System.Windows.Forms.Button();
            this.BtEditarPedido = new System.Windows.Forms.Button();
            this.BtIncluirPedido = new System.Windows.Forms.Button();
            this.panelCadPedidos = new System.Windows.Forms.Panel();
            this.DgvPedidos = new System.Windows.Forms.DataGridView();
            this.panelTituloCadPedidos = new System.Windows.Forms.Panel();
            this.nCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrlucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelBotoesCadPedidos.SuspendLayout();
            this.panelCadPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).BeginInit();
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
            this.tableLayoutPanel2.Controls.Add(this.tbFiltro, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbFiltro, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 128);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(737, 44);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tbFiltro
            // 
            this.tbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiltro.Caption = "Digite para Filtrar";
            this.tbFiltro.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbFiltro.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.Location = new System.Drawing.Point(224, 3);
            this.tbFiltro.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tbFiltro.MaxLength = 32767;
            this.tbFiltro.Multiline = true;
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Obrigatorio = false;
            this.tbFiltro.ReadOnly = false;
            this.tbFiltro.SelectionLength = 0;
            this.tbFiltro.SelectionStart = 0;
            this.tbFiltro.Size = new System.Drawing.Size(510, 35);
            this.tbFiltro.TabIndex = 1;
            this.tbFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFiltro.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // cbFiltro
            // 
            this.cbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cbFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cbFiltro.Caption = "Campo para Filtrar";
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbFiltro.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(13, 3);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Obrigatorio = false;
            this.cbFiltro.SelectedIndex = -1;
            this.cbFiltro.SelectedItem = null;
            this.cbFiltro.SelectedText = "";
            this.cbFiltro.Size = new System.Drawing.Size(194, 38);
            this.cbFiltro.TabIndex = 0;
            // 
            // panelBotoesCadPedidos
            // 
            this.panelBotoesCadPedidos.Controls.Add(this.BtSairPedido);
            this.panelBotoesCadPedidos.Controls.Add(this.btImprimirPedido);
            this.panelBotoesCadPedidos.Controls.Add(this.BtExcluirPedido);
            this.panelBotoesCadPedidos.Controls.Add(this.BtEditarPedido);
            this.panelBotoesCadPedidos.Controls.Add(this.BtIncluirPedido);
            this.panelBotoesCadPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotoesCadPedidos.Location = new System.Drawing.Point(3, 63);
            this.panelBotoesCadPedidos.Name = "panelBotoesCadPedidos";
            this.panelBotoesCadPedidos.Size = new System.Drawing.Size(737, 59);
            this.panelBotoesCadPedidos.TabIndex = 3;
            // 
            // BtSairPedido
            // 
            this.BtSairPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSairPedido.BackColor = System.Drawing.Color.Transparent;
            this.BtSairPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtSairPedido.BackgroundImage")));
            this.BtSairPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtSairPedido.FlatAppearance.BorderSize = 0;
            this.BtSairPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSairPedido.Location = new System.Drawing.Point(677, 3);
            this.BtSairPedido.Name = "BtSairPedido";
            this.BtSairPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtSairPedido.Size = new System.Drawing.Size(46, 53);
            this.BtSairPedido.TabIndex = 5;
            this.BtSairPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtSairPedido.UseVisualStyleBackColor = false;
            this.BtSairPedido.Click += new System.EventHandler(this.BtSairPedido_Click);
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
            // BtExcluirPedido
            // 
            this.BtExcluirPedido.BackColor = System.Drawing.Color.Transparent;
            this.BtExcluirPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtExcluirPedido.BackgroundImage")));
            this.BtExcluirPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtExcluirPedido.FlatAppearance.BorderSize = 0;
            this.BtExcluirPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExcluirPedido.Location = new System.Drawing.Point(116, 3);
            this.BtExcluirPedido.Name = "BtExcluirPedido";
            this.BtExcluirPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtExcluirPedido.Size = new System.Drawing.Size(46, 52);
            this.BtExcluirPedido.TabIndex = 2;
            this.BtExcluirPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtExcluirPedido.UseVisualStyleBackColor = false;
            this.BtExcluirPedido.Click += new System.EventHandler(this.BtExcluirPedido_Click);
            // 
            // BtEditarPedido
            // 
            this.BtEditarPedido.BackColor = System.Drawing.Color.Transparent;
            this.BtEditarPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtEditarPedido.BackgroundImage")));
            this.BtEditarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEditarPedido.FlatAppearance.BorderSize = 0;
            this.BtEditarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEditarPedido.Location = new System.Drawing.Point(64, 3);
            this.BtEditarPedido.Name = "BtEditarPedido";
            this.BtEditarPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtEditarPedido.Size = new System.Drawing.Size(46, 52);
            this.BtEditarPedido.TabIndex = 1;
            this.BtEditarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEditarPedido.UseVisualStyleBackColor = false;
            this.BtEditarPedido.Click += new System.EventHandler(this.BtEditarPedido_Click);
            // 
            // BtIncluirPedido
            // 
            this.BtIncluirPedido.BackColor = System.Drawing.Color.Transparent;
            this.BtIncluirPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtIncluirPedido.BackgroundImage")));
            this.BtIncluirPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtIncluirPedido.FlatAppearance.BorderSize = 0;
            this.BtIncluirPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtIncluirPedido.Location = new System.Drawing.Point(12, 3);
            this.BtIncluirPedido.Name = "BtIncluirPedido";
            this.BtIncluirPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtIncluirPedido.Size = new System.Drawing.Size(46, 52);
            this.BtIncluirPedido.TabIndex = 0;
            this.BtIncluirPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtIncluirPedido.UseVisualStyleBackColor = false;
            this.BtIncluirPedido.Click += new System.EventHandler(this.BtIncluirPedido_Click);
            // 
            // panelCadPedidos
            // 
            this.panelCadPedidos.Controls.Add(this.DgvPedidos);
            this.panelCadPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadPedidos.Location = new System.Drawing.Point(3, 178);
            this.panelCadPedidos.Name = "panelCadPedidos";
            this.panelCadPedidos.Size = new System.Drawing.Size(737, 382);
            this.panelCadPedidos.TabIndex = 4;
            // 
            // DgvPedidos
            // 
            this.DgvPedidos.AllowUserToAddRows = false;
            this.DgvPedidos.AllowUserToDeleteRows = false;
            this.DgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nCliente,
            this.data,
            this.totalPedido,
            this.vlrlucro,
            this.status,
            this.obs,
            this.id});
            this.DgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPedidos.Location = new System.Drawing.Point(0, 0);
            this.DgvPedidos.Name = "DgvPedidos";
            this.DgvPedidos.Size = new System.Drawing.Size(737, 382);
            this.DgvPedidos.TabIndex = 1;
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
            // nCliente
            // 
            this.nCliente.DataPropertyName = "id_fonte";
            this.nCliente.HeaderText = "Cliente";
            this.nCliente.Name = "nCliente";
            this.nCliente.Width = 180;
            // 
            // data
            // 
            this.data.DataPropertyName = "datapedido";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data.DefaultCellStyle = dataGridViewCellStyle1;
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.Width = 80;
            // 
            // totalPedido
            // 
            this.totalPedido.DataPropertyName = "totalvenda";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.totalPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.totalPedido.HeaderText = "Valor Pedido";
            this.totalPedido.Name = "totalPedido";
            this.totalPedido.Width = 95;
            // 
            // vlrlucro
            // 
            this.vlrlucro.DataPropertyName = "vlrlucro";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.vlrlucro.DefaultCellStyle = dataGridViewCellStyle3;
            this.vlrlucro.HeaderText = "Lucro Pedido";
            this.vlrlucro.Name = "vlrlucro";
            this.vlrlucro.Width = 95;
            // 
            // status
            // 
            this.status.DataPropertyName = "statuspedido";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.status.DefaultCellStyle = dataGridViewCellStyle4;
            this.status.HeaderText = "Status Pedido";
            this.status.Name = "status";
            // 
            // obs
            // 
            this.obs.DataPropertyName = "obspedido";
            this.obs.HeaderText = "Observações";
            this.obs.Name = "obs";
            this.obs.Width = 200;
            // 
            // id
            // 
            this.id.DataPropertyName = "id_recno";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTituloCadPedidos;
        private System.Windows.Forms.Panel panelBotoesCadPedidos;
        private System.Windows.Forms.Button BtSairPedido;
        private System.Windows.Forms.Button btImprimirPedido;
        private System.Windows.Forms.Button BtExcluirPedido;
        private System.Windows.Forms.Button BtEditarPedido;
        private System.Windows.Forms.Button BtIncluirPedido;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelCadPedidos;
        private System.Windows.Forms.DataGridView DgvPedidos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Componentes.AltComboBox cbFiltro;
        private Componentes.AltTextBox tbFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrlucro;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}