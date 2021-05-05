using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismeFigures
{
    public class Losange : Figure
    {
        public Losange(Point pOrigine, Size pTaille, Color pCouleur)
          : base(pOrigine, pTaille, pCouleur)
        {

        }

        public override void Dessiner(Graphics pobjGraphique)
        {
            Point[] tabPointsLosange = new Point[4];
            tabPointsLosange[0] = new Point(m_origine.X, m_origine.Y); ;
            tabPointsLosange[1] = new Point(m_origine.X - m_taille.Width / 2, m_origine.Y + m_taille.Height / 2);
            tabPointsLosange[2] = new Point(m_origine.X, m_origine.Y + m_taille.Height);
            tabPointsLosange[3] = new Point(m_origine.X + m_taille.Width / 2, m_origine.Y + m_taille.Height / 2);
            pobjGraphique.DrawPolygon(m_objCrayon, tabPointsLosange);
        }

    }
}
