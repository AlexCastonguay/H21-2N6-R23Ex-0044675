using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniFerme
{
    // TODO 01 : Ajouter les 4 classes manquantes au projet (voir la capsule vidéo)
    // TODO 02 : Enlever les commentaires dans le constructeur du formulaire
    // TODO 03 : Compléter le code des gestionnaires d'événements suivants :
    //          LstAnimaux_SelectedIndexChanged
    //          BtnMélanger_Click
    //          
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            // On va créer les 3 chevaux et les ajouter dans lstAnimaux
            Cheval objCheval1 = new Cheval("Twix", 652, 125);
            Cheval objCheval2 = new Cheval("Tornade", 735, 100);
            Cheval objCheval3 = new Cheval("Lucky", 444, 200);


            lstAnimaux.Items.Add(objCheval1);
            lstAnimaux.Items.Add(objCheval2);
            lstAnimaux.Items.Add(objCheval3);

            //// on va créer les 2 chiens...
            Chien objChien1 = new Chien("Rex", 40, enuStyleDeChien.Garde);
            Chien objChien2 = new Chien("Goofy", 16, enuStyleDeChien.Compagnie);

            

            lstAnimaux.Items.Add(objChien1);
            lstAnimaux.Items.Add(objChien2);

            //// on va créer les 4 vaches...
            Vache objVache1 = new Vache("Margot", 775, 26);
            Vache objVache2 = new Vache("Betty", 786, 23.5);
            Vache objVache3 = new Vache("Rosette", 752, 20);
            Vache objVache4 = new Vache("Réglisse", 790, 24);

            lstAnimaux.Items.Add(objVache1);
            lstAnimaux.Items.Add(objVache2);
            lstAnimaux.Items.Add(objVache3);
            lstAnimaux.Items.Add(objVache4);
        }

        private void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LstAnimaux_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAnimaux.SelectedIndex != -1)
            { 
                Animal objAnimalSélectionné = (Animal)lstAnimaux.SelectedItem;
                MessageBox.Show(objAnimalSélectionné.Infos);
            }
        }

        private void BtnMélanger_Click(object sender, EventArgs e)
        {
            lstAnimaux.SelectedIndex = -1;
            Random objRandom = new Random();
            for (int index = 0; index < lstAnimaux.Items.Count; index++)
            {
                int index1 = objRandom.Next(0, lstAnimaux.Items.Count);
                int index2 = objRandom.Next(0, lstAnimaux.Items.Count);
                Animal temp = (Animal)lstAnimaux.Items[index1];
                lstAnimaux.Items[index1] = lstAnimaux.Items[index2];
                lstAnimaux.Items[index2] = temp;

            }
        }
    }
}
