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
using System.Windows.Threading;

namespace JeuBatonnet.Vues
{
    /// <summary>
    /// Logique d'interaction pour FEN_SalleAttente.xaml
    /// </summary>
    public partial class FEN_SalleAttente : Window
    {
        private DispatcherTimer timer;
        private int partieID;
        public FEN_SalleAttente()
        {
            InitializeComponent();

            Partie nouvellePartie = new Partie();
            nouvellePartie.NbBatonnet = GenererNombreBatonnets();
            nouvellePartie.Joueur1 = VariablesGlobales.Joueur;
            nouvellePartie.EnCours = false;
            nouvellePartie.CoupJoues = new List<CoupJoue>();
            nouvellePartie.TourJoueur = VariablesGlobales.Joueur;
            nouvellePartie.TourJoueurId = VariablesGlobales.Joueur.JoueurId;
            nouvellePartie.PartieId = PartieService.CreerPartie(nouvellePartie);
            partieID = nouvellePartie.PartieId;
            LBL_IDPartie.Content = "ID de partie : " + nouvellePartie.PartieId;

            // timer qui va check si un deuxième joueur rejoins
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public int GenererNombreBatonnets()
        {
            Random random = new Random();
            return random.Next(16, 22);
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            var partie = PartieService.VerifierPartie(partieID);
            if (partie != null && partie.Joueur2Id != null)
            {
                timer.Stop();
                MessageBox.Show("Un joueur a rejoint la partie !");
                FEN_EcranDeJeu game = new FEN_EcranDeJeu(partie);
                game.Show();
                this.Close();
            }
        }  
    }
}
