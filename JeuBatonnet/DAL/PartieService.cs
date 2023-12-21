using JeuBatonnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JeuBatonnet.DAL
{
    public static class PartieService
    {
        public static int CreerPartie(Partie nouvellePartie)
        {
            using(JfmContext jfmContext = new JfmContext())
            {
                if (nouvellePartie == null)
                {
                    throw new ArgumentNullException(nameof(nouvellePartie));
                }

                jfmContext.Parties.Add(nouvellePartie);

                jfmContext.SaveChanges();

                return nouvellePartie.PartieId;
            }
        }
        public static Partie SelectPartieByID(int id)
        {
            using (JfmContext jfmContext = new JfmContext())
            {
                Partie partieselect = jfmContext.Parties.Where(p => p.PartieId == id).ToList().Single();

                return partieselect;
            }
        }

        public static Partie VerifierPartie(int idPartie)
        {
            using (var context = new JfmContext())
            {
                return context.Parties.FirstOrDefault(p => p.PartieId == idPartie);
            }
        }
    }
}
