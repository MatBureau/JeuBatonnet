using JeuBatonnet.DAL;
using JeuBatonnet.Models;
using JeuBatonnet.Utils;
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
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            string userName = tbx_user.Text;
            string password = tbx_password.Password;

            // Appelez la fonction SelectJoueur avec les valeurs de l'interface utilisateur
            Joueur joueurConnecte = ConnexionService.SelectJoueur(userName, password);

            if (joueurConnecte != null)
            {
                // Le joueur a été trouvé, vous pouvez effectuer des actions supplémentaires ici
                VariablesGlobales.Joueur = joueurConnecte;
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                // Le joueur n'a pas été trouvé ou le mot de passe est incorrect
                MessageBox.Show("Identifiant ou mot de passe incorrect.");
            }
        }
    }
 }
