using System;

namespace HeritageClassique
{
    public class Personne
    {
        public string Nom { get; set; }
        public DateTime DateDeNaissance { get; set; }

        public Personne(string pNom, DateTime pDateDeNaissance)
        {
            Nom = pNom;
            DateDeNaissance = pDateDeNaissance;
        }

        public virtual string Infos
        {
            get
        {
                string premièreLigne = "Nom : " + Nom + "\n";
                string deuxièmeLigne = "Date de naissance : " + DateDeNaissance.ToString("le d MMMM yyyy") + "\n";

                return premièreLigne + deuxièmeLigne;
            }
        }
    }
}
