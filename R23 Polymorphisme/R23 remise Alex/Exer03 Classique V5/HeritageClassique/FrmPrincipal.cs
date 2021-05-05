using System;
using System.Windows.Forms;

namespace HeritageClassique
{
    public partial class FrmPrincipal : Form
    {
        // TODO 00 : Regarder la capsule vidéo avant ou en parallèle.
        //
        // TODO 01 : Ajouter une méthode AfficherInfos() qui va prendre un paramètre de type Personne. 
        //           Cette méthode devra inclure uniquement ceci : MessageBox.Show(pPersonne.ToString());
        //
        // TODO 02 : Appeler la méthode AfficherInfos avec un objet Etudiant ainsi qu'avec un Employe
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnAfficherInfosPersonne_Click(object sender, EventArgs e)
        {
            Personne objPersonne = new Personne("Jean Lapointe", new DateTime(1950, 3, 6));

            AfficherInfos(objPersonne);
        }

        private void BtnAfficherInfosEtudiant_Click(object sender, EventArgs e)
        {
            Etudiant objEtudiant = new Etudiant("Louise Tremblay", new DateTime(1997, 7, 22),15464332);

            AfficherInfos(objEtudiant);
        }

        private void BtnAfficherInfosEmployé_Click(object sender, EventArgs e)
        {
            Employe objEmployé = new Employe("Germain Houde", new DateTime(1976, 1, 17), 55400);

            AfficherInfos(objEmployé);
        }
       private void AfficherInfos(Personne pPersonne)
        {
            MessageBox.Show(pPersonne.ToString());
        }
    }
}
