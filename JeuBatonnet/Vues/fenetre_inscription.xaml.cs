using JeuBatonnet.DAL;
using JeuBatonnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JeuBatonnet.Vues
{
    /// <summary>
    /// Logique d'interaction pour fenetre_inscription.xaml
    /// </summary>
    public partial class fenetre_inscription : Window
    {
        public fenetre_inscription()
        {
            InitializeComponent();
        }
        private void BTN_Inscription_Click(object sender, RoutedEventArgs e)
        {
            // Récupérer les valeurs entrées par l'utilisateur
            string nom = TBX_Nom.Text;
            string prenom = TBX_Prenom.Text;
            string pseudo = TBX_Pseudo.Text;
            string email = TBX_Mail.Text;
            string telephone = TBX_Telephone.Text;
            DateTime dateNaissance = DateTime.Now;
            string motDePasse = TBX_Mdp.Password;

            // Ajoutez ici la logique de validation des données
            if (motDePasse.Length < 6) // Exemple : exige au moins 6 caractères
    {
        MessageBox.Show("Le mot de passe doit contenir au moins 6 caractères.");
        return;
    }

            // Exemple simple : vérification si les champs ne sont pas vides
            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(pseudo) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telephone) || dateNaissance == DateTime.MinValue ||
                string.IsNullOrEmpty(motDePasse))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }
            Joueur nouvelUtilisateur = new Joueur
            {
                Nom = nom,
                Prenom = prenom,
                Pseudo = pseudo,
                Email = email,
                Telephone = telephone,
                DateNaissance = dateNaissance,
                MotDePasse = motDePasse
            };

            InscriptionService.InsertUser(nouvelUtilisateur);
            // Vous devriez également ajouter des vérifications plus avancées, par exemple, si l'email est unique, etc.

            // Si l'enregistrement réussit, vous pouvez naviguer vers la page de connexion ou effectuer d'autres actions
            MessageBox.Show("Inscription réussie !");

            // Exemple : Navigation vers la page de connexion
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
            this.Close();
        }



    }
}
