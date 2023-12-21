using JeuBatonnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuBatonnet.DAL
{
    public static class JoueurService
    {
        public static Joueur GetJoueurByID(int id)
        {
            using (JfmContext db = new JfmContext())
            {
                return db.Joueurs.SingleOrDefault(j => j.JoueurId == id);
            }
        }
    }
}
