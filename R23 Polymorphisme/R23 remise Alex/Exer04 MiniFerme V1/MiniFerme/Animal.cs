using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFerme
{
    public class Animal
    {
        #region propriété
        public string Nom { get; set; }

        public double Poids { get; set; }

        protected string Type
        {
            get
            {
                return base.ToString().Split('.')[1];
            }
        }

        public virtual string Infos
        {
            get
            {
                return "Type Anomal : " + Type + "\n" + "Nom : " + Nom + "\n" + "Poids : " + Poids + "\n";
            }
        }

        #endregion

        #region constructeur
        public Animal(string pNom, double pPoids)
        {
            Nom = pNom;
            Poids = pPoids;
        }

        #endregion

        #region Méthodes
        public override string ToString()
        {
            return Type + " : " + Nom;
        }
        #endregion
    }
}
