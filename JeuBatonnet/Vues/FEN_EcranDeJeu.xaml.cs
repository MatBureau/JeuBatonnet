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
    /// Logique d'interaction pour FEN_EcranDeJeu.xaml
    /// </summary>
    public partial class FEN_EcranDeJeu : Window
    {
        public Partie PartieEnCours { get; set; }
        public FEN_EcranDeJeu(Partie p_partie)
        {
            InitializeComponent();
            PartieEnCours = p_partie;
        }
    }
}
