using System;
using System.Windows.Forms;

namespace HeritageClassique
{
    // TODO 00 : Regarder la capsule vidéo avant ou en parallèle.
    //
    // TODO 01 : Remplacer la méthode ToString par une nouvelle méthode virtuelle nommée ObtenirInfos()
    //
    // TODO 02 : Redéfinir la méthode ObtenirInfos() dans les classes Etudiant et Employe
    //
    // TODO 03 : Remplacer dans ce formulaire les appels de la méthode ToString() par la méthode ObtenirInfos()
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnAfficherInfosPersonne_Click(object sender, EventArgs e)
        {
            Personne unePersonne = new Personne("Jean Lapointe", new DateTime(1950, 3, 6));

            MessageBox.Show(unePersonne.ObtenirInfos());
        }

        private void BtnAfficherInfosEtudiant_Click(object sender, EventArgs e)
        {
            Etudiant objEtudiant = new Etudiant("Louise Tremblay", new DateTime(1997, 7, 22),15464332);

            MessageBox.Show(objEtudiant.ObtenirInfos());
        }

        private void BtnAfficherInfosEmployé_Click(object sender, EventArgs e)
        {
            Employe objEmployé = new Employe("Germain Houde", new DateTime(1976, 1, 17), 55400);

            MessageBox.Show(objEmployé.ObtenirInfos());
        }
    }
}
