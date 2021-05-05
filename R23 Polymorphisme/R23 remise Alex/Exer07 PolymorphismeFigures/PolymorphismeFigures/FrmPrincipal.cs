using System;
using System.Drawing;
using System.Windows.Forms;

namespace PolymorphismeFigures
{
    // TODO 01 : Visionner la capsule vidéo concernant cet exercice
    // TODO 02 : Ajouter les 4 classes dérivées pour les 4 types de figures
    //           Remarque : le code pour dessiner une figure se trouve dans "CodePourDessiner.txt"
    // TODO 03 : Ajouter la classe Dessin (voir le diagramme de classe)
    // TODO 04 : Décommenter les lignes de ce formulaire afin de faire fonctionner l'application
    public partial class FrmPrincipal : Form
    {
        private Dessin m_objDessin;
        /// ---------------------------------------------------------------------------------
        public FrmPrincipal()
        {
            InitializeComponent();
            cboTypeFigure.SelectedIndex = 0;
            m_objDessin = new Dessin();
        }

        #region panDessin_MouseDown
        public enum enuTypeFigure { Ellipse, Losange, Rectangle, Triangle }
        /// ---------------------------------------------------------------------------------
        private void panDessin_MouseDown(object sender, MouseEventArgs e)
        {
            Point origine = new Point(e.X,e.Y);
            Size taille = new Size((int)numLargeur.Value,(int)numHauteur.Value);
            Color couleur = panCouleur.BackColor;

            enuTypeFigure typeDeFigure = (enuTypeFigure)cboTypeFigure.SelectedIndex;
            Figure objNouvelleFigure = null;
            switch (typeDeFigure)
            {
                case enuTypeFigure.Ellipse:
                    //objNouvelleFigure = new Ellipse(origine, taille, couleur);
                    break;
                case enuTypeFigure.Losange:
                    //objNouvelleFigure = new Losange(origine, taille, couleur);
                    break;
                case enuTypeFigure.Rectangle:
                    //objNouvelleFigure = new Rectangle(origine, taille, couleur);
                    break;
                case enuTypeFigure.Triangle:
                    //objNouvelleFigure = new Triangle(origine, taille, couleur);
                    break;
            }
            //m_objDessin.Ajouter(objNouvelleFigure);
            //objNouvelleFigure.Dessiner(panDessin.CreateGraphics());
        }
        #endregion

        #region Méthodes de modification du dessin
        /// ---------------------------------------------------------------------------------
        private void panDessin_Paint(object sender, PaintEventArgs e)
        {
            m_objDessin.Dessiner(e.Graphics);
        }
        /// ---------------------------------------------------------------------------------
        private void btnSupprimerDerniere_Click(object sender, EventArgs e)
        {
            m_objDessin.SupprimerDerniereFigure();
            panDessin.Refresh();
        }
        /// ---------------------------------------------------------------------------------
        private void btnDeplacer_Click(object sender, EventArgs e)
        {
            m_objDessin.Deplacer((int)numDeplacementX.Value, (int)numDeplacementY.Value);
            panDessin.Refresh();
        }
        /// ---------------------------------------------------------------------------------
        private void btnAgrandir_Click(object sender, EventArgs e)
        {
            m_objDessin.Agrandir((int)numFacteurAgr.Value);
            panDessin.Refresh();
        }
        #endregion

        #region panCouleur_Click
        /// ---------------------------------------------------------------------------------
        private void panCouleur_Click(object sender, EventArgs e)
        {
            dlgCouleur.Color = panCouleur.BackColor;
            dlgCouleur.ShowDialog();
            panCouleur.BackColor = dlgCouleur.Color;
        }
        #endregion

        #region mnuFichierQuitter_Click
        /// ---------------------------------------------------------------------------------
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}

