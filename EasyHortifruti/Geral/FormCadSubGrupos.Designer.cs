namespace EasyHortifruti
{
    partial class FormCadSubGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadSubGrupos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgViewCadSubGrupos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtSairSubGrupo = new System.Windows.Forms.Button();
            this.BtPesquisarSubGrupo = new System.Windows.Forms.Button();
            this.BtImprimirSubGrupo = new System.Windows.Forms.Button();
            this.BtExcluirSubGrupo = new System.Windows.Forms.Button();
            this.BtEditarSubGrupo = new System.Windows.Forms.Button();
            this.BtIncluirSubGrupo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margemlucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCadSubGrupos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgViewCadSubGrupos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 495);
            this.panel1.TabIndex = 0;
            // 
            // DgViewCadSubGrupos
            // 
            this.DgViewCadSubGrupos.AllowUserToAddRows = false;
            this.DgViewCadSubGrupos.AllowUserToDeleteRows = false;
            this.DgViewCadSubGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewCadSubGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.Grupo,
            this.margemlucro,
            this.ID});
            this.DgViewCadSubGrupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgViewCadSubGrupos.Location = new System.Drawing.Point(0, 121);
            this.DgViewCadSubGrupos.Name = "DgViewCadSubGrupos";
            this.DgViewCadSubGrupos.Size = new System.Drawing.Size(477, 374);
            this.DgViewCadSubGrupos.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtSairSubGrupo);
            this.panel3.Controls.Add(this.BtPesquisarSubGrupo);
            this.panel3.Controls.Add(this.BtImprimirSubGrupo);
            this.panel3.Controls.Add(this.BtExcluirSubGrupo);
            this.panel3.Controls.Add(this.BtEditarSubGrupo);
            this.panel3.Controls.Add(this.BtIncluirSubGrupo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 66);
            this.panel3.TabIndex = 1;
            // 
            // BtSairSubGrupo
            // 
            this.BtSairSubGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSairSubGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtSairSubGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtSairSubGrupo.BackgroundImage")));
            this.BtSairSubGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtSairSubGrupo.FlatAppearance.BorderSize = 0;
            this.BtSairSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSairSubGrupo.Location = new System.Drawing.Point(422, 7);
            this.BtSairSubGrupo.Name = "BtSairSubGrupo";
            this.BtSairSubGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtSairSubGrupo.Size = new System.Drawing.Size(44, 52);
            this.BtSairSubGrupo.TabIndex = 21;
            this.BtSairSubGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtSairSubGrupo.UseVisualStyleBackColor = false;
            this.BtSairSubGrupo.Click += new System.EventHandler(this.BtSairSubGrupo_Click);
            // 
            // BtPesquisarSubGrupo
            // 
            this.BtPesquisarSubGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtPesquisarSubGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtPesquisarSubGrupo.BackgroundImage")));
            this.BtPesquisarSubGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtPesquisarSubGrupo.FlatAppearance.BorderSize = 0;
            this.BtPesquisarSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPesquisarSubGrupo.Location = new System.Drawing.Point(162, 8);
            this.BtPesquisarSubGrupo.Name = "BtPesquisarSubGrupo";
            this.BtPesquisarSubGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtPesquisarSubGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtPesquisarSubGrupo.TabIndex = 20;
            this.BtPesquisarSubGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtPesquisarSubGrupo.UseVisualStyleBackColor = false;
            // 
            // BtImprimirSubGrupo
            // 
            this.BtImprimirSubGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtImprimirSubGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtImprimirSubGrupo.BackgroundImage")));
            this.BtImprimirSubGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtImprimirSubGrupo.FlatAppearance.BorderSize = 0;
            this.BtImprimirSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtImprimirSubGrupo.Location = new System.Drawing.Point(214, 8);
            this.BtImprimirSubGrupo.Name = "BtImprimirSubGrupo";
            this.BtImprimirSubGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtImprimirSubGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtImprimirSubGrupo.TabIndex = 19;
            this.BtImprimirSubGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtImprimirSubGrupo.UseVisualStyleBackColor = false;
            // 
            // BtExcluirSubGrupo
            // 
            this.BtExcluirSubGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtExcluirSubGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtExcluirSubGrupo.BackgroundImage")));
            this.BtExcluirSubGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtExcluirSubGrupo.FlatAppearance.BorderSize = 0;
            this.BtExcluirSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExcluirSubGrupo.Location = new System.Drawing.Point(110, 7);
            this.BtExcluirSubGrupo.Name = "BtExcluirSubGrupo";
            this.BtExcluirSubGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtExcluirSubGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtExcluirSubGrupo.TabIndex = 18;
            this.BtExcluirSubGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtExcluirSubGrupo.UseVisualStyleBackColor = false;
            this.BtExcluirSubGrupo.Click += new System.EventHandler(this.BtExcluirSubGrupo_Click);
            // 
            // BtEditarSubGrupo
            // 
            this.BtEditarSubGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtEditarSubGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtEditarSubGrupo.BackgroundImage")));
            this.BtEditarSubGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEditarSubGrupo.FlatAppearance.BorderSize = 0;
            this.BtEditarSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEditarSubGrupo.Location = new System.Drawing.Point(58, 7);
            this.BtEditarSubGrupo.Name = "BtEditarSubGrupo";
            this.BtEditarSubGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtEditarSubGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtEditarSubGrupo.TabIndex = 17;
            this.BtEditarSubGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEditarSubGrupo.UseVisualStyleBackColor = false;
            this.BtEditarSubGrupo.Click += new System.EventHandler(this.BtEditarSubGrupo_Click);
            // 
            // BtIncluirSubGrupo
            // 
            this.BtIncluirSubGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtIncluirSubGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtIncluirSubGrupo.BackgroundImage")));
            this.BtIncluirSubGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtIncluirSubGrupo.FlatAppearance.BorderSize = 0;
            this.BtIncluirSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtIncluirSubGrupo.Location = new System.Drawing.Point(6, 7);
            this.BtIncluirSubGrupo.Name = "BtIncluirSubGrupo";
            this.BtIncluirSubGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtIncluirSubGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtIncluirSubGrupo.TabIndex = 16;
            this.BtIncluirSubGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtIncluirSubGrupo.UseVisualStyleBackColor = false;
            this.BtIncluirSubGrupo.Click += new System.EventHandler(this.BtIncluirSubGrupo_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 55);
            this.panel2.TabIndex = 0;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "nome_subgrupo";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 120;
            // 
            // Grupo
            // 
            this.Grupo.DataPropertyName = "nome_grupo";
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            this.Grupo.Width = 120;
            // 
            // margemlucro
            // 
            this.margemlucro.DataPropertyName = "margem_subgrupo";
            this.margemlucro.HeaderText = "Margem Lucro";
            this.margemlucro.Name = "margemlucro";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_recno";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // FormCadSubGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 495);
            this.Controls.Add(this.panel1);
            this.Name = "FormCadSubGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.FormCadSubGrupos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCadSubGrupos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DgViewCadSubGrupos;
        private System.Windows.Forms.Button BtSairSubGrupo;
        private System.Windows.Forms.Button BtPesquisarSubGrupo;
        private System.Windows.Forms.Button BtImprimirSubGrupo;
        private System.Windows.Forms.Button BtExcluirSubGrupo;
        private System.Windows.Forms.Button BtEditarSubGrupo;
        private System.Windows.Forms.Button BtIncluirSubGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn margemlucro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}