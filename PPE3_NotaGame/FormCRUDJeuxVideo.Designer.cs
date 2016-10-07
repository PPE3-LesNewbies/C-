using System.Windows.Forms;

namespace PPE3_NotaGame
{
    partial class FormCRUDJeuxVideo
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.lblClassification = new System.Windows.Forms.Label();
            this.lblEditeur = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbTitre = new System.Windows.Forms.TextBox();
            this.tbEditeur = new System.Windows.Forms.TextBox();
            this.numAnnee = new System.Windows.Forms.NumericUpDown();
            this.numClassification = new System.Windows.Forms.NumericUpDown();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblJeux = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAnnee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClassification)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(88, 108);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(34, 13);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Titre :";
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Location = new System.Drawing.Point(33, 147);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(89, 13);
            this.lblAnnee.TabIndex = 1;
            this.lblAnnee.Text = "Année de Sortie :";
            // 
            // lblClassification
            // 
            this.lblClassification.AutoSize = true;
            this.lblClassification.Location = new System.Drawing.Point(48, 195);
            this.lblClassification.Name = "lblClassification";
            this.lblClassification.Size = new System.Drawing.Size(74, 13);
            this.lblClassification.TabIndex = 2;
            this.lblClassification.Text = "Classification :";
            // 
            // lblEditeur
            // 
            this.lblEditeur.AutoSize = true;
            this.lblEditeur.Location = new System.Drawing.Point(76, 246);
            this.lblEditeur.Name = "lblEditeur";
            this.lblEditeur.Size = new System.Drawing.Size(46, 13);
            this.lblEditeur.TabIndex = 3;
            this.lblEditeur.Text = "Editeur :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(56, 295);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description :";
            // 
            // tbTitre
            // 
            this.tbTitre.Location = new System.Drawing.Point(128, 105);
            this.tbTitre.Name = "tbTitre";
            this.tbTitre.Size = new System.Drawing.Size(166, 20);
            this.tbTitre.TabIndex = 5;
            // 
            // tbEditeur
            // 
            this.tbEditeur.Location = new System.Drawing.Point(128, 243);
            this.tbEditeur.Name = "tbEditeur";
            this.tbEditeur.Size = new System.Drawing.Size(166, 20);
            this.tbEditeur.TabIndex = 6;
            // 
            // numAnnee
            // 
            this.numAnnee.Location = new System.Drawing.Point(129, 147);
            this.numAnnee.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numAnnee.Name = "numAnnee";
            this.numAnnee.Size = new System.Drawing.Size(73, 20);
            this.numAnnee.TabIndex = 7;
            // 
            // numClassification
            // 
            this.numClassification.Location = new System.Drawing.Point(129, 193);
            this.numClassification.Name = "numClassification";
            this.numClassification.Size = new System.Drawing.Size(73, 20);
            this.numClassification.TabIndex = 8;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(128, 292);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(166, 20);
            this.tbDescription.TabIndex = 9;
            // 
            // lblJeux
            // 
            this.lblJeux.AutoSize = true;
            this.lblJeux.Location = new System.Drawing.Point(166, 38);
            this.lblJeux.Name = "lblJeux";
            this.lblJeux.Size = new System.Drawing.Size(77, 13);
            this.lblJeux.TabIndex = 10;
            this.lblJeux.Text = "JEUX VIDEOS";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(79, 361);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(219, 361);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FormCRUDJeuxVideo
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(401, 427);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblJeux);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.numClassification);
            this.Controls.Add(this.numAnnee);
            this.Controls.Add(this.tbEditeur);
            this.Controls.Add(this.tbTitre);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblEditeur);
            this.Controls.Add(this.lblClassification);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.lblTitre);
            this.Name = "FormCRUDJeuxVideo";
            this.Text = "Ajouter/Modifier/Supprimer : Jeux vidéos";
            ((System.ComponentModel.ISupportInitialize)(this.numAnnee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClassification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Label lblClassification;
        private System.Windows.Forms.Label lblEditeur;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbTitre;

        public System.Windows.Forms.TextBox TbTitre1
        {
            get { return tbTitre; }
            set { tbTitre = value; }
        }
        private System.Windows.Forms.TextBox tbEditeur;
        private System.Windows.Forms.NumericUpDown numAnnee;
        private System.Windows.Forms.NumericUpDown numClassification;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblJeux;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;

        #region Accesseur
        public TextBox TbTitre
        {
            get
            {
                return tbTitre;
            }

            set
            {
                tbTitre = value;
            }
        }

        public TextBox TbEditeur
        {
            get
            {
                return tbEditeur;
            }

            set
            {
                tbEditeur = value;
            }
        }

        public NumericUpDown NumAnnee
        {
            get
            {
                return numAnnee;
            }

            set
            {
                numAnnee = value;
            }
        }

        public NumericUpDown NumClassification
        {
            get
            {
                return numClassification;
            }

            set
            {
                numClassification = value;
            }
        }

        public TextBox TbDescription
        {
            get
            {
                return tbDescription;
            }

            set
            {
                tbDescription = value;
            }
        }
        #endregion
    }
}