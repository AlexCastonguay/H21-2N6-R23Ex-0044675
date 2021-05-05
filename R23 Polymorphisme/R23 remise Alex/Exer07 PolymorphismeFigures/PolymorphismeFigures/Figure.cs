
using System.Drawing;

namespace PolymorphismeFigures
{
    public abstract class Figure
    {
        private const int TAILLE_CRAYON = 2;
        /// ----------------------------------------------------------------------------------
        protected Point m_origine;
        protected Size m_taille;
        protected Color m_couleur;
        protected Pen m_objCrayon;
        /// --------------------------------------------------------------------------------
        public Figure(Point pOrigine, Size pTaille, Color pCouleur)
        {
            m_origine = pOrigine;
            m_taille = pTaille;
            m_couleur = pCouleur;
            m_objCrayon = new Pen(m_couleur, TAILLE_CRAYON);
        }
        //------------------------------------------------------------------------------------------------
        public abstract void Dessiner(Graphics pobjGraphique);
        /// ------------------------------------------------------------------------------------------------
        public void Deplacer(int pDeplacementX, int pDeplacementY)
        {
            m_origine.X += pDeplacementX;
            m_origine.Y += pDeplacementY;
        }
        /// ------------------------------------------------------------------------------------------------
        public void Agrandir(int pFacteur)
        {
            m_origine.X = m_origine.X * pFacteur / 100;
            m_origine.Y = m_origine.Y * pFacteur / 100;
            m_taille.Width = m_taille.Width * pFacteur / 100;
            m_taille.Height = m_taille.Height * pFacteur / 100;
        }
    }
}
