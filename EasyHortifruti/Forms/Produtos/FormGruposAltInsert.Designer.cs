using EasyHortifruti.Componentes;

namespace EasyHortifruti
{
    partial class FormGruposAltInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGruposAltInsert));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbMargemGrupo = new EasyHortifruti.Componentes.AltTextBox();
            this.TbObsGrupo = new EasyHortifruti.Componentes.AltTextBox();
            this.TbDescGrupo = new EasyHortifruti.Componentes.AltTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbIDGrupo = new System.Windows.Forms.Label();
            this.BtGravarGrupo = new System.Windows.Forms.Button();
            this.BtCancelGrupo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TbMargemGrupo);
            this.panel1.Controls.Add(this.TbObsGrupo);
            this.panel1.Controls.Add(this.TbDescGrupo);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 422);
            this.panel1.TabIndex = 0;
            // 
            // TbMargemGrupo
            // 
            this.TbMargemGrupo.Caption = "Margem de Lucro";
            this.TbMargemGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMargemGrupo.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.TbMargemGrupo.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMargemGrupo.Location = new System.Drawing.Point(24, 289);
            this.TbMargemGrupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbMargemGrupo.MaxLength = 32767;
            this.TbMargemGrupo.Multiline = true;
            this.TbMargemGrupo.Name = "TbMargemGrupo";
            this.TbMargemGrupo.Obrigatorio = false;
            this.TbMargemGrupo.ReadOnly = false;
            this.TbMargemGrupo.SelectionLength = 0;
            this.TbMargemGrupo.SelectionStart = 0;
            this.TbMargemGrupo.Size = new System.Drawing.Size(129, 48);
            this.TbMargemGrupo.TabIndex = 3;
            this.TbMargemGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbMargemGrupo.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // TbObsGrupo
            // 
            this.TbObsGrupo.Caption = "Observação do Grupo";
            this.TbObsGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbObsGrupo.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.TbObsGrupo.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbObsGrupo.Location = new System.Drawing.Point(24, 160);
            this.TbObsGrupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbObsGrupo.MaxLength = 32767;
            this.TbObsGrupo.Multiline = true;
            this.TbObsGrupo.Name = "TbObsGrupo";
            this.TbObsGrupo.Obrigatorio = false;
            this.TbObsGrupo.ReadOnly = false;
            this.TbObsGrupo.SelectionLength = 0;
            this.TbObsGrupo.SelectionStart = 0;
            this.TbObsGrupo.Size = new System.Drawing.Size(418, 98);
            this.TbObsGrupo.TabIndex = 2;
            this.TbObsGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbObsGrupo.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // TbDescGrupo
            // 
            this.TbDescGrupo.Caption = "Descrição";
            this.TbDescGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDescGrupo.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.TbDescGrupo.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDescGrupo.Location = new System.Drawing.Point(24, 75);
            this.TbDescGrupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbDescGrupo.MaxLength = 32767;
            this.TbDescGrupo.Multiline = true;
            this.TbDescGrupo.Name = "TbDescGrupo";
            this.TbDescGrupo.Obrigatorio = false;
            this.TbDescGrupo.ReadOnly = false;
            this.TbDescGrupo.SelectionLength = 0;
            this.TbDescGrupo.SelectionStart = 0;
            this.TbDescGrupo.Size = new System.Drawing.Size(418, 48);
            this.TbDescGrupo.TabIndex = 1;
            this.TbDescGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbDescGrupo.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LbIDGrupo);
            this.panel3.Controls.Add(this.BtGravarGrupo);
            this.panel3.Controls.Add(this.BtCancelGrupo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 60);
            this.panel3.TabIndex = 2;
            // 
            // LbIDGrupo
            // 
            this.LbIDGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbIDGrupo.AutoSize = true;
            this.LbIDGrupo.BackColor = System.Drawing.Color.Transparent;
            this.LbIDGrupo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbIDGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIDGrupo.ForeColor = System.Drawing.Color.Black;
            this.LbIDGrupo.Location = new System.Drawing.Point(12, 21);
            this.LbIDGrupo.Name = "LbIDGrupo";
            this.LbIDGrupo.Size = new System.Drawing.Size(30, 22);
            this.LbIDGrupo.TabIndex = 13;
            this.LbIDGrupo.Text = "ID";
            // 
            // BtGravarGrupo
            // 
            this.BtGravarGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtGravarGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtGravarGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtGravarGrupo.BackgroundImage")));
            this.BtGravarGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtGravarGrupo.FlatAppearance.BorderSize = 0;
            this.BtGravarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtGravarGrupo.Location = new System.Drawing.Point(264, 17);
            this.BtGravarGrupo.Name = "BtGravarGrupo";
            this.BtGravarGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtGravarGrupo.Size = new System.Drawing.Size(94, 30);
            this.BtGravarGrupo.TabIndex = 4;
            this.BtGravarGrupo.UseVisualStyleBackColor = false;
            this.BtGravarGrupo.Click += new System.EventHandler(this.BtGravarGrupo_Click);
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
            this.BtCancelGrupo.Location = new System.Drawing.Point(364, 17);
            this.BtCancelGrupo.Name = "BtCancelGrupo";
            this.BtCancelGrupo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtCancelGrupo.Size = new System.Drawing.Size(94, 30);
            this.BtCancelGrupo.TabIndex = 5;
            this.BtCancelGrupo.UseVisualStyleBackColor = false;
            this.BtCancelGrupo.Click += new System.EventHandler(this.BtCancelGrupo_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 57);
            this.panel2.TabIndex = 1;
            // 
            // FormGruposAltInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 422);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGruposAltInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Hortifruti - Inserir/Alterar Grupos";
            this.Load += new System.EventHandler(this.FormGruposAltInsert_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private AltTextBox TbMargemGrupo;
        private AltTextBox TbObsGrupo;
        private AltTextBox TbDescGrupo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbIDGrupo;
        private System.Windows.Forms.Button BtGravarGrupo;
        private System.Windows.Forms.Button BtCancelGrupo;
    }
}