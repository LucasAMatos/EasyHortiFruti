using System;

namespace EasyHortifruti
{
    partial class FormProdutosAltInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutosAltInsert));
            this.panelInserirProduto = new System.Windows.Forms.Panel();
            this.BtCadUnidade = new System.Windows.Forms.Button();
            this.cbSubGrupoProduto = new System.Windows.Forms.ComboBox();
            this.cbGrupoProduto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMargemLucro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrecoVenda = new System.Windows.Forms.TextBox();
            this.tbPrecoCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUnidProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBotoesInserirProduto = new System.Windows.Forms.Panel();
            this.labelIDProduto = new System.Windows.Forms.Label();
            this.btSalvarInserirProduto = new System.Windows.Forms.Button();
            this.BtCancelaProduto = new System.Windows.Forms.Button();
            this.panelInserirProduto.SuspendLayout();
            this.panelBotoesInserirProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInserirProduto
            // 
            this.panelInserirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelInserirProduto.Controls.Add(this.BtCadUnidade);
            this.panelInserirProduto.Controls.Add(this.cbSubGrupoProduto);
            this.panelInserirProduto.Controls.Add(this.cbGrupoProduto);
            this.panelInserirProduto.Controls.Add(this.label7);
            this.panelInserirProduto.Controls.Add(this.label6);
            this.panelInserirProduto.Controls.Add(this.tbMargemLucro);
            this.panelInserirProduto.Controls.Add(this.label5);
            this.panelInserirProduto.Controls.Add(this.tbPrecoVenda);
            this.panelInserirProduto.Controls.Add(this.tbPrecoCompra);
            this.panelInserirProduto.Controls.Add(this.label4);
            this.panelInserirProduto.Controls.Add(this.label3);
            this.panelInserirProduto.Controls.Add(this.cbUnidProduto);
            this.panelInserirProduto.Controls.Add(this.label2);
            this.panelInserirProduto.Controls.Add(this.tbDescricaoProduto);
            this.panelInserirProduto.Controls.Add(this.label1);
            this.panelInserirProduto.Controls.Add(this.panelBotoesInserirProduto);
            this.panelInserirProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInserirProduto.Location = new System.Drawing.Point(0, 0);
            this.panelInserirProduto.Name = "panelInserirProduto";
            this.panelInserirProduto.Size = new System.Drawing.Size(612, 482);
            this.panelInserirProduto.TabIndex = 0;
            // 
            // BtCadUnidade
            // 
            this.BtCadUnidade.BackColor = System.Drawing.Color.Transparent;
            this.BtCadUnidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtCadUnidade.FlatAppearance.BorderSize = 0;
            this.BtCadUnidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCadUnidade.Image = ((System.Drawing.Image)(resources.GetObject("BtCadUnidade.Image")));
            this.BtCadUnidade.Location = new System.Drawing.Point(187, 151);
            this.BtCadUnidade.Name = "BtCadUnidade";
            this.BtCadUnidade.Size = new System.Drawing.Size(26, 25);
            this.BtCadUnidade.TabIndex = 14;
            this.BtCadUnidade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtCadUnidade.UseVisualStyleBackColor = false;
            this.BtCadUnidade.Click += new System.EventHandler(this.BtCadUnidade_Click_1);
            // 
            // cbSubGrupoProduto
            // 
            this.cbSubGrupoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubGrupoProduto.FormattingEnabled = true;
            this.cbSubGrupoProduto.Location = new System.Drawing.Point(421, 230);
            this.cbSubGrupoProduto.Name = "cbSubGrupoProduto";
            this.cbSubGrupoProduto.Size = new System.Drawing.Size(139, 26);
            this.cbSubGrupoProduto.TabIndex = 13;
            // 
            // cbGrupoProduto
            // 
            this.cbGrupoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupoProduto.FormattingEnabled = true;
            this.cbGrupoProduto.Location = new System.Drawing.Point(232, 230);
            this.cbGrupoProduto.Name = "cbGrupoProduto";
            this.cbGrupoProduto.Size = new System.Drawing.Size(149, 26);
            this.cbGrupoProduto.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(421, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "SubGrupo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(232, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Grupo";
            // 
            // tbMargemLucro
            // 
            this.tbMargemLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMargemLucro.Location = new System.Drawing.Point(58, 230);
            this.tbMargemLucro.Name = "tbMargemLucro";
            this.tbMargemLucro.Size = new System.Drawing.Size(129, 24);
            this.tbMargemLucro.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(58, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Margem Lucro";
            // 
            // tbPrecoVenda
            // 
            this.tbPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecoVenda.Location = new System.Drawing.Point(421, 151);
            this.tbPrecoVenda.Name = "tbPrecoVenda";
            this.tbPrecoVenda.Size = new System.Drawing.Size(139, 24);
            this.tbPrecoVenda.TabIndex = 8;
            // 
            // tbPrecoCompra
            // 
            this.tbPrecoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecoCompra.Location = new System.Drawing.Point(232, 151);
            this.tbPrecoCompra.Name = "tbPrecoCompra";
            this.tbPrecoCompra.Size = new System.Drawing.Size(149, 24);
            this.tbPrecoCompra.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(421, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço de Venda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(232, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preço de Compra";
            // 
            // cbUnidProduto
            // 
            this.cbUnidProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidProduto.FormattingEnabled = true;
            this.cbUnidProduto.Location = new System.Drawing.Point(58, 151);
            this.cbUnidProduto.Name = "cbUnidProduto";
            this.cbUnidProduto.Size = new System.Drawing.Size(129, 26);
            this.cbUnidProduto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(58, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unidade";
            // 
            // tbDescricaoProduto
            // 
            this.tbDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricaoProduto.Location = new System.Drawing.Point(58, 74);
            this.tbDescricaoProduto.Name = "tbDescricaoProduto";
            this.tbDescricaoProduto.Size = new System.Drawing.Size(502, 24);
            this.tbDescricaoProduto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(58, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição";
            // 
            // panelBotoesInserirProduto
            // 
            this.panelBotoesInserirProduto.BackColor = System.Drawing.Color.Transparent;
            this.panelBotoesInserirProduto.Controls.Add(this.labelIDProduto);
            this.panelBotoesInserirProduto.Controls.Add(this.btSalvarInserirProduto);
            this.panelBotoesInserirProduto.Controls.Add(this.BtCancelaProduto);
            this.panelBotoesInserirProduto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotoesInserirProduto.Location = new System.Drawing.Point(0, 420);
            this.panelBotoesInserirProduto.Name = "panelBotoesInserirProduto";
            this.panelBotoesInserirProduto.Size = new System.Drawing.Size(612, 62);
            this.panelBotoesInserirProduto.TabIndex = 0;
            // 
            // labelIDProduto
            // 
            this.labelIDProduto.AutoSize = true;
            this.labelIDProduto.BackColor = System.Drawing.Color.Transparent;
            this.labelIDProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelIDProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDProduto.ForeColor = System.Drawing.Color.Black;
            this.labelIDProduto.Location = new System.Drawing.Point(12, 21);
            this.labelIDProduto.Name = "labelIDProduto";
            this.labelIDProduto.Size = new System.Drawing.Size(30, 22);
            this.labelIDProduto.TabIndex = 12;
            this.labelIDProduto.Text = "ID";
            // 
            // btSalvarInserirProduto
            // 
            this.btSalvarInserirProduto.BackColor = System.Drawing.Color.Transparent;
            this.btSalvarInserirProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSalvarInserirProduto.BackgroundImage")));
            this.btSalvarInserirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSalvarInserirProduto.FlatAppearance.BorderSize = 0;
            this.btSalvarInserirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvarInserirProduto.Location = new System.Drawing.Point(405, 17);
            this.btSalvarInserirProduto.Name = "btSalvarInserirProduto";
            this.btSalvarInserirProduto.Size = new System.Drawing.Size(94, 30);
            this.btSalvarInserirProduto.TabIndex = 1;
            this.btSalvarInserirProduto.UseVisualStyleBackColor = false;
            // 
            // BtCancelaProduto
            // 
            this.BtCancelaProduto.BackColor = System.Drawing.Color.Transparent;
            this.BtCancelaProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtCancelaProduto.BackgroundImage")));
            this.BtCancelaProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtCancelaProduto.FlatAppearance.BorderSize = 0;
            this.BtCancelaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancelaProduto.Location = new System.Drawing.Point(505, 17);
            this.BtCancelaProduto.Name = "BtCancelaProduto";
            this.BtCancelaProduto.Size = new System.Drawing.Size(94, 30);
            this.BtCancelaProduto.TabIndex = 0;
            this.BtCancelaProduto.UseVisualStyleBackColor = false;
            this.BtCancelaProduto.Click += new System.EventHandler(this.BtCancelaProduto_Click);
            // 
            // FormProdutosAltInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 482);
            this.Controls.Add(this.panelInserirProduto);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FormProdutosAltInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyHortifruti - Inserir Produto";
            this.Load += new System.EventHandler(this.FormProdutosAltInsert_Load);
            this.panelInserirProduto.ResumeLayout(false);
            this.panelInserirProduto.PerformLayout();
            this.panelBotoesInserirProduto.ResumeLayout(false);
            this.panelBotoesInserirProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btCadUnidade_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panelInserirProduto;
        private System.Windows.Forms.Panel panelBotoesInserirProduto;
        private System.Windows.Forms.Button BtCancelaProduto;
        private System.Windows.Forms.Button btSalvarInserirProduto;
        private System.Windows.Forms.TextBox tbDescricaoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUnidProduto;
        private System.Windows.Forms.TextBox tbPrecoVenda;
        private System.Windows.Forms.TextBox tbPrecoCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMargemLucro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSubGrupoProduto;
        private System.Windows.Forms.ComboBox cbGrupoProduto;
        private System.Windows.Forms.Label labelIDProduto;
        private System.Windows.Forms.Button BtCadUnidade;
    }
}