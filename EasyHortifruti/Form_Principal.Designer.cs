namespace EasyHortifruti
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1FormPrincipal = new System.Windows.Forms.Panel();
            this.btFinanceiro = new System.Windows.Forms.Button();
            this.btSairPrincipal = new System.Windows.Forms.Button();
            this.btRelatórios = new System.Windows.Forms.Button();
            this.btPedidos = new System.Windows.Forms.Button();
            this.btCadGeral = new System.Windows.Forms.Button();
            this.btProdutos = new System.Windows.Forms.Button();
            this.panel1FormPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1FormPrincipal
            // 
            this.panel1FormPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.panel1FormPrincipal.Controls.Add(this.btFinanceiro);
            this.panel1FormPrincipal.Controls.Add(this.btSairPrincipal);
            this.panel1FormPrincipal.Controls.Add(this.btRelatórios);
            this.panel1FormPrincipal.Controls.Add(this.btPedidos);
            this.panel1FormPrincipal.Controls.Add(this.btCadGeral);
            this.panel1FormPrincipal.Controls.Add(this.btProdutos);
            this.panel1FormPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1FormPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panel1FormPrincipal.Name = "panel1FormPrincipal";
            this.panel1FormPrincipal.Size = new System.Drawing.Size(484, 561);
            this.panel1FormPrincipal.TabIndex = 0;
            // 
            // btFinanceiro
            // 
            this.btFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.btFinanceiro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btFinanceiro.BackgroundImage")));
            this.btFinanceiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFinanceiro.FlatAppearance.BorderSize = 0;
            this.btFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinanceiro.Location = new System.Drawing.Point(49, 280);
            this.btFinanceiro.Name = "btFinanceiro";
            this.btFinanceiro.Size = new System.Drawing.Size(195, 44);
            this.btFinanceiro.TabIndex = 7;
            this.btFinanceiro.UseVisualStyleBackColor = false;
            this.btFinanceiro.Click += new System.EventHandler(this.BtFinanceiro_Click);
            // 
            // btSairPrincipal
            // 
            this.btSairPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btSairPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSairPrincipal.BackgroundImage")));
            this.btSairPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSairPrincipal.FlatAppearance.BorderSize = 0;
            this.btSairPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSairPrincipal.Location = new System.Drawing.Point(49, 433);
            this.btSairPrincipal.Name = "btSairPrincipal";
            this.btSairPrincipal.Size = new System.Drawing.Size(195, 44);
            this.btSairPrincipal.TabIndex = 6;
            this.btSairPrincipal.UseVisualStyleBackColor = false;
            this.btSairPrincipal.Click += new System.EventHandler(this.BtSairPrincipal_Click);
            // 
            // btRelatórios
            // 
            this.btRelatórios.BackColor = System.Drawing.Color.Transparent;
            this.btRelatórios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRelatórios.BackgroundImage")));
            this.btRelatórios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRelatórios.FlatAppearance.BorderSize = 0;
            this.btRelatórios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelatórios.Location = new System.Drawing.Point(49, 358);
            this.btRelatórios.Name = "btRelatórios";
            this.btRelatórios.Size = new System.Drawing.Size(195, 44);
            this.btRelatórios.TabIndex = 5;
            this.btRelatórios.UseVisualStyleBackColor = false;
            this.btRelatórios.Click += new System.EventHandler(this.BtRelatórios_Click);
            // 
            // btPedidos
            // 
            this.btPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btPedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPedidos.BackgroundImage")));
            this.btPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPedidos.FlatAppearance.BorderSize = 0;
            this.btPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPedidos.Location = new System.Drawing.Point(49, 199);
            this.btPedidos.Name = "btPedidos";
            this.btPedidos.Size = new System.Drawing.Size(195, 44);
            this.btPedidos.TabIndex = 4;
            this.btPedidos.UseVisualStyleBackColor = false;
            this.btPedidos.Click += new System.EventHandler(this.BtPedidos_Click);
            // 
            // btCadGeral
            // 
            this.btCadGeral.BackColor = System.Drawing.Color.Transparent;
            this.btCadGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCadGeral.BackgroundImage")));
            this.btCadGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCadGeral.FlatAppearance.BorderSize = 0;
            this.btCadGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadGeral.Location = new System.Drawing.Point(49, 38);
            this.btCadGeral.Name = "btCadGeral";
            this.btCadGeral.Size = new System.Drawing.Size(195, 42);
            this.btCadGeral.TabIndex = 1;
            this.btCadGeral.UseVisualStyleBackColor = false;
            this.btCadGeral.Click += new System.EventHandler(this.BtCadGeral_Click);
            // 
            // btProdutos
            // 
            this.btProdutos.BackColor = System.Drawing.Color.Transparent;
            this.btProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btProdutos.BackgroundImage")));
            this.btProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btProdutos.FlatAppearance.BorderSize = 0;
            this.btProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProdutos.Location = new System.Drawing.Point(49, 118);
            this.btProdutos.Name = "btProdutos";
            this.btProdutos.Size = new System.Drawing.Size(195, 45);
            this.btProdutos.TabIndex = 0;
            this.btProdutos.UseVisualStyleBackColor = false;
            this.btProdutos.Click += new System.EventHandler(this.BtProdutos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.panel1FormPrincipal);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyHortifruti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1FormPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1FormPrincipal;
        private System.Windows.Forms.Button btProdutos;
        private System.Windows.Forms.Button btCadGeral;
        private System.Windows.Forms.Button btPedidos;
        private System.Windows.Forms.Button btRelatórios;
        private System.Windows.Forms.Button btSairPrincipal;
        private System.Windows.Forms.Button btFinanceiro;
    }
}

