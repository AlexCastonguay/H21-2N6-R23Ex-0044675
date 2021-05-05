using System;
using System.Windows.Forms;

namespace MessageCode
{
    // TODO 00 : Une classe nommée OutilsEncodage est disponible pour utilisation
    // TODO 01 : Visionner la capsule vidéo portant sur cet exercice
    // TODO 02 : Ajouter les 4 classes manquantes à partir de la capsule vidéo
    // TODO 03 : Décommenter le code dans le formulaire et faire fonctionner le programme
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            // Exemple d'appel d'une méthode statique
            string reponse = OutilsEncodage.EffectuerUnEncodageSimple("Bonjour");
        }

        private void BtnEncodageSimple_Click(object sender, EventArgs e)
        {
            MessageSimple objMessage = new MessageSimple(txtMessageNonEncodé.Text);
            lstMessages.Items.Add(objMessage);
        }

        private void BtnEncodageMoyen_Click(object sender, EventArgs e)
        {
            MessageMoyen objMessage = new MessageMoyen(txtMessageNonEncodé.Text);
            lstMessages.Items.Add(objMessage);
        }

        private void BtEncodageComplexe_Click(object sender, EventArgs e)
        {
            MessageComplexe objMessage = new MessageComplexe(txtMessageNonEncodé.Text);
            lstMessages.Items.Add(objMessage);
        }

        private void LstMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMessages.SelectedIndex != -1)
            {
                Message objMessage = (Message)lstMessages.SelectedItem;
                string premièreLigne = "Message non encodé : " + objMessage.MessageNonEncodé + "\n";
                string deuxièmeLigne = "Message encodé : " + objMessage.MessageEncodé;
                MessageBox.Show(premièreLigne + deuxièmeLigne);
            }
        }

        private void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
