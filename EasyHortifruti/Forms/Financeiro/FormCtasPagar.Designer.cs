namespace EasyHortifruti.Forms.Financeiro
{
    partial class FormCtasPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCtasPagar));
            this.PanelTopTítulo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelTopTítulo
            // 
            this.PanelTopTítulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelTopTítulo.BackgroundImage")));
            this.PanelTopTítulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelTopTítulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopTítulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTopTítulo.Name = "PanelTopTítulo";
            this.PanelTopTítulo.Size = new System.Drawing.Size(815, 69);
            this.PanelTopTítulo.TabIndex = 0;
            // 
            // FormCtasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 610);
            this.Controls.Add(this.PanelTopTítulo);
            this.Name = "FormCtasPagar";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopTítulo;
    }
}