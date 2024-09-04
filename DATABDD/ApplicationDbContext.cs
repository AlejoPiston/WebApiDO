using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApiDO.DATABDD;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Boton> Botons { get; set; }

    public virtual DbSet<DatosFormu> DatosFormus { get; set; }

    public virtual DbSet<Mascota> Mascota { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Boton>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Boton__3213E83F84D68923");

            entity.ToTable("Boton");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FechaActualiza)
                .HasColumnType("datetime")
                .HasColumnName("fecha_actualiza");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
        });

        modelBuilder.Entity<DatosFormu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DatosFor__3213E83FE2C1F83A");

            entity.ToTable("DatosFormu");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FechaActulizacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_actulizacion");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
        });

        modelBuilder.Entity<Mascota>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mascota__3213E83FBB6651A3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FechaActualiza)
                .HasColumnType("datetime")
                .HasColumnName("fecha_actualiza");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdDatos).HasColumnName("idDatos");
            entity.Property(e => e.IdPersona).HasColumnName("id_persona");
            entity.Property(e => e.Inputdatovalor).HasColumnName("inputdatovalor");

            entity.HasOne(d => d.IdDatosNavigation).WithMany(p => p.Mascota)
                .HasForeignKey(d => d.IdDatos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Mascota__idDatos__3E52440B");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Mascota)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Mascota__id_pers__3F466844");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Persona__3213E83FB7B3EECD");

            entity.ToTable("Persona");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FechaActualiza)
                .HasColumnType("datetime")
                .HasColumnName("fecha_actualiza");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdDatos).HasColumnName("idDatos");
            entity.Property(e => e.IdPersona).HasColumnName("id_persona");
            entity.Property(e => e.Inputdatovalor).HasColumnName("inputdatovalor");

            entity.HasOne(d => d.IdDatosNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdDatos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Persona__idDatos__37A5467C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
