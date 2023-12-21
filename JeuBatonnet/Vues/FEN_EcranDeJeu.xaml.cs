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
    /// Logique d'interaction pour FEN_EcranDeJeu.xaml
    /// </summary>
    public partial class FEN_EcranDeJeu : Window
    {
        public Partie PartieEnCours { get; set; }
        public FEN_EcranDeJeu(Partie p_partie)
        {
            InitializeComponent();
            PartieEnCours = p_partie;
            CreerBoutonsDansStackPanel(PartieEnCours.NbBatonnet);
            if(PartieEnCours.TourJoueurId == VariablesGlobales.Joueur.JoueurId)
            {
                LBL_JoueurActif.Content = "A vous de jouer ! ";
            }
            else
            {
                LBL_JoueurActif.Content = "Au tour de votre adversaire.";
            }
        }

        private void CreerBoutonsDansStackPanel(int nombreDeBoutons)
        {
            for (int i = 0; i < nombreDeBoutons; i++)
            {
                if(i < 10)
                {
                    Button nouveauBouton = new Button
                    {
                        Content = $"Bouton {i + 1}",
                        Width = 100,
                        Height = 30,
                        Margin = new Thickness(5)
                    };
                    nouveauBouton.Click += NouveauBoutonClick;
                    Stack1.Children.Add(nouveauBouton);
                }
                else
                {
                    Button nouveauBouton = new Button
                    {
                        Content = $"Bouton {i + 1}",
                        Width = 100,
                        Height = 30,
                        Margin = new Thickness(5)
                    };
                    nouveauBouton.Click += NouveauBoutonClick;
                    Stack2.Children.Add(nouveauBouton);
                }
            }
        }

        private void NouveauBoutonClick(object sender, RoutedEventArgs e)
        {
            Button boutonClique = sender as Button;
            if (boutonClique != null)
            {
                boutonClique.Visibility = Visibility.Hidden;
            }
        }

        private void EndTurn_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
