using JeuBatonnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace JeuBatonnet.DAL
{
    public static class ConnexionService
    {
        public static Joueur SelectJoueur(string userName, string password)
        {
            using (JfmContext db = new JfmContext())
            {
                Joueur joueur = db.Joueurs.SingleOrDefault(j => j.Pseudo == userName);

                if (joueur != null && joueur.MotDePasse == password)
                {
                    return joueur;
                }
                return null;
            }
        }
    }
}
