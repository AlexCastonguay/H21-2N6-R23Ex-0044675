using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismeFigures
{
    public class Triangle : Figure
    {
        public Triangle(Point pOrigine, Size pTaille, Color pCouleur)
         : base(pOrigine, pTaille, pCouleur)
        {

        }

        public override void Dessiner(Graphics pobjGraphique)
        {
            pobjGraphique.DrawLine(m_objCrayon, m_origine.X, m_origine.Y,
                                m_origine.X - m_taille.Width / 2, m_origine.Y + m_taille.Height);
            pobjGraphique.DrawLine(m_objCrayon, m_origine.X - m_taille.Width / 2, m_origine.Y + m_taille.Height,
                                m_origine.X + m_taille.Width / 2, m_origine.Y + m_taille.Height);
            pobjGraphique.DrawLine(m_objCrayon, m_origine.X + m_taille.Width / 2, m_origine.Y + m_taille.Height, m_origine.X, m_origine.Y);
        }

    }
}
