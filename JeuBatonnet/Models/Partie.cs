using System;
using System.Collections.Generic;

namespace JeuBatonnet.Models;

public partial class Partie
{
    public int PartieId { get; set; }

    public int Joueur1Id { get; set; }

    public int? Joueur2Id { get; set; }

    public int? TourJoueurId { get; set; }

    public int NbBatonnet { get; set; }

    public bool? EnCours { get; set; }

    public virtual ICollection<CoupJoue> CoupJoues { get; set; } = new List<CoupJoue>();

    public virtual Joueur Joueur1 { get; set; } = null!;

    public virtual Joueur? Joueur2 { get; set; }

    public virtual Joueur? TourJoueur { get; set; }
}
