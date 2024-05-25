namespace EasyHortifruti.Forms.Produtos
{
    partial class FormAlterarPrecoCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarPrecoCompra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DgvListaProdutos = new System.Windows.Forms.DataGridView();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ibunidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ibgrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ibsubgrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoratual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrAlterado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margem_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_recno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtGravarAltPreco = new System.Windows.Forms.Button();
            this.BtCancelGrupo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtImprimirGrupo = new System.Windows.Forms.Button();
            this.BtEditarGrupo = new System.Windows.Forms.Button();
            this.CbFiltraProdutos = new EasyHortifruti.Componentes.AltComboBox();
            this.CbFiltraSubGrupo = new EasyHortifruti.Componentes.AltComboBox();
            this.CbFiltraGrupo = new EasyHortifruti.Componentes.AltComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProdutos)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 622);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.DgvListaProdutos);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 135);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(745, 440);
            this.panel7.TabIndex = 4;
            // 
            // DgvListaProdutos
            // 
            this.DgvListaProdutos.AllowUserToAddRows = false;
            this.DgvListaProdutos.AllowUserToDeleteRows = false;
            this.DgvListaProdutos.AllowUserToResizeRows = false;
            this.DgvListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.Ibunidade,
            this.Ibgrupo,
            this.Ibsubgrupo,
            this.valoratual,
            this.vlrAlterado,
            this.margem_produto,
            this.id_recno,
            this.ValorVenda});
            this.DgvListaProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListaProdutos.Location = new System.Drawing.Point(0, 0);
            this.DgvListaProdutos.Name = "DgvListaProdutos";
            this.DgvListaProdutos.Size = new System.Drawing.Size(745, 440);
            this.DgvListaProdutos.TabIndex = 0;
            this.DgvListaProdutos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaProdutos_CellEndEdit);
            this.DgvListaProdutos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvListaProdutos_EditingControlShowing);
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "nome_produto";
            this.Descricao.HeaderText = "Descrição Produto";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 200;
            // 
            // Ibunidade
            // 
            this.Ibunidade.DataPropertyName = "abrev_unid";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Ibunidade.DefaultCellStyle = dataGridViewCellStyle1;
            this.Ibunidade.HeaderText = "Unidade";
            this.Ibunidade.Name = "Ibunidade";
            this.Ibunidade.ReadOnly = true;
            this.Ibunidade.Width = 65;
            // 
            // Ibgrupo
            // 
            this.Ibgrupo.DataPropertyName = "nome_grupo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Ibgrupo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Ibgrupo.HeaderText = "Grupo";
            this.Ibgrupo.Name = "Ibgrupo";
            this.Ibgrupo.ReadOnly = true;
            // 
            // Ibsubgrupo
            // 
            this.Ibsubgrupo.DataPropertyName = "nome_subgrupo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Ibsubgrupo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Ibsubgrupo.HeaderText = "SubGrupo";
            this.Ibsubgrupo.Name = "Ibsubgrupo";
            this.Ibsubgrupo.ReadOnly = true;
            // 
            // valoratual
            // 
            this.valoratual.DataPropertyName = "pcocompra_produto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.valoratual.DefaultCellStyle = dataGridViewCellStyle4;
            this.valoratual.HeaderText = "R$ Atual";
            this.valoratual.Name = "valoratual";
            this.valoratual.ReadOnly = true;
            this.valoratual.Width = 80;
            // 
            // vlrAlterado
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            this.vlrAlterado.DefaultCellStyle = dataGridViewCellStyle5;
            this.vlrAlterado.HeaderText = "R$ Alterar";
            this.vlrAlterado.Name = "vlrAlterado";
            this.vlrAlterado.ToolTipText = "Digite Para Alterar";
            this.vlrAlterado.Width = 80;
            // 
            // margem_produto
            // 
            this.margem_produto.DataPropertyName = "margem_produto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.margem_produto.DefaultCellStyle = dataGridViewCellStyle6;
            this.margem_produto.HeaderText = "% Lucro";
            this.margem_produto.Name = "margem_produto";
            this.margem_produto.Width = 70;
            // 
            // id_recno
            // 
            this.id_recno.DataPropertyName = "id_recno";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id_recno.DefaultCellStyle = dataGridViewCellStyle7;
            this.id_recno.HeaderText = "ID";
            this.id_recno.Name = "id_recno";
            this.id_recno.ReadOnly = true;
            this.id_recno.Visible = false;
            this.id_recno.Width = 60;
            // 
            // ValorVenda
            // 
            this.ValorVenda.DataPropertyName = "pcovenda_produto";
            this.ValorVenda.HeaderText = "VlrVenda";
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.BtGravarAltPreco);
            this.panel6.Controls.Add(this.BtCancelGrupo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 575);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(745, 47);
            this.panel6.TabIndex = 3;
            // 
            // BtGravarAltPreco
            // 
            this.BtGravarAltPreco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtGravarAltPreco.BackColor = System.Drawing.Color.Transparent;
            this.BtGravarAltPreco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtGravarAltPreco.BackgroundImage")));
            this.BtGravarAltPreco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtGravarAltPreco.FlatAppearance.BorderSize = 0;
            this.BtGravarAltPreco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtGravarAltPreco.Location = new System.Drawing.Point(539, 7);
            this.BtGravarAltPreco.Name = "BtGravarAltPreco";
            this.BtGravarAltPreco.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtGravarAltPreco.Size = new System.Drawing.Size(94, 32);
            this.BtGravarAltPreco.TabIndex = 14;
            this.BtGravarAltPreco.UseVisualStyleBackColor = false;
            this.BtGravarAltPreco.Click += new System.EventHandler(this.BtGravarAltPreco_Click);
            // 
            // BtCancelGrupo
            // 
            this.BtCancelGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtCancelGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtCancelGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtCancelGrupo.BackgroundImage")));
            this.BtCancelGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtCancelGrupo.FlatAppearance.BorderSize = 0;
            this.BtCancelGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancelGrupo.Location = new System.Drawing.Point(639, 8);
            this.BtCancelGrupo.Name = "BtCancelGrupo";
            this.BtCancelGrupo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtCancelGrupo.Size = new System.Drawing.Size(94, 30);
            this.BtCancelGrupo.TabIndex = 15;
            this.BtCancelGrupo.UseVisualStyleBackColor = false;
            this.BtCancelGrupo.Click += new System.EventHandler(this.BtCancelGrupo_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtImprimirGrupo);
            this.panel4.Controls.Add(this.BtEditarGrupo);
            this.panel4.Controls.Add(this.CbFiltraProdutos);
            this.panel4.Controls.Add(this.CbFiltraSubGrupo);
            this.panel4.Controls.Add(this.CbFiltraGrupo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(745, 67);
            this.panel4.TabIndex = 1;
            // 
            // BtImprimirGrupo
            // 
            this.BtImprimirGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtImprimirGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtImprimirGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtImprimirGrupo.BackgroundImage")));
            this.BtImprimirGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtImprimirGrupo.FlatAppearance.BorderSize = 0;
            this.BtImprimirGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtImprimirGrupo.Location = new System.Drawing.Point(683, 7);
            this.BtImprimirGrupo.Name = "BtImprimirGrupo";
            this.BtImprimirGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtImprimirGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtImprimirGrupo.TabIndex = 17;
            this.BtImprimirGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtImprimirGrupo.UseVisualStyleBackColor = false;
            // 
            // BtEditarGrupo
            // 
            this.BtEditarGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtEditarGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtEditarGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtEditarGrupo.BackgroundImage")));
            this.BtEditarGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEditarGrupo.FlatAppearance.BorderSize = 0;
            this.BtEditarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEditarGrupo.Location = new System.Drawing.Point(624, 6);
            this.BtEditarGrupo.Name = "BtEditarGrupo";
            this.BtEditarGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtEditarGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtEditarGrupo.TabIndex = 16;
            this.BtEditarGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEditarGrupo.UseVisualStyleBackColor = false;
            this.BtEditarGrupo.Click += new System.EventHandler(this.BtEditarGrupo_Click);
            // 
            // CbFiltraProdutos
            // 
            this.CbFiltraProdutos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CbFiltraProdutos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CbFiltraProdutos.Caption = "Produto";
            this.CbFiltraProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbFiltraProdutos.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFiltraProdutos.FormattingEnabled = true;
            this.CbFiltraProdutos.Location = new System.Drawing.Point(367, 12);
            this.CbFiltraProdutos.Name = "CbFiltraProdutos";
            this.CbFiltraProdutos.Obrigatorio = false;
            this.CbFiltraProdutos.SelectedIndex = -1;
            this.CbFiltraProdutos.SelectedItem = null;
            this.CbFiltraProdutos.SelectedText = "";
            this.CbFiltraProdutos.Size = new System.Drawing.Size(150, 40);
            this.CbFiltraProdutos.TabIndex = 2;
            this.CbFiltraProdutos.SelectedIndexChanged += new System.EventHandler(this.Filtrar);
            // 
            // CbFiltraSubGrupo
            // 
            this.CbFiltraSubGrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CbFiltraSubGrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CbFiltraSubGrupo.Caption = "SubGrupo";
            this.CbFiltraSubGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbFiltraSubGrupo.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFiltraSubGrupo.FormattingEnabled = true;
            this.CbFiltraSubGrupo.Location = new System.Drawing.Point(193, 12);
            this.CbFiltraSubGrupo.Name = "CbFiltraSubGrupo";
            this.CbFiltraSubGrupo.Obrigatorio = false;
            this.CbFiltraSubGrupo.SelectedIndex = -1;
            this.CbFiltraSubGrupo.SelectedItem = null;
            this.CbFiltraSubGrupo.SelectedText = "";
            this.CbFiltraSubGrupo.Size = new System.Drawing.Size(153, 40);
            this.CbFiltraSubGrupo.TabIndex = 1;
            this.CbFiltraSubGrupo.SelectedIndexChanged += new System.EventHandler(this.Filtrar);
            // 
            // CbFiltraGrupo
            // 
            this.CbFiltraGrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CbFiltraGrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CbFiltraGrupo.Caption = "Grupo";
            this.CbFiltraGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbFiltraGrupo.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFiltraGrupo.FormattingEnabled = true;
            this.CbFiltraGrupo.Location = new System.Drawing.Point(18, 12);
            this.CbFiltraGrupo.Name = "CbFiltraGrupo";
            this.CbFiltraGrupo.Obrigatorio = false;
            this.CbFiltraGrupo.SelectedIndex = -1;
            this.CbFiltraGrupo.SelectedItem = null;
            this.CbFiltraGrupo.SelectedText = "";
            this.CbFiltraGrupo.Size = new System.Drawing.Size(154, 40);
            this.CbFiltraGrupo.TabIndex = 0;
            this.CbFiltraGrupo.SelectedIndexChanged += new System.EventHandler(this.Filtrar);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 68);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(82, 68);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gerenciador Preço Compra";
            // 
            // FormAlterarPrecoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 622);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlterarPrecoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyHortifruti";
            this.Load += new System.EventHandler(this.FormAlterarPrecoCompra_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProdutos)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Componentes.AltComboBox CbFiltraProdutos;
        private Componentes.AltComboBox CbFiltraSubGrupo;
        private Componentes.AltComboBox CbFiltraGrupo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView DgvListaProdutos;
        private System.Windows.Forms.Button BtGravarAltPreco;
        private System.Windows.Forms.Button BtCancelGrupo;
        private System.Windows.Forms.Button BtImprimirGrupo;
        private System.Windows.Forms.Button BtEditarGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ibunidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ibgrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ibsubgrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoratual;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrAlterado;
        private System.Windows.Forms.DataGridViewTextBoxColumn margem_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_recno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
    }
}