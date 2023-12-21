using JeuBatonnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuBatonnet.DAL
{
    public static class InscriptionService
    {
        public static void InsertUser(Joueur joueurToAdd)
        {
            using(JfmContext db = new JfmContext())
            {
                db.Joueurs.Add(joueurToAdd);
                db.SaveChanges();
            }
        }
    }
}
    