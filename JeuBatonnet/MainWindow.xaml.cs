using JeuBatonnet.DAL;
using JeuBatonnet.Models;
using JeuBatonnet.Utils;
using JeuBatonnet.Vues;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JeuBatonnet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_SearchGame_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(TBX_CodePartie.Text))
            {
                Partie partietrouvee =  PartieService.SelectPartieByID(int.Parse(TBX_CodePartie.Text));
                if(partietrouvee != null )
                {
                    partietrouvee.Joueur2 = VariablesGlobales.Joueur;
                    partietrouvee.Joueur2Id = VariablesGlobales.Joueur.JoueurId;
                    partietrouvee.EnCours = true;
                    PartieService.PlayerJoinedGame(partietrouvee);
                    FEN_EcranDeJeu game = new FEN_EcranDeJeu(partietrouvee);
                    game.Show();
                }
            }
        }

        private void BTN_CreateGame_Click(object sender, RoutedEventArgs e)
        {
            FEN_SalleAttente salle = new FEN_SalleAttente();
            salle.Show();
        }
    }
}
