using JeuBatonnet.Models;
using Microsoft.EntityFrameworkCore;
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
            using (JfmContext jfmContext = new JfmContext())
            {
                if (nouvellePartie == null)
                {
                    throw new ArgumentNullException(nameof(nouvellePartie));
                }

                // Si les joueurs existent déjà, attachez-les au contexte
                if (nouvellePartie.Joueur1 != null && nouvellePartie.Joueur1.JoueurId > 0)
                {
                    jfmContext.Entry(nouvellePartie.Joueur1).State = EntityState.Unchanged;
                }

                if (nouvellePartie.Joueur2 != null && nouvellePartie.Joueur2.JoueurId > 0)
                {
                    jfmContext.Entry(nouvellePartie.Joueur2).State = EntityState.Unchanged;
                }

                jfmContext.Parties.Add(nouvellePartie);

                jfmContext.SaveChanges();

                return nouvellePartie.PartieId;
            }
        }

        public static void PlayerJoinedGame(Partie partieAUpdate)
        {
            using (JfmContext jfmContext = new JfmContext())
            {
                if (partieAUpdate == null)
                {
                    throw new ArgumentNullException(nameof(partieAUpdate));
                }

                // Récupérer la partie existante en fonction de l'ID
                var partieExistante = jfmContext.Parties.Find(partieAUpdate.PartieId);
                if (partieExistante == null)
                {
                    throw new InvalidOperationException($"La partie avec l'ID {partieAUpdate.PartieId} n'existe pas.");
                }

                // Mettre à jour joueur2Id
                partieExistante.Joueur2Id = partieAUpdate.Joueur2Id;

                // Enregistrer les modifications
                jfmContext.SaveChanges();
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
