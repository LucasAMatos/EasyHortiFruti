using EasyHortifruti.Componentes;

namespace EasyHortifruti
{
    partial class FormCtasReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCtasReceber));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6CtasReceber = new System.Windows.Forms.Panel();
            this.dtGridViewCtasReceber = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10CtasReceber = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9CtasReceber = new System.Windows.Forms.Panel();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQtdPedido = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8CtasReceber = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7CtasReceber = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5CtasReceberBotoes = new System.Windows.Forms.Panel();
            this.BtBaixaCtaRecebto = new System.Windows.Forms.Button();
            this.BtImprimirCtaRecebto = new System.Windows.Forms.Button();
            this.BtExcluirCtaRecebto = new System.Windows.Forms.Button();
            this.BtEditarCtaRecebto = new System.Windows.Forms.Button();
            this.BtIncluirCtaRecebto = new System.Windows.Forms.Button();
            this.panel3CtasReceberFiltros = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.DateFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DataInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTituloCtasReceber = new System.Windows.Forms.Panel();
            this.btSairCtasReceber = new System.Windows.Forms.Button();
            this.id_recno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_fonte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrlucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataconclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstBoxHoje = new System.Windows.Forms.ListBox();
            this.lstBoxProxSemana = new System.Windows.Forms.ListBox();
            this.CbFiltroCliente = new EasyHortifruti.Componentes.AltComboBox();
            this.CbFiltroSituação = new EasyHortifruti.Componentes.AltComboBox();
            this.panel1.SuspendLayout();
            this.panel6CtasReceber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewCtasReceber)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel10CtasReceber.SuspendLayout();
            this.panel9CtasReceber.SuspendLayout();
            this.panel8CtasReceber.SuspendLayout();
            this.panel7CtasReceber.SuspendLayout();
            this.panel5CtasReceberBotoes.SuspendLayout();
            this.panel3CtasReceberFiltros.SuspendLayout();
            this.panelTituloCtasReceber.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6CtasReceber);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5CtasReceberBotoes);
            this.panel1.Controls.Add(this.panel3CtasReceberFiltros);
            this.panel1.Controls.Add(this.panelTituloCtasReceber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 701);
            this.panel1.TabIndex = 0;
            // 
            // panel6CtasReceber
            // 
            this.panel6CtasReceber.Controls.Add(this.dtGridViewCtasReceber);
            this.panel6CtasReceber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6CtasReceber.Location = new System.Drawing.Point(161, 206);
            this.panel6CtasReceber.Name = "panel6CtasReceber";
            this.panel6CtasReceber.Size = new System.Drawing.Size(834, 495);
            this.panel6CtasReceber.TabIndex = 5;
            // 
            // dtGridViewCtasReceber
            // 
            this.dtGridViewCtasReceber.AllowUserToAddRows = false;
            this.dtGridViewCtasReceber.AllowUserToDeleteRows = false;
            this.dtGridViewCtasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewCtasReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_recno,
            this.dataentrega,
            this.id_fonte,
            this.totalvenda,
            this.vlrlucro,
            this.dataconclusao});
            this.dtGridViewCtasReceber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridViewCtasReceber.Location = new System.Drawing.Point(0, 0);
            this.dtGridViewCtasReceber.Name = "dtGridViewCtasReceber";
            this.dtGridViewCtasReceber.Size = new System.Drawing.Size(834, 495);
            this.dtGridViewCtasReceber.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel10CtasReceber);
            this.panel4.Controls.Add(this.panel9CtasReceber);
            this.panel4.Controls.Add(this.panel8CtasReceber);
            this.panel4.Controls.Add(this.panel7CtasReceber);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 206);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(161, 495);
            this.panel4.TabIndex = 4;
            // 
            // panel10CtasReceber
            // 
            this.panel10CtasReceber.Controls.Add(this.lstBoxProxSemana);
            this.panel10CtasReceber.Controls.Add(this.label10);
            this.panel10CtasReceber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10CtasReceber.Location = new System.Drawing.Point(0, 218);
            this.panel10CtasReceber.Name = "panel10CtasReceber";
            this.panel10CtasReceber.Size = new System.Drawing.Size(161, 188);
            this.panel10CtasReceber.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "A vencer próxima semana";
            // 
            // panel9CtasReceber
            // 
            this.panel9CtasReceber.Controls.Add(this.lblValor);
            this.panel9CtasReceber.Controls.Add(this.lblQtdPedido);
            this.panel9CtasReceber.Controls.Add(this.label7);
            this.panel9CtasReceber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9CtasReceber.Location = new System.Drawing.Point(0, 406);
            this.panel9CtasReceber.Name = "panel9CtasReceber";
            this.panel9CtasReceber.Size = new System.Drawing.Size(161, 89);
            this.panel9CtasReceber.TabIndex = 2;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(94, 32);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor";
            // 
            // lblQtdPedido
            // 
            this.lblQtdPedido.AutoSize = true;
            this.lblQtdPedido.Location = new System.Drawing.Point(15, 32);
            this.lblQtdPedido.Name = "lblQtdPedido";
            this.lblQtdPedido.Size = new System.Drawing.Size(47, 13);
            this.lblQtdPedido.TabIndex = 1;
            this.lblQtdPedido.Text = "? nº ped";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Geral";
            // 
            // panel8CtasReceber
            // 
            this.panel8CtasReceber.Controls.Add(this.lstBoxHoje);
            this.panel8CtasReceber.Controls.Add(this.label11);
            this.panel8CtasReceber.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8CtasReceber.Location = new System.Drawing.Point(0, 23);
            this.panel8CtasReceber.Name = "panel8CtasReceber";
            this.panel8CtasReceber.Size = new System.Drawing.Size(161, 195);
            this.panel8CtasReceber.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Vencendo Hoje";
            // 
            // panel7CtasReceber
            // 
            this.panel7CtasReceber.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7CtasReceber.Controls.Add(this.label6);
            this.panel7CtasReceber.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7CtasReceber.Location = new System.Drawing.Point(0, 0);
            this.panel7CtasReceber.Name = "panel7CtasReceber";
            this.panel7CtasReceber.Size = new System.Drawing.Size(161, 23);
            this.panel7CtasReceber.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Resumo (Saldo)";
            // 
            // panel5CtasReceberBotoes
            // 
            this.panel5CtasReceberBotoes.Controls.Add(this.BtBaixaCtaRecebto);
            this.panel5CtasReceberBotoes.Controls.Add(this.BtImprimirCtaRecebto);
            this.panel5CtasReceberBotoes.Controls.Add(this.BtExcluirCtaRecebto);
            this.panel5CtasReceberBotoes.Controls.Add(this.BtEditarCtaRecebto);
            this.panel5CtasReceberBotoes.Controls.Add(this.BtIncluirCtaRecebto);
            this.panel5CtasReceberBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5CtasReceberBotoes.Location = new System.Drawing.Point(0, 145);
            this.panel5CtasReceberBotoes.Name = "panel5CtasReceberBotoes";
            this.panel5CtasReceberBotoes.Size = new System.Drawing.Size(995, 61);
            this.panel5CtasReceberBotoes.TabIndex = 3;
            // 
            // BtBaixaCtaRecebto
            // 
            this.BtBaixaCtaRecebto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtBaixaCtaRecebto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtBaixaCtaRecebto.BackgroundImage")));
            this.BtBaixaCtaRecebto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtBaixaCtaRecebto.FlatAppearance.BorderSize = 0;
            this.BtBaixaCtaRecebto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBaixaCtaRecebto.Location = new System.Drawing.Point(226, 5);
            this.BtBaixaCtaRecebto.Name = "BtBaixaCtaRecebto";
            this.BtBaixaCtaRecebto.Size = new System.Drawing.Size(56, 49);
            this.BtBaixaCtaRecebto.TabIndex = 5;
            this.BtBaixaCtaRecebto.UseVisualStyleBackColor = true;
            // 
            // BtImprimirCtaRecebto
            // 
            this.BtImprimirCtaRecebto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtImprimirCtaRecebto.BackColor = System.Drawing.Color.Transparent;
            this.BtImprimirCtaRecebto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtImprimirCtaRecebto.BackgroundImage")));
            this.BtImprimirCtaRecebto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtImprimirCtaRecebto.FlatAppearance.BorderSize = 0;
            this.BtImprimirCtaRecebto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtImprimirCtaRecebto.Location = new System.Drawing.Point(174, 3);
            this.BtImprimirCtaRecebto.Name = "BtImprimirCtaRecebto";
            this.BtImprimirCtaRecebto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtImprimirCtaRecebto.Size = new System.Drawing.Size(47, 52);
            this.BtImprimirCtaRecebto.TabIndex = 3;
            this.BtImprimirCtaRecebto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtImprimirCtaRecebto.UseVisualStyleBackColor = false;
            // 
            // BtExcluirCtaRecebto
            // 
            this.BtExcluirCtaRecebto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtExcluirCtaRecebto.BackColor = System.Drawing.Color.Transparent;
            this.BtExcluirCtaRecebto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtExcluirCtaRecebto.BackgroundImage")));
            this.BtExcluirCtaRecebto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtExcluirCtaRecebto.FlatAppearance.BorderSize = 0;
            this.BtExcluirCtaRecebto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExcluirCtaRecebto.Location = new System.Drawing.Point(121, 3);
            this.BtExcluirCtaRecebto.Name = "BtExcluirCtaRecebto";
            this.BtExcluirCtaRecebto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtExcluirCtaRecebto.Size = new System.Drawing.Size(47, 52);
            this.BtExcluirCtaRecebto.TabIndex = 2;
            this.BtExcluirCtaRecebto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtExcluirCtaRecebto.UseVisualStyleBackColor = false;
            // 
            // BtEditarCtaRecebto
            // 
            this.BtEditarCtaRecebto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtEditarCtaRecebto.BackColor = System.Drawing.Color.Transparent;
            this.BtEditarCtaRecebto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtEditarCtaRecebto.BackgroundImage")));
            this.BtEditarCtaRecebto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEditarCtaRecebto.FlatAppearance.BorderSize = 0;
            this.BtEditarCtaRecebto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEditarCtaRecebto.Location = new System.Drawing.Point(66, 3);
            this.BtEditarCtaRecebto.Name = "BtEditarCtaRecebto";
            this.BtEditarCtaRecebto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtEditarCtaRecebto.Size = new System.Drawing.Size(47, 52);
            this.BtEditarCtaRecebto.TabIndex = 1;
            this.BtEditarCtaRecebto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEditarCtaRecebto.UseVisualStyleBackColor = false;
            // 
            // BtIncluirCtaRecebto
            // 
            this.BtIncluirCtaRecebto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtIncluirCtaRecebto.BackColor = System.Drawing.Color.Transparent;
            this.BtIncluirCtaRecebto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtIncluirCtaRecebto.BackgroundImage")));
            this.BtIncluirCtaRecebto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtIncluirCtaRecebto.FlatAppearance.BorderSize = 0;
            this.BtIncluirCtaRecebto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtIncluirCtaRecebto.Location = new System.Drawing.Point(8, 3);
            this.BtIncluirCtaRecebto.Name = "BtIncluirCtaRecebto";
            this.BtIncluirCtaRecebto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtIncluirCtaRecebto.Size = new System.Drawing.Size(50, 52);
            this.BtIncluirCtaRecebto.TabIndex = 0;
            this.BtIncluirCtaRecebto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtIncluirCtaRecebto.UseVisualStyleBackColor = false;
            // 
            // panel3CtasReceberFiltros
            // 
            this.panel3CtasReceberFiltros.Controls.Add(this.CbFiltroCliente);
            this.panel3CtasReceberFiltros.Controls.Add(this.CbFiltroSituação);
            this.panel3CtasReceberFiltros.Controls.Add(this.label4);
            this.panel3CtasReceberFiltros.Controls.Add(this.DateFinal);
            this.panel3CtasReceberFiltros.Controls.Add(this.label3);
            this.panel3CtasReceberFiltros.Controls.Add(this.DataInicio);
            this.panel3CtasReceberFiltros.Controls.Add(this.label1);
            this.panel3CtasReceberFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3CtasReceberFiltros.Location = new System.Drawing.Point(0, 76);
            this.panel3CtasReceberFiltros.Name = "panel3CtasReceberFiltros";
            this.panel3CtasReceberFiltros.Size = new System.Drawing.Size(995, 69);
            this.panel3CtasReceberFiltros.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Final";
            // 
            // DateFinal
            // 
            this.DateFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFinal.Location = new System.Drawing.Point(431, 35);
            this.DateFinal.Name = "DateFinal";
            this.DateFinal.Size = new System.Drawing.Size(110, 24);
            this.DateFinal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Início";
            // 
            // DataInicio
            // 
            this.DataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataInicio.Location = new System.Drawing.Point(282, 35);
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Size = new System.Drawing.Size(111, 24);
            this.DataInicio.TabIndex = 3;
            this.DataInicio.Value = new System.DateTime(2024, 3, 21, 10, 44, 8, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro";
            // 
            // panelTituloCtasReceber
            // 
            this.panelTituloCtasReceber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTituloCtasReceber.BackgroundImage")));
            this.panelTituloCtasReceber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTituloCtasReceber.Controls.Add(this.btSairCtasReceber);
            this.panelTituloCtasReceber.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloCtasReceber.Location = new System.Drawing.Point(0, 0);
            this.panelTituloCtasReceber.Name = "panelTituloCtasReceber";
            this.panelTituloCtasReceber.Size = new System.Drawing.Size(995, 76);
            this.panelTituloCtasReceber.TabIndex = 0;
            // 
            // btSairCtasReceber
            // 
            this.btSairCtasReceber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSairCtasReceber.BackColor = System.Drawing.Color.Transparent;
            this.btSairCtasReceber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSairCtasReceber.BackgroundImage")));
            this.btSairCtasReceber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSairCtasReceber.FlatAppearance.BorderSize = 0;
            this.btSairCtasReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSairCtasReceber.Location = new System.Drawing.Point(931, 12);
            this.btSairCtasReceber.Name = "btSairCtasReceber";
            this.btSairCtasReceber.Size = new System.Drawing.Size(50, 46);
            this.btSairCtasReceber.TabIndex = 0;
            this.btSairCtasReceber.UseVisualStyleBackColor = false;
            this.btSairCtasReceber.Click += new System.EventHandler(this.BtSairCtasReceber_Click);
            // 
            // id_recno
            // 
            this.id_recno.DataPropertyName = "id_recno";
            this.id_recno.HeaderText = "Nº Pedido";
            this.id_recno.Name = "id_recno";
            // 
            // dataentrega
            // 
            this.dataentrega.DataPropertyName = "dataentrega";
            this.dataentrega.HeaderText = "Vencimento";
            this.dataentrega.Name = "dataentrega";
            // 
            // id_fonte
            // 
            this.id_fonte.DataPropertyName = "id_fonte";
            this.id_fonte.HeaderText = "Cliente";
            this.id_fonte.Name = "id_fonte";
            this.id_fonte.Width = 200;
            // 
            // totalvenda
            // 
            this.totalvenda.DataPropertyName = "totalvenda";
            this.totalvenda.HeaderText = "Valor Pedido";
            this.totalvenda.Name = "totalvenda";
            // 
            // vlrlucro
            // 
            this.vlrlucro.DataPropertyName = "vlrlucro";
            this.vlrlucro.HeaderText = "% Lucro";
            this.vlrlucro.Name = "vlrlucro";
            // 
            // dataconclusao
            // 
            this.dataconclusao.DataPropertyName = "dataconclusao";
            this.dataconclusao.HeaderText = "Data Recebto";
            this.dataconclusao.Name = "dataconclusao";
            // 
            // lstBoxHoje
            // 
            this.lstBoxHoje.FormattingEnabled = true;
            this.lstBoxHoje.Location = new System.Drawing.Point(18, 23);
            this.lstBoxHoje.Name = "lstBoxHoje";
            this.lstBoxHoje.Size = new System.Drawing.Size(120, 147);
            this.lstBoxHoje.TabIndex = 3;
            // 
            // lstBoxProxSemana
            // 
            this.lstBoxProxSemana.FormattingEnabled = true;
            this.lstBoxProxSemana.Location = new System.Drawing.Point(18, 25);
            this.lstBoxProxSemana.Name = "lstBoxProxSemana";
            this.lstBoxProxSemana.Size = new System.Drawing.Size(120, 147);
            this.lstBoxProxSemana.TabIndex = 4;
            // 
            // CbFiltroCliente
            // 
            this.CbFiltroCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CbFiltroCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CbFiltroCliente.Caption = "Cliente";
            this.CbFiltroCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbFiltroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CbFiltroCliente.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.CbFiltroCliente.FormattingEnabled = true;
            this.CbFiltroCliente.Location = new System.Drawing.Point(15, 18);
            this.CbFiltroCliente.Margin = new System.Windows.Forms.Padding(4);
            this.CbFiltroCliente.Name = "CbFiltroCliente";
            this.CbFiltroCliente.Obrigatorio = false;
            this.CbFiltroCliente.SelectedIndex = -1;
            this.CbFiltroCliente.SelectedItem = null;
            this.CbFiltroCliente.SelectedText = "";
            this.CbFiltroCliente.Size = new System.Drawing.Size(230, 42);
            this.CbFiltroCliente.TabIndex = 2;
            // 
            // CbFiltroSituação
            // 
            this.CbFiltroSituação.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CbFiltroSituação.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CbFiltroSituação.Caption = "Situação";
            this.CbFiltroSituação.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbFiltroSituação.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CbFiltroSituação.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.CbFiltroSituação.FormattingEnabled = true;
            this.CbFiltroSituação.Location = new System.Drawing.Point(576, 18);
            this.CbFiltroSituação.Margin = new System.Windows.Forms.Padding(4);
            this.CbFiltroSituação.Name = "CbFiltroSituação";
            this.CbFiltroSituação.Obrigatorio = false;
            this.CbFiltroSituação.SelectedIndex = -1;
            this.CbFiltroSituação.SelectedItem = null;
            this.CbFiltroSituação.SelectedText = "";
            this.CbFiltroSituação.Size = new System.Drawing.Size(181, 42);
            this.CbFiltroSituação.TabIndex = 9;
            // 
            // FormCtasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 701);
            this.Controls.Add(this.panel1);
            this.Name = "FormCtasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyHortifruti - Contas a Receber";
            this.Load += new System.EventHandler(this.FormCtasReceber_Load);
            this.panel1.ResumeLayout(false);
            this.panel6CtasReceber.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewCtasReceber)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel10CtasReceber.ResumeLayout(false);
            this.panel10CtasReceber.PerformLayout();
            this.panel9CtasReceber.ResumeLayout(false);
            this.panel9CtasReceber.PerformLayout();
            this.panel8CtasReceber.ResumeLayout(false);
            this.panel8CtasReceber.PerformLayout();
            this.panel7CtasReceber.ResumeLayout(false);
            this.panel7CtasReceber.PerformLayout();
            this.panel5CtasReceberBotoes.ResumeLayout(false);
            this.panel3CtasReceberFiltros.ResumeLayout(false);
            this.panel3CtasReceberFiltros.PerformLayout();
            this.panelTituloCtasReceber.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTituloCtasReceber;
        private System.Windows.Forms.Panel panel3CtasReceberFiltros;
        private System.Windows.Forms.Label label1;
        private AltComboBox CbFiltroSituação;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DataInicio;
        private AltComboBox CbFiltroCliente;
        private System.Windows.Forms.Button btSairCtasReceber;
        private System.Windows.Forms.Panel panel5CtasReceberBotoes;
        private System.Windows.Forms.Button BtImprimirCtaRecebto;
        private System.Windows.Forms.Button BtExcluirCtaRecebto;
        private System.Windows.Forms.Button BtEditarCtaRecebto;
        private System.Windows.Forms.Button BtIncluirCtaRecebto;
        private System.Windows.Forms.Panel panel6CtasReceber;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtBaixaCtaRecebto;
        private System.Windows.Forms.DataGridView dtGridViewCtasReceber;
        private System.Windows.Forms.Panel panel9CtasReceber;
        private System.Windows.Forms.Panel panel8CtasReceber;
        private System.Windows.Forms.Panel panel7CtasReceber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel10CtasReceber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQtdPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_recno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fonte;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalvenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrlucro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataconclusao;
        private System.Windows.Forms.ListBox lstBoxProxSemana;
        private System.Windows.Forms.ListBox lstBoxHoje;
    }
}