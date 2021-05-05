namespace MiniFerme
{
    public class Vache : Animal
    {
        #region Propriétés
        public double Production { get; set; }
        public override string Infos
        {
            get
            {
                return base.Infos + "Production : " + Production.ToString("F1") + " litres";
            }
        }
        #endregion

        #region Constructeur
        public Vache(string pNom, double pPoids, double pProduction)
            :base(pNom,pPoids)
        {
            Production = pProduction;
        }
        #endregion
    }
}
