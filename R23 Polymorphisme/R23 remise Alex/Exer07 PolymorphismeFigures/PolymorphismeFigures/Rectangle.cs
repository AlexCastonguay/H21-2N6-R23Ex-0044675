using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismeFigures
{
    public class Rectangle : Figure
    {
        public Rectangle(Point pOrigine, Size pTaille, Color pCouleur)
          : base(pOrigine, pTaille, pCouleur)
        {
        }

        public override void Dessiner(Graphics pobjGraphique)
        {
            pobjGraphique.DrawRectangle(m_objCrayon, m_origine.X, m_origine.Y, m_taille.Width, m_taille.Height);
        }
    }
}
