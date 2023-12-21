using System;
using System.Collections.Generic;

namespace JeuBatonnet.Models;

public partial class CoupJoue
{
    public int CoupId { get; set; }

    public int PartieId { get; set; }

    public int JoueurId { get; set; }

    public int NbBatonnetRetire { get; set; }

    public DateTime? Temps { get; set; }

    public virtual Joueur Joueur { get; set; } = null!;

    public virtual Partie Partie { get; set; } = null!;
}
