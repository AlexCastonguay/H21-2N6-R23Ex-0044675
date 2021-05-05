using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFerme
{
    public class Cheval : Animal
    {
        #region propriété
        public decimal PrixLocation { get; set; }

        #endregion

        #region Constructeur
        public Cheval(string pNom, double pPoids, decimal pPrixLocation)
            :base(pNom,pPoids)
        {
            PrixLocation = pPrixLocation;
        }
        #endregion

        #region Methodes
        public override string Infos
        {
            get
            {
                return base.Infos + "Prix de location : " + PrixLocation.ToString("C0") +"/h"+ "\n";
            }
        }

        #endregion
    }
}
