namespace PolymorphismeFigures
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
            this.panDessin = new System.Windows.Forms.Panel();
            this.cboTypeFigure = new System.Windows.Forms.ComboBox();
            this.lblTypeFigure = new System.Windows.Forms.Label();
            this.btnSupprimerDerniere = new System.Windows.Forms.Button();
            this.numLargeur = new System.Windows.Forms.NumericUpDown();
            this.numHauteur = new System.Windows.Forms.NumericUpDown();
            this.lblLargeur = new System.Windows.Forms.Label();
            this.lblHauteur = new System.Windows.Forms.Label();
            this.grpFigure = new System.Windows.Forms.GroupBox();
            this.panCouleur = new System.Windows.Forms.Panel();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.numDeplacementX = new System.Windows.Forms.NumericUpDown();
            this.numDeplacementY = new System.Windows.Forms.NumericUpDown();
            this.lblDeplacementX = new System.Windows.Forms.Label();
            this.lblDeplacementY = new System.Windows.Forms.Label();
            this.numFacteurAgr = new System.Windows.Forms.NumericUpDown();
            this.lblFacteurAgr = new System.Windows.Forms.Label();
            this.grpModification = new System.Windows.Forms.GroupBox();
            this.btnAgrandir = new System.Windows.Forms.Button();
            this.btnDeplacer = new System.Windows.Forms.Button();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgCouleur = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numLargeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHauteur)).BeginInit();
            this.grpFigure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeplacementX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeplacementY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFacteurAgr)).BeginInit();
            this.grpModification.SuspendLayout();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDessin
            // 
            this.panDessin.BackColor = System.Drawing.Color.White;
            this.panDessin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDessin.Location = new System.Drawing.Point(12, 100);
            this.panDessin.Name = "panDessin";
            this.panDessin.Size = new System.Drawing.Size(735, 459);
            this.panDessin.TabIndex = 2;
            this.panDessin.Paint += new System.Windows.Forms.PaintEventHandler(this.panDessin_Paint);
            this.panDessin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panDessin_MouseDown);
            // 
            // cboTypeFigure
            // 
            this.cboTypeFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeFigure.FormattingEnabled = true;
            this.cboTypeFigure.Items.AddRange(new object[] {
            "Ellipse",
            "Losange",
            "Rectangle",
            "Triangle"});
            this.cboTypeFigure.Location = new System.Drawing.Point(11, 34);
            this.cboTypeFigure.Name = "cboTypeFigure";
            this.cboTypeFigure.Size = new System.Drawing.Size(107, 21);
            this.cboTypeFigure.TabIndex = 1;
            // 
            // lblTypeFigure
            // 
            this.lblTypeFigure.AutoSize = true;
            this.lblTypeFigure.Location = new System.Drawing.Point(11, 18);
            this.lblTypeFigure.Name = "lblTypeFigure";
            this.lblTypeFigure.Size = new System.Drawing.Size(81, 13);
            this.lblTypeFigure.TabIndex = 0;
            this.lblTypeFigure.Text = "&Type de figure :";
            // 
            // btnSupprimerDerniere
            // 
            this.btnSupprimerDerniere.Location = new System.Drawing.Point(302, 16);
            this.btnSupprimerDerniere.Name = "btnSupprimerDerniere";
            this.btnSupprimerDerniere.Size = new System.Drawing.Size(92, 45);
            this.btnSupprimerDerniere.TabIndex = 10;
            this.btnSupprimerDerniere.Text = "Supprimer la dernière figure";
            this.btnSupprimerDerniere.UseVisualStyleBackColor = true;
            this.btnSupprimerDerniere.Click += new System.EventHandler(this.btnSupprimerDerniere_Click);
            // 
            // numLargeur
            // 
            this.numLargeur.Location = new System.Drawing.Point(124, 34);
            this.numLargeur.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numLargeur.Name = "numLargeur";
            this.numLargeur.Size = new System.Drawing.Size(47, 20);
            this.numLargeur.TabIndex = 11;
            this.numLargeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLargeur.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numHauteur
            // 
            this.numHauteur.Location = new System.Drawing.Point(177, 34);
            this.numHauteur.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numHauteur.Name = "numHauteur";
            this.numHauteur.Size = new System.Drawing.Size(47, 20);
            this.numHauteur.TabIndex = 12;
            this.numHauteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numHauteur.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblLargeur
            // 
            this.lblLargeur.AutoSize = true;
            this.lblLargeur.Location = new System.Drawing.Point(122, 18);
            this.lblLargeur.Name = "lblLargeur";
            this.lblLargeur.Size = new System.Drawing.Size(49, 13);
            this.lblLargeur.TabIndex = 13;
            this.lblLargeur.Text = "&Largeur :";
            // 
            // lblHauteur
            // 
            this.lblHauteur.AutoSize = true;
            this.lblHauteur.Location = new System.Drawing.Point(174, 18);
            this.lblHauteur.Name = "lblHauteur";
            this.lblHauteur.Size = new System.Drawing.Size(51, 13);
            this.lblHauteur.TabIndex = 14;
            this.lblHauteur.Text = "&Hauteur :";
            // 
            // grpFigure
            // 
            this.grpFigure.Controls.Add(this.panCouleur);
            this.grpFigure.Controls.Add(this.lblCouleur);
            this.grpFigure.Controls.Add(this.lblHauteur);
            this.grpFigure.Controls.Add(this.lblLargeur);
            this.grpFigure.Controls.Add(this.numHauteur);
            this.grpFigure.Controls.Add(this.numLargeur);
            this.grpFigure.Controls.Add(this.lblTypeFigure);
            this.grpFigure.Controls.Add(this.cboTypeFigure);
            this.grpFigure.Location = new System.Drawing.Point(12, 27);
            this.grpFigure.Name = "grpFigure";
            this.grpFigure.Size = new System.Drawing.Size(295, 67);
            this.grpFigure.TabIndex = 0;
            this.grpFigure.TabStop = false;
            this.grpFigure.Text = "Informations figure";
            // 
            // panCouleur
            // 
            this.panCouleur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panCouleur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panCouleur.Location = new System.Drawing.Point(234, 34);
            this.panCouleur.Name = "panCouleur";
            this.panCouleur.Size = new System.Drawing.Size(48, 21);
            this.panCouleur.TabIndex = 16;
            this.panCouleur.Click += new System.EventHandler(this.panCouleur_Click);
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(231, 18);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(49, 13);
            this.lblCouleur.TabIndex = 15;
            this.lblCouleur.Text = "&Couleur :";
            // 
            // numDeplacementX
            // 
            this.numDeplacementX.Location = new System.Drawing.Point(54, 19);
            this.numDeplacementX.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numDeplacementX.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numDeplacementX.Name = "numDeplacementX";
            this.numDeplacementX.Size = new System.Drawing.Size(47, 20);
            this.numDeplacementX.TabIndex = 15;
            this.numDeplacementX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numDeplacementY
            // 
            this.numDeplacementY.Location = new System.Drawing.Point(54, 41);
            this.numDeplacementY.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numDeplacementY.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numDeplacementY.Name = "numDeplacementY";
            this.numDeplacementY.Size = new System.Drawing.Size(47, 20);
            this.numDeplacementY.TabIndex = 16;
            this.numDeplacementY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDeplacementX
            // 
            this.lblDeplacementX.AutoSize = true;
            this.lblDeplacementX.Location = new System.Drawing.Point(14, 21);
            this.lblDeplacementX.Name = "lblDeplacementX";
            this.lblDeplacementX.Size = new System.Drawing.Size(39, 13);
            this.lblDeplacementX.TabIndex = 15;
            this.lblDeplacementX.Text = "Dpl X :";
            // 
            // lblDeplacementY
            // 
            this.lblDeplacementY.AutoSize = true;
            this.lblDeplacementY.Location = new System.Drawing.Point(14, 41);
            this.lblDeplacementY.Name = "lblDeplacementY";
            this.lblDeplacementY.Size = new System.Drawing.Size(39, 13);
            this.lblDeplacementY.TabIndex = 17;
            this.lblDeplacementY.Text = "Dpl Y :";
            // 
            // numFacteurAgr
            // 
            this.numFacteurAgr.Location = new System.Drawing.Point(249, 41);
            this.numFacteurAgr.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numFacteurAgr.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numFacteurAgr.Name = "numFacteurAgr";
            this.numFacteurAgr.Size = new System.Drawing.Size(47, 20);
            this.numFacteurAgr.TabIndex = 18;
            this.numFacteurAgr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numFacteurAgr.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblFacteurAgr
            // 
            this.lblFacteurAgr.AutoSize = true;
            this.lblFacteurAgr.Location = new System.Drawing.Point(181, 44);
            this.lblFacteurAgr.Name = "lblFacteurAgr";
            this.lblFacteurAgr.Size = new System.Drawing.Size(60, 13);
            this.lblFacteurAgr.TabIndex = 19;
            this.lblFacteurAgr.Text = "Facteur % :";
            // 
            // grpModification
            // 
            this.grpModification.Controls.Add(this.numFacteurAgr);
            this.grpModification.Controls.Add(this.btnAgrandir);
            this.grpModification.Controls.Add(this.numDeplacementY);
            this.grpModification.Controls.Add(this.numDeplacementX);
            this.grpModification.Controls.Add(this.btnDeplacer);
            this.grpModification.Controls.Add(this.lblFacteurAgr);
            this.grpModification.Controls.Add(this.btnSupprimerDerniere);
            this.grpModification.Controls.Add(this.lblDeplacementY);
            this.grpModification.Controls.Add(this.lblDeplacementX);
            this.grpModification.Location = new System.Drawing.Point(337, 27);
            this.grpModification.Name = "grpModification";
            this.grpModification.Size = new System.Drawing.Size(410, 67);
            this.grpModification.TabIndex = 1;
            this.grpModification.TabStop = false;
            this.grpModification.Text = "Modification des figures du dessin";
            // 
            // btnAgrandir
            // 
            this.btnAgrandir.Location = new System.Drawing.Point(180, 16);
            this.btnAgrandir.Name = "btnAgrandir";
            this.btnAgrandir.Size = new System.Drawing.Size(116, 23);
            this.btnAgrandir.TabIndex = 21;
            this.btnAgrandir.Text = "Agrandir";
            this.btnAgrandir.UseVisualStyleBackColor = true;
            this.btnAgrandir.Click += new System.EventHandler(this.btnAgrandir_Click);
            // 
            // btnDeplacer
            // 
            this.btnDeplacer.Location = new System.Drawing.Point(107, 16);
            this.btnDeplacer.Name = "btnDeplacer";
            this.btnDeplacer.Size = new System.Drawing.Size(67, 45);
            this.btnDeplacer.TabIndex = 20;
            this.btnDeplacer.Text = "Déplacer";
            this.btnDeplacer.UseVisualStyleBackColor = true;
            this.btnDeplacer.Click += new System.EventHandler(this.btnDeplacer_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(760, 24);
            this.mnuPrincipal.TabIndex = 21;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 571);
            this.Controls.Add(this.grpModification);
            this.Controls.Add(this.grpFigure);
            this.Controls.Add(this.panDessin);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polymorphisme Figures (Matériel)";
            ((System.ComponentModel.ISupportInitialize)(this.numLargeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHauteur)).EndInit();
            this.grpFigure.ResumeLayout(false);
            this.grpFigure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeplacementX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeplacementY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFacteurAgr)).EndInit();
            this.grpModification.ResumeLayout(false);
            this.grpModification.PerformLayout();
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panDessin;
        private System.Windows.Forms.ComboBox cboTypeFigure;
        private System.Windows.Forms.Label lblTypeFigure;
        private System.Windows.Forms.Button btnSupprimerDerniere;
        private System.Windows.Forms.NumericUpDown numLargeur;
        private System.Windows.Forms.NumericUpDown numHauteur;
        private System.Windows.Forms.Label lblLargeur;
        private System.Windows.Forms.Label lblHauteur;
        private System.Windows.Forms.GroupBox grpFigure;
        private System.Windows.Forms.NumericUpDown numDeplacementX;
        private System.Windows.Forms.NumericUpDown numDeplacementY;
        private System.Windows.Forms.Label lblDeplacementX;
        private System.Windows.Forms.Label lblDeplacementY;
        private System.Windows.Forms.NumericUpDown numFacteurAgr;
        private System.Windows.Forms.Label lblFacteurAgr;
        private System.Windows.Forms.GroupBox grpModification;
        private System.Windows.Forms.Button btnDeplacer;
        private System.Windows.Forms.Button btnAgrandir;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.Panel panCouleur;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.ColorDialog dlgCouleur;
    }
}

