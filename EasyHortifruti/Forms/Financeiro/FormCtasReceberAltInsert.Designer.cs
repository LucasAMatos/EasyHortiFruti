namespace EasyHortifruti.Forms.Financeiro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelCRTop1 = new System.Windows.Forms.Panel();
            this.PanelCRTop2 = new System.Windows.Forms.Panel();
            this.PanelCRTop3 = new System.Windows.Forms.Panel();
            this.CbCRDevedor = new EasyHortifruti.Componentes.AltComboBox();
            this.BtnCadGeral = new System.Windows.Forms.Button();
            this.TbCRVlrDocumento = new EasyHortifruti.Componentes.AltTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtCRVencimento = new System.Windows.Forms.DateTimePicker();
            this.PanelCRButtom = new System.Windows.Forms.Panel();
            this.LbIdCtaRecebtoInsert = new System.Windows.Forms.Label();
            this.BtGravarCRAltInsert = new System.Windows.Forms.Button();
            this.BtCancelarCRInserir = new System.Windows.Forms.Button();
            this.PanelCRTop4 = new System.Windows.Forms.Panel();
            this.TbCRDescricaoObs = new EasyHortifruti.Componentes.AltTextBox();
            this.PanelCRCentral = new System.Windows.Forms.Panel();
            this.PanelCRMultaJuros = new System.Windows.Forms.Panel();
            this.CbCRTpConta = new EasyHortifruti.Componentes.AltComboBox();
            this.CbCRTpDocumento = new EasyHortifruti.Componentes.AltComboBox();
            this.CbCRTpCobraJuros = new EasyHortifruti.Componentes.AltComboBox();
            this.TbCRPercentJuros = new EasyHortifruti.Componentes.AltTextBox();
            this.TbCRPercentMulta = new EasyHortifruti.Componentes.AltTextBox();
            this.CbCRJuros = new EasyHortifruti.Componentes.AltComboBox();
            this.CbCRMulta = new EasyHortifruti.Componentes.AltComboBox();
            this.panel1.SuspendLayout();
            this.PanelCRTop2.SuspendLayout();
            this.PanelCRTop3.SuspendLayout();
            this.PanelCRButtom.SuspendLayout();
            this.PanelCRTop4.SuspendLayout();
            this.PanelCRCentral.SuspendLayout();
            this.PanelCRMultaJuros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelCRCentral);
            this.panel1.Controls.Add(this.PanelCRTop4);
            this.panel1.Controls.Add(this.PanelCRButtom);
            this.panel1.Controls.Add(this.PanelCRTop3);
            this.panel1.Controls.Add(this.PanelCRTop2);
            this.panel1.Controls.Add(this.PanelCRTop1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 422);
            this.panel1.TabIndex = 0;
            // 
            // PanelCRTop1
            // 
            this.PanelCRTop1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelCRTop1.BackgroundImage")));
            this.PanelCRTop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelCRTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCRTop1.Location = new System.Drawing.Point(0, 0);
            this.PanelCRTop1.Name = "PanelCRTop1";
            this.PanelCRTop1.Size = new System.Drawing.Size(603, 36);
            this.PanelCRTop1.TabIndex = 0;
            // 
            // PanelCRTop2
            // 
            this.PanelCRTop2.Controls.Add(this.CbCRDevedor);
            this.PanelCRTop2.Controls.Add(this.BtnCadGeral);
            this.PanelCRTop2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCRTop2.Location = new System.Drawing.Point(0, 36);
            this.PanelCRTop2.Name = "PanelCRTop2";
            this.PanelCRTop2.Size = new System.Drawing.Size(603, 58);
            this.PanelCRTop2.TabIndex = 1;
            // 
            // PanelCRTop3
            // 
            this.PanelCRTop3.Controls.Add(this.TbCRVlrDocumento);
            this.PanelCRTop3.Controls.Add(this.label1);
            this.PanelCRTop3.Controls.Add(this.DtCRVencimento);
            this.PanelCRTop3.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCRTop3.Location = new System.Drawing.Point(0, 94);
            this.PanelCRTop3.Name = "PanelCRTop3";
            this.PanelCRTop3.Size = new System.Drawing.Size(603, 60);
            this.PanelCRTop3.TabIndex = 2;
            // 
            // CbCRDevedor
            // 
            this.CbCRDevedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CbCRDevedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CbCRDevedor.Caption = "Devedor";
            this.CbCRDevedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbCRDevedor.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCRDevedor.FormattingEnabled = true;
            this.CbCRDevedor.Location = new System.Drawing.Point(23, 10);
            this.CbCRDevedor.Name = "CbCRDevedor";
            this.CbCRDevedor.Obrigatorio = false;
            this.CbCRDevedor.SelectedIndex = -1;
            this.CbCRDevedor.SelectedItem = null;
            this.CbCRDevedor.SelectedText = "";
            this.CbCRDevedor.Size = new System.Drawing.Size(530, 44);
            this.CbCRDevedor.TabIndex = 27;
            // 
            // BtnCadGeral
            // 
            this.BtnCadGeral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCadGeral.BackColor = System.Drawing.Color.Transparent;
            this.BtnCadGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCadGeral.FlatAppearance.BorderSize = 0;
            this.BtnCadGeral.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadGeral.Image = ((System.Drawing.Image)(resources.GetObject("BtnCadGeral.Image")));
            this.BtnCadGeral.Location = new System.Drawing.Point(551, 24);
            this.BtnCadGeral.Name = "BtnCadGeral";
            this.BtnCadGeral.Size = new System.Drawing.Size(28, 26);
            this.BtnCadGeral.TabIndex = 26;
            this.BtnCadGeral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCadGeral.UseVisualStyleBackColor = false;
            // 
            // TbCRVlrDocumento
            // 
            this.TbCRVlrDocumento.Caption = "Vlr Documento";
            this.TbCRVlrDocumento.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCRVlrDocumento.FonteTexto = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCRVlrDocumento.Location = new System.Drawing.Point(206, 10);
            this.TbCRVlrDocumento.MaxLength = 32767;
            this.TbCRVlrDocumento.Multiline = true;
            this.TbCRVlrDocumento.Name = "TbCRVlrDocumento";
            this.TbCRVlrDocumento.Obrigatorio = false;
            this.TbCRVlrDocumento.ReadOnly = false;
            this.TbCRVlrDocumento.SelectionLength = 0;
            this.TbCRVlrDocumento.SelectionStart = 0;
            this.TbCRVlrDocumento.Size = new System.Drawing.Size(135, 40);
            this.TbCRVlrDocumento.TabIndex = 5;
            this.TbCRVlrDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbCRVlrDocumento.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vencimento";
            // 
            // DtCRVencimento
            // 
            this.DtCRVencimento.CalendarFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtCRVencimento.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtCRVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtCRVencimento.Location = new System.Drawing.Point(23, 24);
            this.DtCRVencimento.Name = "DtCRVencimento";
            this.DtCRVencimento.Size = new System.Drawing.Size(126, 25);
            this.DtCRVencimento.TabIndex = 3;
            // 
            // PanelCRButtom
            // 
            this.PanelCRButtom.Controls.Add(this.LbIdCtaRecebtoInsert);
            this.PanelCRButtom.Controls.Add(this.BtGravarCRAltInsert);
            this.PanelCRButtom.Controls.Add(this.BtCancelarCRInserir);
            this.PanelCRButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelCRButtom.Location = new System.Drawing.Point(0, 364);
            this.PanelCRButtom.Name = "PanelCRButtom";
            this.PanelCRButtom.Size = new System.Drawing.Size(603, 58);
            this.PanelCRButtom.TabIndex = 3;
            // 
            // LbIdCtaRecebtoInsert
            // 
            this.LbIdCtaRecebtoInsert.AutoSize = true;
            this.LbIdCtaRecebtoInsert.BackColor = System.Drawing.Color.Transparent;
            this.LbIdCtaRecebtoInsert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbIdCtaRecebtoInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIdCtaRecebtoInsert.ForeColor = System.Drawing.Color.Black;
            this.LbIdCtaRecebtoInsert.Location = new System.Drawing.Point(12, 18);
            this.LbIdCtaRecebtoInsert.Name = "LbIdCtaRecebtoInsert";
            this.LbIdCtaRecebtoInsert.Size = new System.Drawing.Size(30, 22);
            this.LbIdCtaRecebtoInsert.TabIndex = 16;
            this.LbIdCtaRecebtoInsert.Text = "ID";
            // 
            // BtGravarCRAltInsert
            // 
            this.BtGravarCRAltInsert.BackColor = System.Drawing.Color.Transparent;
            this.BtGravarCRAltInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtGravarCRAltInsert.BackgroundImage")));
            this.BtGravarCRAltInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtGravarCRAltInsert.FlatAppearance.BorderSize = 0;
            this.BtGravarCRAltInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtGravarCRAltInsert.Location = new System.Drawing.Point(397, 14);
            this.BtGravarCRAltInsert.Name = "BtGravarCRAltInsert";
            this.BtGravarCRAltInsert.Size = new System.Drawing.Size(94, 30);
            this.BtGravarCRAltInsert.TabIndex = 15;
            this.BtGravarCRAltInsert.UseVisualStyleBackColor = false;
            // 
            // BtCancelarCRInserir
            // 
            this.BtCancelarCRInserir.BackColor = System.Drawing.Color.Transparent;
            this.BtCancelarCRInserir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtCancelarCRInserir.BackgroundImage")));
            this.BtCancelarCRInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtCancelarCRInserir.FlatAppearance.BorderSize = 0;
            this.BtCancelarCRInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancelarCRInserir.Location = new System.Drawing.Point(497, 14);
            this.BtCancelarCRInserir.Name = "BtCancelarCRInserir";
            this.BtCancelarCRInserir.Size = new System.Drawing.Size(94, 30);
            this.BtCancelarCRInserir.TabIndex = 14;
            this.BtCancelarCRInserir.UseVisualStyleBackColor = false;
            // 
            // PanelCRTop4
            // 
            this.PanelCRTop4.Controls.Add(this.TbCRDescricaoObs);
            this.PanelCRTop4.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCRTop4.Location = new System.Drawing.Point(0, 154);
            this.PanelCRTop4.Name = "PanelCRTop4";
            this.PanelCRTop4.Size = new System.Drawing.Size(603, 67);
            this.PanelCRTop4.TabIndex = 4;
            // 
            // TbCRDescricaoObs
            // 
            this.TbCRDescricaoObs.Caption = "Descrição / Observações do Documento";
            this.TbCRDescricaoObs.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCRDescricaoObs.FonteTexto = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCRDescricaoObs.Location = new System.Drawing.Point(25, 3);
            this.TbCRDescricaoObs.MaxLength = 32767;
            this.TbCRDescricaoObs.Multiline = true;
            this.TbCRDescricaoObs.Name = "TbCRDescricaoObs";
            this.TbCRDescricaoObs.Obrigatorio = false;
            this.TbCRDescricaoObs.ReadOnly = false;
            this.TbCRDescricaoObs.SelectionLength = 0;
            this.TbCRDescricaoObs.SelectionStart = 0;
            this.TbCRDescricaoObs.Size = new System.Drawing.Size(553, 54);
            this.TbCRDescricaoObs.TabIndex = 1;
            this.TbCRDescricaoObs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbCRDescricaoObs.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // PanelCRCentral
            // 
            this.PanelCRCentral.Controls.Add(this.CbCRTpConta);
            this.PanelCRCentral.Controls.Add(this.CbCRTpDocumento);
            this.PanelCRCentral.Controls.Add(this.PanelCRMultaJuros);
            this.PanelCRCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCRCentral.Location = new System.Drawing.Point(0, 221);
            this.PanelCRCentral.Name = "PanelCRCentral";
            this.PanelCRCentral.Size = new System.Drawing.Size(603, 143);
            this.PanelCRCentral.TabIndex = 5;
            // 
            // PanelCRMultaJuros
            // 
            this.PanelCRMultaJuros.Controls.Add(this.CbCRTpCobraJuros);
            this.PanelCRMultaJuros.Controls.Add(this.TbCRPercentJuros);
            this.PanelCRMultaJuros.Controls.Add(this.TbCRPercentMulta);
            this.PanelCRMultaJuros.Controls.Add(this.CbCRJuros);
            this.PanelCRMultaJuros.Controls.Add(this.CbCRMulta);
            this.PanelCRMultaJuros.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelCRMultaJuros.Location = new System.Drawing.Point(290, 0);
            this.PanelCRMultaJuros.Name = "PanelCRMultaJuros";
            this.PanelCRMultaJuros.Size = new System.Drawing.Size(313, 143);
            this.PanelCRMultaJuros.TabIndex = 0;
            // 
            // CbCRTpConta
            // 
            this.CbCRTpConta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CbCRTpConta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CbCRTpConta.Caption = "Tipo Conta";
            this.CbCRTpConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbCRTpConta.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCRTpConta.FormattingEnabled = true;
            this.CbCRTpConta.Location = new System.Drawing.Point(25, 76);
            this.CbCRTpConta.Name = "CbCRTpConta";
            this.CbCRTpConta.Obrigatorio = false;
            this.CbCRTpConta.SelectedIndex = -1;
            this.CbCRTpConta.SelectedItem = null;
            this.CbCRTpConta.SelectedText = "";
            this.CbCRTpConta.Size = new System.Drawing.Size(189, 49);
            this.CbCRTpConta.TabIndex = 7;
            // 
            // CbCRTpDocumento
            // 
            this.CbCRTpDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CbCRTpDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CbCRTpDocumento.Caption = "Tipo Documento";
            this.CbCRTpDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbCRTpDocumento.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCRTpDocumento.FormattingEnabled = true;
            this.CbCRTpDocumento.Location = new System.Drawing.Point(25, 15);
            this.CbCRTpDocumento.Name = "CbCRTpDocumento";
            this.CbCRTpDocumento.Obrigatorio = false;
            this.CbCRTpDocumento.SelectedIndex = -1;
            this.CbCRTpDocumento.SelectedItem = null;
            this.CbCRTpDocumento.SelectedText = "";
            this.CbCRTpDocumento.Size = new System.Drawing.Size(189, 40);
            this.CbCRTpDocumento.TabIndex = 6;
            // 
            // CbCRTpCobraJuros
            // 
            this.CbCRTpCobraJuros.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CbCRTpCobraJuros.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CbCRTpCobraJuros.Caption = "";
            this.CbCRTpCobraJuros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbCRTpCobraJuros.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCRTpCobraJuros.FormattingEnabled = true;
            this.CbCRTpCobraJuros.Location = new System.Drawing.Point(202, 76);
            this.CbCRTpCobraJuros.Name = "CbCRTpCobraJuros";
            this.CbCRTpCobraJuros.Obrigatorio = false;
            this.CbCRTpCobraJuros.SelectedIndex = -1;
            this.CbCRTpCobraJuros.SelectedItem = null;
            this.CbCRTpCobraJuros.SelectedText = "";
            this.CbCRTpCobraJuros.Size = new System.Drawing.Size(84, 45);
            this.CbCRTpCobraJuros.TabIndex = 11;
            // 
            // TbCRPercentJuros
            // 
            this.TbCRPercentJuros.Caption = "%";
            this.TbCRPercentJuros.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCRPercentJuros.FonteTexto = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCRPercentJuros.Location = new System.Drawing.Point(143, 75);
            this.TbCRPercentJuros.MaxLength = 32767;
            this.TbCRPercentJuros.Multiline = true;
            this.TbCRPercentJuros.Name = "TbCRPercentJuros";
            this.TbCRPercentJuros.Obrigatorio = false;
            this.TbCRPercentJuros.ReadOnly = false;
            this.TbCRPercentJuros.SelectionLength = 0;
            this.TbCRPercentJuros.SelectionStart = 0;
            this.TbCRPercentJuros.Size = new System.Drawing.Size(53, 40);
            this.TbCRPercentJuros.TabIndex = 10;
            this.TbCRPercentJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbCRPercentJuros.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // TbCRPercentMulta
            // 
            this.TbCRPercentMulta.Caption = "%";
            this.TbCRPercentMulta.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCRPercentMulta.FonteTexto = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCRPercentMulta.Location = new System.Drawing.Point(143, 14);
            this.TbCRPercentMulta.MaxLength = 32767;
            this.TbCRPercentMulta.Multiline = true;
            this.TbCRPercentMulta.Name = "TbCRPercentMulta";
            this.TbCRPercentMulta.Obrigatorio = false;
            this.TbCRPercentMulta.ReadOnly = false;
            this.TbCRPercentMulta.SelectionLength = 0;
            this.TbCRPercentMulta.SelectionStart = 0;
            this.TbCRPercentMulta.Size = new System.Drawing.Size(53, 40);
            this.TbCRPercentMulta.TabIndex = 9;
            this.TbCRPercentMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbCRPercentMulta.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // CbCRJuros
            // 
            this.CbCRJuros.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CbCRJuros.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CbCRJuros.Caption = "Juros";
            this.CbCRJuros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbCRJuros.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCRJuros.FormattingEnabled = true;
            this.CbCRJuros.Location = new System.Drawing.Point(36, 76);
            this.CbCRJuros.Name = "CbCRJuros";
            this.CbCRJuros.Obrigatorio = false;
            this.CbCRJuros.SelectedIndex = -1;
            this.CbCRJuros.SelectedItem = null;
            this.CbCRJuros.SelectedText = "";
            this.CbCRJuros.Size = new System.Drawing.Size(101, 40);
            this.CbCRJuros.TabIndex = 8;
            // 
            // CbCRMulta
            // 
            this.CbCRMulta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CbCRMulta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CbCRMulta.Caption = "Multa";
            this.CbCRMulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbCRMulta.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCRMulta.FormattingEnabled = true;
            this.CbCRMulta.Location = new System.Drawing.Point(36, 15);
            this.CbCRMulta.Name = "CbCRMulta";
            this.CbCRMulta.Obrigatorio = false;
            this.CbCRMulta.SelectedIndex = -1;
            this.CbCRMulta.SelectedItem = null;
            this.CbCRMulta.SelectedText = "";
            this.CbCRMulta.Size = new System.Drawing.Size(101, 40);
            this.CbCRMulta.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 422);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.PanelCRTop2.ResumeLayout(false);
            this.PanelCRTop3.ResumeLayout(false);
            this.PanelCRTop3.PerformLayout();
            this.PanelCRButtom.ResumeLayout(false);
            this.PanelCRButtom.PerformLayout();
            this.PanelCRTop4.ResumeLayout(false);
            this.PanelCRCentral.ResumeLayout(false);
            this.PanelCRMultaJuros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelCRTop1;
        private System.Windows.Forms.Panel PanelCRTop3;
        private System.Windows.Forms.Panel PanelCRTop2;
        private Componentes.AltComboBox CbCRDevedor;
        private System.Windows.Forms.Button BtnCadGeral;
        private System.Windows.Forms.Panel PanelCRButtom;
        private Componentes.AltTextBox TbCRVlrDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtCRVencimento;
        private System.Windows.Forms.Label LbIdCtaRecebtoInsert;
        private System.Windows.Forms.Button BtGravarCRAltInsert;
        private System.Windows.Forms.Button BtCancelarCRInserir;
        private System.Windows.Forms.Panel PanelCRTop4;
        private Componentes.AltTextBox TbCRDescricaoObs;
        private System.Windows.Forms.Panel PanelCRCentral;
        private System.Windows.Forms.Panel PanelCRMultaJuros;
        private Componentes.AltComboBox CbCRTpConta;
        private Componentes.AltComboBox CbCRTpDocumento;
        private Componentes.AltComboBox CbCRTpCobraJuros;
        private Componentes.AltTextBox TbCRPercentJuros;
        private Componentes.AltTextBox TbCRPercentMulta;
        private Componentes.AltComboBox CbCRJuros;
        private Componentes.AltComboBox CbCRMulta;
    }
}