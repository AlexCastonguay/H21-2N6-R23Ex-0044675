using System;

namespace HeritageClassique
{

    public class Employe : Personne
    {
        public double Salaire { get; set; }

        public Employe(string pNom, DateTime pDateDeNaissance, double pSalaire)
            :base(pNom,pDateDeNaissance)
        {
            Salaire = pSalaire;
        }

        public override string ObtenirInfos()
      
        {
            string troisièmeLigne = "Salaire : " + Salaire.ToString("C0");

            return base.ObtenirInfos() + troisièmeLigne;
        }

    }
}
