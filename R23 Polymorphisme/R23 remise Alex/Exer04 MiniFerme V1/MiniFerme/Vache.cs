using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFerme
{
    public class Vache : Animal
    {
        #region
        public double Production { get; set; }

        #endregion

        #region Constructeur
        public Vache (string pNom, double pPoids, double pProduction)
            :base(pNom,pPoids)
        {
            Production = pProduction;
        }
        #endregion

        #region Méthode
        public override string Infos
        {
            get
            {
                return base.Infos + "Production : " + Production + " litres" + "\n";
            }
        }

        #endregion

    }
}
