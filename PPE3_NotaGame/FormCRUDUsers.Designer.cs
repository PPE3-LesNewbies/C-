namespace PPE3_NotaGame
{
    partial class FormCRUDUsers
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
            this.lblPseudo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCommunaute = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.tbPseudo = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbCommu = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(53, 129);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(49, 13);
            this.lblPseudo.TabIndex = 0;
            this.lblPseudo.Text = "Pseudo :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(53, 178);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email : ";
            // 
            // lblCommunaute
            // 
            this.lblCommunaute.AutoSize = true;
            this.lblCommunaute.Location = new System.Drawing.Point(53, 237);
            this.lblCommunaute.Name = "lblCommunaute";
            this.lblCommunaute.Size = new System.Drawing.Size(75, 13);
            this.lblCommunaute.TabIndex = 2;
            this.lblCommunaute.Text = "Communauté :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(53, 299);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(77, 13);
            this.lblMdp.TabIndex = 3;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // tbPseudo
            // 
            this.tbPseudo.Location = new System.Drawing.Point(167, 126);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.Size = new System.Drawing.Size(152, 20);
            this.tbPseudo.TabIndex = 4;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(167, 175);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(152, 20);
            this.tbEmail.TabIndex = 5;
            // 
            // tbCommu
            // 
            this.tbCommu.Location = new System.Drawing.Point(167, 234);
            this.tbCommu.Name = "tbCommu";
            this.tbCommu.Size = new System.Drawing.Size(152, 20);
            this.tbCommu.TabIndex = 6;
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(167, 296);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(152, 20);
            this.tbMdp.TabIndex = 7;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(273, 385);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(133, 385);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FormCRUDUsers
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(470, 486);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbCommu);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPseudo);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblCommunaute);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPseudo);
            this.Name = "FormCRUDUsers";
            this.Text = "Ajouter/Modifier/Supprimer : Users";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCommunaute;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox tbPseudo;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbCommu;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;

        #region Accesseur
        public System.Windows.Forms.TextBox TbMdp
        {
            get { return tbMdp; }
            set { tbMdp = value; }
        }
        public System.Windows.Forms.TextBox TbPseudo
        {
            get { return tbPseudo; }
            set { tbPseudo = value; }
        }
        public System.Windows.Forms.TextBox TbCommu
        {
            get { return tbCommu; }
            set { tbCommu = value; }
        }
        public System.Windows.Forms.TextBox TbEmail
        {
            get { return tbEmail; }
            set { tbEmail = value; }
        }
        #endregion
    }
}