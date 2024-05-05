using EasyHortifruti.Componentes;

namespace EasyHortifruti
{
    partial class FormSubGruposAltInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSubGruposAltInsert));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbGrupo = new EasyHortifruti.Componentes.AltComboBox();
            this.TbMargemSubGrupo = new EasyHortifruti.Componentes.AltTextBox();
            this.TbDescSubGrupo = new EasyHortifruti.Componentes.AltTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbIDSubGrupo = new System.Windows.Forms.Label();
            this.BtGravarSubGrupo = new System.Windows.Forms.Button();
            this.BtCancelSubGrupo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CbGrupo);
            this.panel1.Controls.Add(this.TbMargemSubGrupo);
            this.panel1.Controls.Add(this.TbDescSubGrupo);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 423);
            this.panel1.TabIndex = 0;
            // 
            // CbGrupo
            // 
            this.CbGrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CbGrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbGrupo.Caption = "Grupo";
            this.CbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbGrupo.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.CbGrupo.FormattingEnabled = true;
            this.CbGrupo.Location = new System.Drawing.Point(25, 155);
            this.CbGrupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbGrupo.Name = "CbGrupo";
            this.CbGrupo.Obrigatorio = false;
            this.CbGrupo.SelectedIndex = -1;
            this.CbGrupo.SelectedText = "";
            this.CbGrupo.Size = new System.Drawing.Size(135, 48);
            this.CbGrupo.TabIndex = 2;
            // 
            // TbMargemSubGrupo
            // 
            this.TbMargemSubGrupo.Caption = "Margem de Lucro";
            this.TbMargemSubGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMargemSubGrupo.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.TbMargemSubGrupo.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMargemSubGrupo.Location = new System.Drawing.Point(25, 230);
            this.TbMargemSubGrupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbMargemSubGrupo.MaxLength = 32767;
            this.TbMargemSubGrupo.Multiline = true;
            this.TbMargemSubGrupo.Name = "TbMargemSubGrupo";
            this.TbMargemSubGrupo.Obrigatorio = false;
            this.TbMargemSubGrupo.ReadOnly = false;
            this.TbMargemSubGrupo.SelectionLength = 0;
            this.TbMargemSubGrupo.SelectionStart = 0;
            this.TbMargemSubGrupo.Size = new System.Drawing.Size(135, 48);
            this.TbMargemSubGrupo.TabIndex = 3;
            this.TbMargemSubGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbMargemSubGrupo.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // TbDescSubGrupo
            // 
            this.TbDescSubGrupo.Caption = "Descrição";
            this.TbDescSubGrupo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TbDescSubGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDescSubGrupo.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.TbDescSubGrupo.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDescSubGrupo.Location = new System.Drawing.Point(25, 74);
            this.TbDescSubGrupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbDescSubGrupo.MaxLength = 32767;
            this.TbDescSubGrupo.Multiline = true;
            this.TbDescSubGrupo.Name = "TbDescSubGrupo";
            this.TbDescSubGrupo.Obrigatorio = false;
            this.TbDescSubGrupo.ReadOnly = false;
            this.TbDescSubGrupo.SelectionLength = 0;
            this.TbDescSubGrupo.SelectionStart = 0;
            this.TbDescSubGrupo.Size = new System.Drawing.Size(418, 48);
            this.TbDescSubGrupo.TabIndex = 1;
            this.TbDescSubGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbDescSubGrupo.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LbIDSubGrupo);
            this.panel3.Controls.Add(this.BtGravarSubGrupo);
            this.panel3.Controls.Add(this.BtCancelSubGrupo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 363);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 60);
            this.panel3.TabIndex = 3;
            // 
            // LbIDSubGrupo
            // 
            this.LbIDSubGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbIDSubGrupo.AutoSize = true;
            this.LbIDSubGrupo.BackColor = System.Drawing.Color.Transparent;
            this.LbIDSubGrupo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbIDSubGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIDSubGrupo.ForeColor = System.Drawing.Color.Black;
            this.LbIDSubGrupo.Location = new System.Drawing.Point(12, 21);
            this.LbIDSubGrupo.Name = "LbIDSubGrupo";
            this.LbIDSubGrupo.Size = new System.Drawing.Size(30, 22);
            this.LbIDSubGrupo.TabIndex = 13;
            this.LbIDSubGrupo.Text = "ID";
            // 
            // BtGravarSubGrupo
            // 
            this.BtGravarSubGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtGravarSubGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtGravarSubGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtGravarSubGrupo.BackgroundImage")));
            this.BtGravarSubGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtGravarSubGrupo.FlatAppearance.BorderSize = 0;
            this.BtGravarSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtGravarSubGrupo.Location = new System.Drawing.Point(263, 17);
            this.BtGravarSubGrupo.Name = "BtGravarSubGrupo";
            this.BtGravarSubGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtGravarSubGrupo.Size = new System.Drawing.Size(94, 30);
            this.BtGravarSubGrupo.TabIndex = 4;
            this.BtGravarSubGrupo.UseVisualStyleBackColor = false;
            this.BtGravarSubGrupo.Click += new System.EventHandler(this.BtGravarSubGrupo_Click);
            // 
            // BtCancelSubGrupo
            // 
            this.BtCancelSubGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtCancelSubGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtCancelSubGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtCancelSubGrupo.BackgroundImage")));
            this.BtCancelSubGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtCancelSubGrupo.FlatAppearance.BorderSize = 0;
            this.BtCancelSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancelSubGrupo.Location = new System.Drawing.Point(363, 17);
            this.BtCancelSubGrupo.Name = "BtCancelSubGrupo";
            this.BtCancelSubGrupo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtCancelSubGrupo.Size = new System.Drawing.Size(94, 30);
            this.BtCancelSubGrupo.TabIndex = 5;
            this.BtCancelSubGrupo.UseVisualStyleBackColor = false;
            this.BtCancelSubGrupo.Click += new System.EventHandler(this.BtCancelSubGrupo_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 55);
            this.panel2.TabIndex = 1;
            // 
            // FormSubGruposAltInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 423);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSubGruposAltInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Hortifruti - Inserir SubGrupo";
            this.Load += new System.EventHandler(this.FormSubGrupoAltInsert_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbIDSubGrupo;
        private System.Windows.Forms.Button BtGravarSubGrupo;
        private System.Windows.Forms.Button BtCancelSubGrupo;
        private AltComboBox CbGrupo;
        private AltTextBox TbMargemSubGrupo;
        private AltTextBox TbDescSubGrupo;
    }
}