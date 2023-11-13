namespace TrouveMot
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxJeu = new System.Windows.Forms.GroupBox();
            this.btnAfficherCacher = new System.Windows.Forms.Button();
            this.lblInfoClic = new System.Windows.Forms.Label();
            this.lblClic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gbxJeu
            // 
            this.gbxJeu.Location = new System.Drawing.Point(468, 76);
            this.gbxJeu.Name = "gbxJeu";
            this.gbxJeu.Size = new System.Drawing.Size(273, 159);
            this.gbxJeu.TabIndex = 0;
            this.gbxJeu.TabStop = false;
            this.gbxJeu.Text = "Groupe box pour afficher le jeu";
            this.gbxJeu.Visible = false;
            // 
            // btnAfficherCacher
            // 
            this.btnAfficherCacher.Location = new System.Drawing.Point(112, 105);
            this.btnAfficherCacher.Name = "btnAfficherCacher";
            this.btnAfficherCacher.Size = new System.Drawing.Size(130, 53);
            this.btnAfficherCacher.TabIndex = 1;
            this.btnAfficherCacher.Text = "Afficher / Cacher";
            this.btnAfficherCacher.UseVisualStyleBackColor = true;
            this.btnAfficherCacher.Click += new System.EventHandler(this.btnAfficherCacher_Click);
            // 
            // lblInfoClic
            // 
            this.lblInfoClic.AutoSize = true;
            this.lblInfoClic.Location = new System.Drawing.Point(103, 227);
            this.lblInfoClic.Name = "lblInfoClic";
            this.lblInfoClic.Size = new System.Drawing.Size(119, 16);
            this.lblInfoClic.TabIndex = 2;
            this.lblInfoClic.Text = "Nombre de clic(s) :";
            // 
            // lblClic
            // 
            this.lblClic.AutoSize = true;
            this.lblClic.Location = new System.Drawing.Point(261, 225);
            this.lblClic.Name = "lblClic";
            this.lblClic.Size = new System.Drawing.Size(14, 16);
            this.lblClic.TabIndex = 3;
            this.lblClic.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblClic);
            this.Controls.Add(this.lblInfoClic);
            this.Controls.Add(this.btnAfficherCacher);
            this.Controls.Add(this.gbxJeu);
            this.Name = "Form1";
            this.Text = "Le Trouve Mot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxJeu;
        private System.Windows.Forms.Button btnAfficherCacher;
        private System.Windows.Forms.Label lblInfoClic;
        private System.Windows.Forms.Label lblClic;
    }
}

