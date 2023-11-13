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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxJeu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxJeu
            // 
            this.gbxJeu.Controls.Add(this.label2);
            this.gbxJeu.Controls.Add(this.label1);
            this.gbxJeu.Location = new System.Drawing.Point(440, 72);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenu sur mon jeu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "c \'est parti";
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
            this.gbxJeu.ResumeLayout(false);
            this.gbxJeu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxJeu;
        private System.Windows.Forms.Button btnAfficherCacher;
        private System.Windows.Forms.Label lblInfoClic;
        private System.Windows.Forms.Label lblClic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

