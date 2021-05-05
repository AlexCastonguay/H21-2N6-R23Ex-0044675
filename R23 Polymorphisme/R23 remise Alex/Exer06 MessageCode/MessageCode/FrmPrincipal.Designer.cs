namespace MessageCode
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
            this.txtMessageNonEncodé = new System.Windows.Forms.TextBox();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.lblMessages = new System.Windows.Forms.Label();
            this.BtnEncodageSimple = new System.Windows.Forms.Button();
            this.BtnEncodageMoyen = new System.Windows.Forms.Button();
            this.BtEncodageComplexe = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessageNonEncodé
            // 
            this.txtMessageNonEncodé.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageNonEncodé.Location = new System.Drawing.Point(16, 246);
            this.txtMessageNonEncodé.Name = "txtMessageNonEncodé";
            this.txtMessageNonEncodé.Size = new System.Drawing.Size(259, 26);
            this.txtMessageNonEncodé.TabIndex = 0;
            this.txtMessageNonEncodé.Text = "Bonjour à tous !";
            // 
            // lstMessages
            // 
            this.lstMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.ItemHeight = 20;
            this.lstMessages.Location = new System.Drawing.Point(291, 46);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(257, 304);
            this.lstMessages.TabIndex = 1;
            this.lstMessages.SelectedIndexChanged += new System.EventHandler(this.LstMessages_SelectedIndexChanged);
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Location = new System.Drawing.Point(288, 30);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(137, 13);
            this.lblMessages.TabIndex = 2;
            this.lblMessages.Text = "Liste des messages codés :";
            // 
            // BtnEncodageSimple
            // 
            this.BtnEncodageSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncodageSimple.Location = new System.Drawing.Point(16, 46);
            this.BtnEncodageSimple.Name = "BtnEncodageSimple";
            this.BtnEncodageSimple.Size = new System.Drawing.Size(259, 43);
            this.BtnEncodageSimple.TabIndex = 3;
            this.BtnEncodageSimple.Text = "Ajouter un message avec un encodage simple";
            this.BtnEncodageSimple.UseVisualStyleBackColor = true;
            this.BtnEncodageSimple.Click += new System.EventHandler(this.BtnEncodageSimple_Click);
            // 
            // BtnEncodageMoyen
            // 
            this.BtnEncodageMoyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncodageMoyen.Location = new System.Drawing.Point(16, 105);
            this.BtnEncodageMoyen.Name = "BtnEncodageMoyen";
            this.BtnEncodageMoyen.Size = new System.Drawing.Size(259, 43);
            this.BtnEncodageMoyen.TabIndex = 4;
            this.BtnEncodageMoyen.Text = "Ajouter un message avec un encodage moyen";
            this.BtnEncodageMoyen.UseVisualStyleBackColor = true;
            this.BtnEncodageMoyen.Click += new System.EventHandler(this.BtnEncodageMoyen_Click);
            // 
            // BtEncodageComplexe
            // 
            this.BtEncodageComplexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEncodageComplexe.Location = new System.Drawing.Point(16, 164);
            this.BtEncodageComplexe.Name = "BtEncodageComplexe";
            this.BtEncodageComplexe.Size = new System.Drawing.Size(259, 43);
            this.BtEncodageComplexe.TabIndex = 5;
            this.BtEncodageComplexe.Text = "Ajouter un message avec un encodage complexe";
            this.BtEncodageComplexe.UseVisualStyleBackColor = true;
            this.BtEncodageComplexe.Click += new System.EventHandler(this.BtEncodageComplexe_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(14, 230);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(117, 13);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Un nouveau message :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFichierQuitter});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // MnuFichierQuitter
            // 
            this.MnuFichierQuitter.Name = "MnuFichierQuitter";
            this.MnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.MnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.MnuFichierQuitter.Text = "&Quitter";
            this.MnuFichierQuitter.Click += new System.EventHandler(this.MnuFichierQuitter_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 376);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.BtEncodageComplexe);
            this.Controls.Add(this.BtnEncodageMoyen);
            this.Controls.Add(this.BtnEncodageSimple);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.txtMessageNonEncodé);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageCodé (Matériel)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessageNonEncodé;
        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Button BtnEncodageSimple;
        private System.Windows.Forms.Button BtnEncodageMoyen;
        private System.Windows.Forms.Button BtEncodageComplexe;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuFichierQuitter;
    }
}

