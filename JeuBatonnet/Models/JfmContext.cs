using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JeuBatonnet.Models;

public partial class JfmContext : DbContext
{
    public JfmContext()
    {
    }

    public JfmContext(DbContextOptions<JfmContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CoupJoue> CoupJoues { get; set; }

    public virtual DbSet<Joueur> Joueurs { get; set; }

    public virtual DbSet<Partie> Parties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.29.13,1433\\MSSQLSERVER;User ID=sa;Password=erty64%;Database=JFM;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CoupJoue>(entity =>
        {
            entity.HasKey(e => e.CoupId).HasName("PK__CoupJoue__2DB4500D3B761278");

            entity.ToTable("CoupJoue");

            entity.Property(e => e.CoupId).HasColumnName("coup_id");
            entity.Property(e => e.JoueurId).HasColumnName("joueur_id");
            entity.Property(e => e.NbBatonnetRetire).HasColumnName("nb_batonnet_retire");
            entity.Property(e => e.PartieId).HasColumnName("partie_id");
            entity.Property(e => e.Temps)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("temps");

            entity.HasOne(d => d.Joueur).WithMany(p => p.CoupJoues)
                .HasForeignKey(d => d.JoueurId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CoupJoue__joueur__44FF419A");

            entity.HasOne(d => d.Partie).WithMany(p => p.CoupJoues)
                .HasForeignKey(d => d.PartieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CoupJoue__partie__440B1D61");
        });

        modelBuilder.Entity<Joueur>(entity =>
        {
            entity.HasKey(e => e.JoueurId).HasName("PK__Joueur__2196D67F55D1997C");

            entity.ToTable("Joueur");

            entity.Property(e => e.JoueurId).HasColumnName("joueur_id");
            entity.Property(e => e.DateNaissance)
                .HasColumnType("datetime")
                .HasColumnName("date_naissance");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.MotDePasse)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("mot_de_passe");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("prenom");
            entity.Property(e => e.Pseudo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pseudo");
            entity.Property(e => e.Telephone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("telephone");
        });

        modelBuilder.Entity<Partie>(entity =>
        {
            entity.HasKey(e => e.PartieId).HasName("PK__Partie__A8F7D7D47AA1FF4E");

            entity.ToTable("Partie");

            entity.Property(e => e.PartieId).HasColumnName("partie_id");
            entity.Property(e => e.EnCours)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("en_cours");
            entity.Property(e => e.Joueur1Id).HasColumnName("joueur1_id");
            entity.Property(e => e.Joueur2Id).HasColumnName("joueur2_id");
            entity.Property(e => e.NbBatonnet).HasColumnName("nb_batonnet");
            entity.Property(e => e.TourJoueurId).HasColumnName("tour_joueur_id");

            entity.HasOne(d => d.Joueur1).WithMany(p => p.PartieJoueur1s)
                .HasForeignKey(d => d.Joueur1Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Partie__joueur1___3E52440B");

            entity.HasOne(d => d.Joueur2).WithMany(p => p.PartieJoueur2s)
                .HasForeignKey(d => d.Joueur2Id)
                .HasConstraintName("FK__Partie__joueur2___3F466844");

            entity.HasOne(d => d.TourJoueur).WithMany(p => p.PartieTourJoueurs)
                .HasForeignKey(d => d.TourJoueurId)
                .HasConstraintName("FK__Partie__tour_jou__403A8C7D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
