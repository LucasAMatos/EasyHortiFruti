using EasyHortifruti.Componentes;

namespace EasyHortifruti
{
    partial class FormUnidadesAltInsert
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnidadesAltInsert));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbCadObsUni = new EasyHortifruti.Componentes.AltTextBox();
            this.lbCadObsUnid = new System.Windows.Forms.Label();
            this.tbCadDescricaoUni = new EasyHortifruti.Componentes.AltTextBox();
            this.lbcadDescriUni = new System.Windows.Forms.Label();
            this.tbCadAbreviUni = new EasyHortifruti.Componentes.AltTextBox();
            this.lbCadAbrevUni = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbIDCadUnidade = new System.Windows.Forms.Label();
            this.BtGravarUnidade = new System.Windows.Forms.Button();
            this.BtCancelCadUnidade = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.unidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbCadObsUni);
            this.panel4.Controls.Add(this.lbCadObsUnid);
            this.panel4.Controls.Add(this.tbCadDescricaoUni);
            this.panel4.Controls.Add(this.lbcadDescriUni);
            this.panel4.Controls.Add(this.tbCadAbreviUni);
            this.panel4.Controls.Add(this.lbCadAbrevUni);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(476, 348);
            this.panel4.TabIndex = 2;
            // 
            // tbCadObsUni
            // 
            this.tbCadObsUni.Caption = null;
            this.tbCadObsUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadObsUni.Location = new System.Drawing.Point(31, 186);
            this.tbCadObsUni.Multiline = true;
            this.tbCadObsUni.Name = "tbCadObsUni";
            this.tbCadObsUni.Obrigatorio = false;
            this.tbCadObsUni.Size = new System.Drawing.Size(408, 103);
            this.tbCadObsUni.TabIndex = 5;
            // 
            // lbCadObsUnid
            // 
            this.lbCadObsUnid.AutoSize = true;
            this.lbCadObsUnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadObsUnid.Location = new System.Drawing.Point(28, 168);
            this.lbCadObsUnid.Name = "lbCadObsUnid";
            this.lbCadObsUnid.Size = new System.Drawing.Size(160, 15);
            this.lbCadObsUnid.TabIndex = 4;
            this.lbCadObsUnid.Text = "Observação da Unidade";
            // 
            // tbCadDescricaoUni
            // 
            this.tbCadDescricaoUni.Caption = null;
            this.tbCadDescricaoUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadDescricaoUni.Location = new System.Drawing.Point(31, 121);
            this.tbCadDescricaoUni.Name = "tbCadDescricaoUni";
            this.tbCadDescricaoUni.Obrigatorio = false;
            this.tbCadDescricaoUni.Size = new System.Drawing.Size(408, 24);
            this.tbCadDescricaoUni.TabIndex = 3;
            // 
            // lbcadDescriUni
            // 
            this.lbcadDescriUni.AutoSize = true;
            this.lbcadDescriUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcadDescriUni.Location = new System.Drawing.Point(28, 103);
            this.lbcadDescriUni.Name = "lbcadDescriUni";
            this.lbcadDescriUni.Size = new System.Drawing.Size(71, 15);
            this.lbcadDescriUni.TabIndex = 2;
            this.lbcadDescriUni.Text = "Descrição";
            // 
            // tbCadAbreviUni
            // 
            this.tbCadAbreviUni.Caption = null;
            this.tbCadAbreviUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadAbreviUni.Location = new System.Drawing.Point(31, 62);
            this.tbCadAbreviUni.Name = "tbCadAbreviUni";
            this.tbCadAbreviUni.Obrigatorio = false;
            this.tbCadAbreviUni.Size = new System.Drawing.Size(81, 24);
            this.tbCadAbreviUni.TabIndex = 1;
            // 
            // lbCadAbrevUni
            // 
            this.lbCadAbrevUni.AutoSize = true;
            this.lbCadAbrevUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadAbrevUni.Location = new System.Drawing.Point(30, 44);
            this.lbCadAbrevUni.Name = "lbCadAbrevUni";
            this.lbCadAbrevUni.Size = new System.Drawing.Size(79, 15);
            this.lbCadAbrevUni.TabIndex = 0;
            this.lbCadAbrevUni.Text = "Abreviatura";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbIDCadUnidade);
            this.panel3.Controls.Add(this.BtGravarUnidade);
            this.panel3.Controls.Add(this.BtCancelCadUnidade);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 390);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 60);
            this.panel3.TabIndex = 1;
            // 
            // lbIDCadUnidade
            // 
            this.lbIDCadUnidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIDCadUnidade.AutoSize = true;
            this.lbIDCadUnidade.BackColor = System.Drawing.Color.Transparent;
            this.lbIDCadUnidade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbIDCadUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDCadUnidade.ForeColor = System.Drawing.Color.Black;
            this.lbIDCadUnidade.Location = new System.Drawing.Point(12, 21);
            this.lbIDCadUnidade.Name = "lbIDCadUnidade";
            this.lbIDCadUnidade.Size = new System.Drawing.Size(30, 22);
            this.lbIDCadUnidade.TabIndex = 13;
            this.lbIDCadUnidade.Text = "ID";
            // 
            // BtGravarUnidade
            // 
            this.BtGravarUnidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtGravarUnidade.BackColor = System.Drawing.Color.Transparent;
            this.BtGravarUnidade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtGravarUnidade.BackgroundImage")));
            this.BtGravarUnidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtGravarUnidade.FlatAppearance.BorderSize = 0;
            this.BtGravarUnidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtGravarUnidade.Location = new System.Drawing.Point(270, 17);
            this.BtGravarUnidade.Name = "BtGravarUnidade";
            this.BtGravarUnidade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtGravarUnidade.Size = new System.Drawing.Size(94, 30);
            this.BtGravarUnidade.TabIndex = 3;
            this.BtGravarUnidade.UseVisualStyleBackColor = false;
            this.BtGravarUnidade.Click += new System.EventHandler(this.BtGravarUnidade_Click);
            // 
            // BtCancelCadUnidade
            // 
            this.BtCancelCadUnidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtCancelCadUnidade.BackColor = System.Drawing.Color.Transparent;
            this.BtCancelCadUnidade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtCancelCadUnidade.BackgroundImage")));
            this.BtCancelCadUnidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtCancelCadUnidade.FlatAppearance.BorderSize = 0;
            this.BtCancelCadUnidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancelCadUnidade.Location = new System.Drawing.Point(370, 17);
            this.BtCancelCadUnidade.Name = "BtCancelCadUnidade";
            this.BtCancelCadUnidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtCancelCadUnidade.Size = new System.Drawing.Size(94, 30);
            this.BtCancelCadUnidade.TabIndex = 2;
            this.BtCancelCadUnidade.UseVisualStyleBackColor = false;
            this.BtCancelCadUnidade.Click += new System.EventHandler(this.BtCancelCadUnidade_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 42);
            this.panel2.TabIndex = 0;
            // 
            // unidadesBindingSource
            // 
            this.unidadesBindingSource.DataMember = "unidades";
            // 
            // FormUnidadeAltInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormUnidadeAltInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyHortifruti - Inserir Unidade";
            this.Load += new System.EventHandler(this.FormUnidadeAltInsert_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbcadDescriUni;
        private AltTextBox tbCadAbreviUni;
        private System.Windows.Forms.Label lbCadAbrevUni;
        private System.Windows.Forms.Panel panel3;
        private AltTextBox tbCadDescricaoUni;
        private AltTextBox tbCadObsUni;
        private System.Windows.Forms.Label lbCadObsUnid;
        private System.Windows.Forms.Button BtGravarUnidade;
        private System.Windows.Forms.Button BtCancelCadUnidade;
        private System.Windows.Forms.Label lbIDCadUnidade;
        private System.Windows.Forms.BindingSource unidadesBindingSource;
    }
}