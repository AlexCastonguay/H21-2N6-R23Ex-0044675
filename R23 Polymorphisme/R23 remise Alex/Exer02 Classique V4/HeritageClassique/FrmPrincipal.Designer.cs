namespace HeritageClassique
{
    partial class FrmPrincipal
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
            this.BtnAfficherInfosPersonne = new System.Windows.Forms.Button();
            this.BtnAfficherInfosEtudiant = new System.Windows.Forms.Button();
            this.BtnAfficherInfosEmployé = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAfficherInfosPersonne
            // 
            this.BtnAfficherInfosPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAfficherInfosPersonne.Location = new System.Drawing.Point(28, 37);
            this.BtnAfficherInfosPersonne.Name = "BtnAfficherInfosPersonne";
            this.BtnAfficherInfosPersonne.Size = new System.Drawing.Size(613, 34);
            this.BtnAfficherInfosPersonne.TabIndex = 0;
            this.BtnAfficherInfosPersonne.Text = "1-) Afficher les informations d\'une personne";
            this.BtnAfficherInfosPersonne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAfficherInfosPersonne.UseVisualStyleBackColor = true;
            this.BtnAfficherInfosPersonne.Click += new System.EventHandler(this.BtnAfficherInfosPersonne_Click);
            // 
            // BtnAfficherInfosEtudiant
            // 
            this.BtnAfficherInfosEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAfficherInfosEtudiant.Location = new System.Drawing.Point(28, 85);
            this.BtnAfficherInfosEtudiant.Name = "BtnAfficherInfosEtudiant";
            this.BtnAfficherInfosEtudiant.Size = new System.Drawing.Size(613, 34);
            this.BtnAfficherInfosEtudiant.TabIndex = 1;
            this.BtnAfficherInfosEtudiant.Text = "2-) Afficher les informations d\'un étudiant";
            this.BtnAfficherInfosEtudiant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAfficherInfosEtudiant.UseVisualStyleBackColor = true;
            this.BtnAfficherInfosEtudiant.Click += new System.EventHandler(this.BtnAfficherInfosEtudiant_Click);
            // 
            // BtnAfficherInfosEmployé
            // 
            this.BtnAfficherInfosEmployé.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAfficherInfosEmployé.Location = new System.Drawing.Point(28, 133);
            this.BtnAfficherInfosEmployé.Name = "BtnAfficherInfosEmployé";
            this.BtnAfficherInfosEmployé.Size = new System.Drawing.Size(613, 34);
            this.BtnAfficherInfosEmployé.TabIndex = 2;
            this.BtnAfficherInfosEmployé.Text = "3-) Afficher les informations d\'un employé";
            this.BtnAfficherInfosEmployé.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAfficherInfosEmployé.UseVisualStyleBackColor = true;
            this.BtnAfficherInfosEmployé.Click += new System.EventHandler(this.BtnAfficherInfosEmployé_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 195);
            this.Controls.Add(this.BtnAfficherInfosEmployé);
            this.Controls.Add(this.BtnAfficherInfosEtudiant);
            this.Controls.Add(this.BtnAfficherInfosPersonne);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Héritage Classique V4 (Matériel)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAfficherInfosPersonne;
        private System.Windows.Forms.Button BtnAfficherInfosEtudiant;
        private System.Windows.Forms.Button BtnAfficherInfosEmployé;
    }
}

