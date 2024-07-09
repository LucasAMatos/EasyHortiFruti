namespace EasyHortifruti.Utilitarios
{
    partial class FormBackupDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackupDiario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtLocalizar = new System.Windows.Forms.Button();
            this.BtGravarBackup = new System.Windows.Forms.Button();
            this.BtCancelarBackup = new System.Windows.Forms.Button();
            this.TxtBackupPath = new EasyHortifruti.Componentes.AltTextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 306);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 64);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(620, 143);
            this.panel6.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtCancelarBackup);
            this.panel4.Controls.Add(this.BtGravarBackup);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 207);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(620, 99);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 64);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(22, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(56, 56);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtLocalizar);
            this.panel5.Controls.Add(this.TxtBackupPath);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel5.Size = new System.Drawing.Size(620, 45);
            this.panel5.TabIndex = 0;
            // 
            // BtLocalizar
            // 
            this.BtLocalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.BtLocalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtLocalizar.BackgroundImage")));
            this.BtLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtLocalizar.FlatAppearance.BorderSize = 0;
            this.BtLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtLocalizar.Location = new System.Drawing.Point(572, 16);
            this.BtLocalizar.Name = "BtLocalizar";
            this.BtLocalizar.Size = new System.Drawing.Size(27, 23);
            this.BtLocalizar.TabIndex = 1;
            this.BtLocalizar.UseVisualStyleBackColor = false;
            this.BtLocalizar.Click += new System.EventHandler(this.BtLocalizar_Click);
            // 
            // BtGravarBackup
            // 
            this.BtGravarBackup.BackColor = System.Drawing.Color.Transparent;
            this.BtGravarBackup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtGravarBackup.BackgroundImage")));
            this.BtGravarBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtGravarBackup.FlatAppearance.BorderSize = 0;
            this.BtGravarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtGravarBackup.Location = new System.Drawing.Point(391, 54);
            this.BtGravarBackup.Name = "BtGravarBackup";
            this.BtGravarBackup.Size = new System.Drawing.Size(102, 36);
            this.BtGravarBackup.TabIndex = 1;
            this.BtGravarBackup.UseVisualStyleBackColor = false;
            this.BtGravarBackup.Click += new System.EventHandler(this.BtGravarBackup_Click);
            // 
            // BtCancelarBackup
            // 
            this.BtCancelarBackup.BackColor = System.Drawing.Color.Transparent;
            this.BtCancelarBackup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtCancelarBackup.BackgroundImage")));
            this.BtCancelarBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtCancelarBackup.FlatAppearance.BorderSize = 0;
            this.BtCancelarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancelarBackup.Location = new System.Drawing.Point(499, 54);
            this.BtCancelarBackup.Name = "BtCancelarBackup";
            this.BtCancelarBackup.Size = new System.Drawing.Size(100, 36);
            this.BtCancelarBackup.TabIndex = 2;
            this.BtCancelarBackup.UseVisualStyleBackColor = false;
            this.BtCancelarBackup.Click += new System.EventHandler(this.BtCancelarBackup_Click);
            // 
            // TxtBackupPath
            // 
            this.TxtBackupPath.Caption = "Destino do Backup";
            this.TxtBackupPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBackupPath.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBackupPath.FonteTexto = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBackupPath.Location = new System.Drawing.Point(20, 0);
            this.TxtBackupPath.MaxLength = 32767;
            this.TxtBackupPath.Multiline = true;
            this.TxtBackupPath.Name = "TxtBackupPath";
            this.TxtBackupPath.Obrigatorio = false;
            this.TxtBackupPath.ReadOnly = false;
            this.TxtBackupPath.SelectionLength = 0;
            this.TxtBackupPath.SelectionStart = 0;
            this.TxtBackupPath.Size = new System.Drawing.Size(580, 40);
            this.TxtBackupPath.TabIndex = 0;
            this.TxtBackupPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBackupPath.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // FormBackupDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 306);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBackupDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Database";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtLocalizar;
        private Componentes.AltTextBox TxtBackupPath;
        private System.Windows.Forms.Button BtCancelarBackup;
        private System.Windows.Forms.Button BtGravarBackup;
    }
}