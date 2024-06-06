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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DgvPedidos = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtFim = new System.Windows.Forms.DateTimePicker();
            this.DtInicio = new System.Windows.Forms.DateTimePicker();
            this.tbFiltro = new EasyHortifruti.Componentes.AltTextBox();
            this.cbFiltro = new EasyHortifruti.Componentes.AltComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtSairPedido = new System.Windows.Forms.Button();
            this.btImprimirPedido = new System.Windows.Forms.Button();
            this.BtExcluirPedido = new System.Windows.Forms.Button();
            this.BtEditarPedido = new System.Windows.Forms.Button();
            this.BtIncluirPedido = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrlucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorcompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 661);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.DgvPedidos);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 182);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(876, 479);
            this.panel7.TabIndex = 11;
            // 
            // DgvPedidos
            // 
            this.DgvPedidos.AllowUserToAddRows = false;
            this.DgvPedidos.AllowUserToDeleteRows = false;
            this.DgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nCliente,
            this.data,
            this.dataentrega,
            this.totalPedido,
            this.vlrlucro,
            this.valorcompra,
            this.status,
            this.obs,
            this.ID});
            this.DgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPedidos.Location = new System.Drawing.Point(0, 0);
            this.DgvPedidos.Name = "DgvPedidos";
            this.DgvPedidos.Size = new System.Drawing.Size(876, 479);
            this.DgvPedidos.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.DtFim);
            this.panel6.Controls.Add(this.DtInicio);
            this.panel6.Controls.Add(this.tbFiltro);
            this.panel6.Controls.Add(this.cbFiltro);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 133);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(876, 49);
            this.panel6.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(742, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Período Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(617, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Período Inicial";
            // 
            // DtFim
            // 
            this.DtFim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtFim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFim.Location = new System.Drawing.Point(745, 20);
            this.DtFim.Name = "DtFim";
            this.DtFim.Size = new System.Drawing.Size(115, 23);
            this.DtFim.TabIndex = 5;
            this.DtFim.ValueChanged += new System.EventHandler(this.DateChanged);
            // 
            // DtInicio
            // 
            this.DtInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtInicio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtInicio.Location = new System.Drawing.Point(619, 20);
            this.DtInicio.Name = "DtInicio";
            this.DtInicio.Size = new System.Drawing.Size(109, 23);
            this.DtInicio.TabIndex = 4;
            this.DtInicio.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.DtInicio.ValueChanged += new System.EventHandler(this.DateChanged);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiltro.Caption = "Digite para Filtrar";
            this.tbFiltro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.Location = new System.Drawing.Point(207, 2);
            this.tbFiltro.Margin = new System.Windows.Forms.Padding(20, 3, 20, 9);
            this.tbFiltro.MaxLength = 32767;
            this.tbFiltro.Multiline = true;
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Obrigatorio = false;
            this.tbFiltro.ReadOnly = false;
            this.tbFiltro.SelectionLength = 0;
            this.tbFiltro.SelectionStart = 0;
            this.tbFiltro.Size = new System.Drawing.Size(400, 41);
            this.tbFiltro.TabIndex = 3;
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
            this.cbFiltro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(13, 3);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Obrigatorio = false;
            this.cbFiltro.SelectedIndex = -1;
            this.cbFiltro.SelectedItem = null;
            this.cbFiltro.SelectedText = "";
            this.cbFiltro.Size = new System.Drawing.Size(181, 43);
            this.cbFiltro.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtSairPedido);
            this.panel5.Controls.Add(this.btImprimirPedido);
            this.panel5.Controls.Add(this.BtExcluirPedido);
            this.panel5.Controls.Add(this.BtEditarPedido);
            this.panel5.Controls.Add(this.BtIncluirPedido);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(876, 63);
            this.panel5.TabIndex = 9;
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
            this.BtSairPedido.Location = new System.Drawing.Point(814, 5);
            this.BtSairPedido.Name = "BtSairPedido";
            this.BtSairPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtSairPedido.Size = new System.Drawing.Size(46, 53);
            this.BtSairPedido.TabIndex = 10;
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
            this.btImprimirPedido.Location = new System.Drawing.Point(177, 6);
            this.btImprimirPedido.Name = "btImprimirPedido";
            this.btImprimirPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btImprimirPedido.Size = new System.Drawing.Size(46, 52);
            this.btImprimirPedido.TabIndex = 9;
            this.btImprimirPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btImprimirPedido.UseVisualStyleBackColor = false;
            this.btImprimirPedido.Click += new System.EventHandler(this.btImprimirPedido_Click);
            // 
            // BtExcluirPedido
            // 
            this.BtExcluirPedido.BackColor = System.Drawing.Color.Transparent;
            this.BtExcluirPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtExcluirPedido.BackgroundImage")));
            this.BtExcluirPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtExcluirPedido.FlatAppearance.BorderSize = 0;
            this.BtExcluirPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExcluirPedido.Location = new System.Drawing.Point(120, 5);
            this.BtExcluirPedido.Name = "BtExcluirPedido";
            this.BtExcluirPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtExcluirPedido.Size = new System.Drawing.Size(46, 52);
            this.BtExcluirPedido.TabIndex = 8;
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
            this.BtEditarPedido.Location = new System.Drawing.Point(68, 5);
            this.BtEditarPedido.Name = "BtEditarPedido";
            this.BtEditarPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtEditarPedido.Size = new System.Drawing.Size(46, 52);
            this.BtEditarPedido.TabIndex = 7;
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
            this.BtIncluirPedido.Location = new System.Drawing.Point(16, 5);
            this.BtIncluirPedido.Name = "BtIncluirPedido";
            this.BtIncluirPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtIncluirPedido.Size = new System.Drawing.Size(46, 52);
            this.BtIncluirPedido.TabIndex = 6;
            this.BtIncluirPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtIncluirPedido.UseVisualStyleBackColor = false;
            this.BtIncluirPedido.Click += new System.EventHandler(this.BtIncluirPedido_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(876, 70);
            this.panel4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastro de Pedidos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 70);
            this.panel2.TabIndex = 2;
            // 
            // nCliente
            // 
            this.nCliente.DataPropertyName = "nCliente";
            this.nCliente.HeaderText = "Cliente";
            this.nCliente.Name = "nCliente";
            this.nCliente.Width = 180;
            // 
            // data
            // 
            this.data.DataPropertyName = "datapedido";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.data.DefaultCellStyle = dataGridViewCellStyle1;
            this.data.HeaderText = "Data Pedido";
            this.data.Name = "data";
            this.data.Width = 95;
            // 
            // dataentrega
            // 
            this.dataentrega.DataPropertyName = "dataentrega";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dataentrega.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataentrega.HeaderText = "Data Entrega";
            this.dataentrega.Name = "dataentrega";
            this.dataentrega.Width = 95;
            // 
            // totalPedido
            // 
            this.totalPedido.DataPropertyName = "totalcompra";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.totalPedido.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalPedido.HeaderText = "Valor Pedido";
            this.totalPedido.Name = "totalPedido";
            this.totalPedido.Width = 95;
            // 
            // vlrlucro
            // 
            this.vlrlucro.DataPropertyName = "vlrlucro";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.vlrlucro.DefaultCellStyle = dataGridViewCellStyle4;
            this.vlrlucro.HeaderText = "Lucro Pedido";
            this.vlrlucro.Name = "vlrlucro";
            this.vlrlucro.Width = 95;
            // 
            // valorcompra
            // 
            this.valorcompra.DataPropertyName = "valorCompra";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.valorcompra.DefaultCellStyle = dataGridViewCellStyle5;
            this.valorcompra.HeaderText = "Vlr. Compra";
            this.valorcompra.Name = "valorcompra";
            this.valorcompra.Width = 95;
            // 
            // status
            // 
            this.status.DataPropertyName = "statuspedido";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.status.DefaultCellStyle = dataGridViewCellStyle6;
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
            // ID
            // 
            this.ID.DataPropertyName = "id_recno";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 661);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyHortifruti - Pedidos";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker DtFim;
        private System.Windows.Forms.DateTimePicker DtInicio;
        private Componentes.AltTextBox tbFiltro;
        private Componentes.AltComboBox cbFiltro;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtSairPedido;
        private System.Windows.Forms.Button btImprimirPedido;
        private System.Windows.Forms.Button BtExcluirPedido;
        private System.Windows.Forms.Button BtEditarPedido;
        private System.Windows.Forms.Button BtIncluirPedido;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView DgvPedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrlucro;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorcompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}