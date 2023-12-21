using System;
using System.Collections.Generic;

namespace JeuBatonnet.Models;

public partial class Joueur
{
    public int JoueurId { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Pseudo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public DateTime DateNaissance { get; set; }

    public string MotDePasse { get; set; } = null!;

    public virtual ICollection<CoupJoue> CoupJoues { get; set; } = new List<CoupJoue>();

    public virtual ICollection<Partie> PartieJoueur1s { get; set; } = new List<Partie>();

    public virtual ICollection<Partie> PartieJoueur2s { get; set; } = new List<Partie>();

    public virtual ICollection<Partie> PartieTourJoueurs { get; set; } = new List<Partie>();
}
