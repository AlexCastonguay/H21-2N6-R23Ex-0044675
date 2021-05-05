namespace MiniFerme
{
    public class Cheval : Animal
    {
        #region Propriétés
        public decimal PrixLocation { get; set; }

        public override string Infos
        {
            get
            {
                return base.Infos + "Prix de location : " + PrixLocation.ToString("C0") + "/h";
            }
        }
        #endregion

        #region Constructeur
        public Cheval(string pNom, double pPoids, decimal pPrixLocation)
            :base(pNom,pPoids)
        {
            PrixLocation = pPrixLocation;
        }
        #endregion
   }
}
