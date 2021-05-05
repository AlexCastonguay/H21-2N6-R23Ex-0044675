namespace MiniFerme
{
    public abstract class Animal
    {
        #region Propriétés
        public string Nom { get; set; }
        public double Poids { get; set; }

        protected string Type
        {
            get
            {
                return base.ToString().Split('.')[1];
            }
        }

        public virtual string Infos {
            get
            {
                return "Type Animal : " + Type + "\n" + "Nom : " + Nom + "\n" + "Poids : " + Poids + " kg \n";
            }
        }
        #endregion

        #region Constructeur
        public Animal(string pNom, double pPoids)
        {
            Nom = pNom;
            Poids = pPoids;
        }
        #endregion

        #region Méthode
        public override string ToString()
        {
            return Type + " : " + Nom;
        }
        #endregion
    }
}
