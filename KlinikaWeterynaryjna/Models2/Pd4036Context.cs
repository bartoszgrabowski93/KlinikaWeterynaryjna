using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KlinikaWeterynaryjna.Models2;

public partial class Pd4036Context : DbContext
{
    public Pd4036Context()
    {
    }

    public Pd4036Context(DbContextOptions<Pd4036Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Pracownik> Pracowniks { get; set; }

    public virtual DbSet<Uzytkownicy> Uzytkownicies { get; set; }

    public virtual DbSet<Uzytkownik> Uzytkowniks { get; set; }

    public virtual DbSet<Wlasciciel> Wlasciciels { get; set; }

    public virtual DbSet<Zwierzetum> Zwierzeta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=db-mssql.pjwstk.edu.pl; Initial Catalog=PD4036;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pracownik>(entity =>
        {
            entity.HasKey(e => e.IdPracownika).HasName("PK__Pracowni__61B351049CAE1B4D");

            entity.ToTable("Pracownik");

            entity.Property(e => e.DataUrodzenia).HasColumnType("date");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Imie).HasMaxLength(100);
            entity.Property(e => e.Nazwisko).HasMaxLength(100);
        });

        modelBuilder.Entity<Uzytkownicy>(entity =>
        {
            entity.HasKey(e => e.IdUzytkownicy).HasName("PK__Uzytkown__614EEF7CB0E42DAD");

            entity.ToTable("Uzytkownicy");

            entity.Property(e => e.IdUzytkownicy).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Haslo).HasMaxLength(100);
            entity.Property(e => e.Login).HasMaxLength(100);
        });

        modelBuilder.Entity<Uzytkownik>(entity =>
        {
            entity.HasKey(e => e.IdUzytkownik).HasName("PK__Uzystkow__EE90460387B991FC");

            entity.ToTable("Uzytkownik");

            entity.Property(e => e.Haslo).HasMaxLength(100);
            entity.Property(e => e.Login).HasMaxLength(100);
            entity.Property(e => e.Rola).HasMaxLength(100);
        });

        modelBuilder.Entity<Wlasciciel>(entity =>
        {
            entity.HasKey(e => e.IdWlasciciel).HasName("PK__Wlascici__99CDC5A72D2116EC");

            entity.ToTable("Wlasciciel");

            entity.Property(e => e.IdWlasciciel).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Imie).HasMaxLength(100);
            entity.Property(e => e.Nazwisko).HasMaxLength(100);
            entity.Property(e => e.Telefon).HasMaxLength(100);
        });

        modelBuilder.Entity<Zwierzetum>(entity =>
        {
            entity.HasKey(e => e.IdZwierzeta).HasName("PK__Zwierzet__3F8E7085511E9889");

            entity.Property(e => e.DataOstWizyty).HasColumnType("date");
            entity.Property(e => e.Gatunek).HasMaxLength(100);
            entity.Property(e => e.Nazwa).HasMaxLength(100);

            entity.HasOne(d => d.IdWlascicielNavigation).WithMany(p => p.Zwierzeta)
                .HasForeignKey(d => d.IdWlasciciel)
                .HasConstraintName("FK__Zwierzeta__IdWla__35BCFE0A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
