namespace MiniFerme
{
    public enum enuStyleDeChien { Compagnie, Garde }
    public class Chien : Animal
    {
        #region Propriétés
        public enuStyleDeChien Style { get; set; }

        public override string Infos
        {
            get
            {
                return base.Infos + "Style de chien : " + Style;
            }
        }
        #endregion

        #region Constructeur
        public Chien(string pNom, double pPoids, enuStyleDeChien pStyle)
            :base(pNom,pPoids)
        {
            Style = pStyle;
        }
        #endregion
    }
}
