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
            this.panelCadPedidos = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtGridViewCadPedidos = new System.Windows.Forms.DataGridView();
            this.panelBotoesCadPedidos = new System.Windows.Forms.Panel();
            this.btSairPedido = new System.Windows.Forms.Button();
            this.btPesquisarPedido = new System.Windows.Forms.Button();
            this.btImprimirPedido = new System.Windows.Forms.Button();
            this.btExcluirPedido = new System.Windows.Forms.Button();
            this.btEditarPedido = new System.Windows.Forms.Button();
            this.btIncluirPedido = new System.Windows.Forms.Button();
            this.panelTituloCadPedidos = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelCadPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewCadPedidos)).BeginInit();
            this.panelBotoesCadPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelCadPedidos);
            this.panel1.Controls.Add(this.panelBotoesCadPedidos);
            this.panel1.Controls.Add(this.panelTituloCadPedidos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 563);
            this.panel1.TabIndex = 0;
            // 
            // panelCadPedidos
            // 
            this.panelCadPedidos.Controls.Add(this.dataGridView1);
            this.panelCadPedidos.Controls.Add(this.dtGridViewCadPedidos);
            this.panelCadPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadPedidos.Location = new System.Drawing.Point(0, 119);
            this.panelCadPedidos.Name = "panelCadPedidos";
            this.panelCadPedidos.Size = new System.Drawing.Size(743, 444);
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 444);
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
            // dtGridViewCadPedidos
            // 
            this.dtGridViewCadPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewCadPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridViewCadPedidos.Location = new System.Drawing.Point(0, 0);
            this.dtGridViewCadPedidos.Name = "dtGridViewCadPedidos";
            this.dtGridViewCadPedidos.Size = new System.Drawing.Size(743, 444);
            this.dtGridViewCadPedidos.TabIndex = 0;
            // 
            // panelBotoesCadPedidos
            // 
            this.panelBotoesCadPedidos.Controls.Add(this.btSairPedido);
            this.panelBotoesCadPedidos.Controls.Add(this.btPesquisarPedido);
            this.panelBotoesCadPedidos.Controls.Add(this.btImprimirPedido);
            this.panelBotoesCadPedidos.Controls.Add(this.btExcluirPedido);
            this.panelBotoesCadPedidos.Controls.Add(this.btEditarPedido);
            this.panelBotoesCadPedidos.Controls.Add(this.btIncluirPedido);
            this.panelBotoesCadPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotoesCadPedidos.Location = new System.Drawing.Point(0, 58);
            this.panelBotoesCadPedidos.Name = "panelBotoesCadPedidos";
            this.panelBotoesCadPedidos.Size = new System.Drawing.Size(743, 61);
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
            this.btSairPedido.Location = new System.Drawing.Point(683, 3);
            this.btSairPedido.Name = "btSairPedido";
            this.btSairPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btSairPedido.Size = new System.Drawing.Size(46, 52);
            this.btSairPedido.TabIndex = 5;
            this.btSairPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSairPedido.UseVisualStyleBackColor = false;
            this.btSairPedido.Click += new System.EventHandler(this.btSairPedido_Click);
            // 
            // btPesquisarPedido
            // 
            this.btPesquisarPedido.BackColor = System.Drawing.Color.Transparent;
            this.btPesquisarPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPesquisarPedido.BackgroundImage")));
            this.btPesquisarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesquisarPedido.FlatAppearance.BorderSize = 0;
            this.btPesquisarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisarPedido.Location = new System.Drawing.Point(168, 4);
            this.btPesquisarPedido.Name = "btPesquisarPedido";
            this.btPesquisarPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btPesquisarPedido.Size = new System.Drawing.Size(46, 52);
            this.btPesquisarPedido.TabIndex = 4;
            this.btPesquisarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPesquisarPedido.UseVisualStyleBackColor = false;
            // 
            // btImprimirPedido
            // 
            this.btImprimirPedido.BackColor = System.Drawing.Color.Transparent;
            this.btImprimirPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btImprimirPedido.BackgroundImage")));
            this.btImprimirPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btImprimirPedido.FlatAppearance.BorderSize = 0;
            this.btImprimirPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImprimirPedido.Location = new System.Drawing.Point(220, 4);
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
            // panelTituloCadPedidos
            // 
            this.panelTituloCadPedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTituloCadPedidos.BackgroundImage")));
            this.panelTituloCadPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelTituloCadPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloCadPedidos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloCadPedidos.Name = "panelTituloCadPedidos";
            this.panelTituloCadPedidos.Size = new System.Drawing.Size(743, 58);
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
            this.panelCadPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewCadPedidos)).EndInit();
            this.panelBotoesCadPedidos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTituloCadPedidos;
        private System.Windows.Forms.Panel panelBotoesCadPedidos;
        private System.Windows.Forms.Button btSairPedido;
        private System.Windows.Forms.Button btPesquisarPedido;
        private System.Windows.Forms.Button btImprimirPedido;
        private System.Windows.Forms.Button btExcluirPedido;
        private System.Windows.Forms.Button btEditarPedido;
        private System.Windows.Forms.Button btIncluirPedido;
        private System.Windows.Forms.Panel panelCadPedidos;
        private System.Windows.Forms.DataGridView dtGridViewCadPedidos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}