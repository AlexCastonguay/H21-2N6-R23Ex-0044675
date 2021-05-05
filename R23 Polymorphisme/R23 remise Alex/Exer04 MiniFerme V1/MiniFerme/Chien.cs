using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFerme
{
    public class Chien : Animal
    {
        #region propriété
        

        private enuStyleDeChien m_Style;

        public enuStyleDeChien Style 
        {
            get { return m_Style;  }
            set { m_Style = value; }
        }

        #endregion

        #region Constructeur
        public Chien (string pNom, double pPoids, enuStyleDeChien pType)
            :base(pNom,pPoids)
        {
            m_Style = pType;
        }
        #endregion

        #region Methodes
        public override string Infos
        {
            get
            {
                return base.Infos + "Style de Chien : " + Style + "\n";
            }
        }
      
        #endregion

    }
}
