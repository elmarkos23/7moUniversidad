using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFGetStarted.Models
{
  //esto se coloca al inicial en el cosole de nuget
  //Scaffold-DbContext "data source = HP-001; initial catalog = BDD_PRUEBA; integrated security = True;" microsoft.EntityFrameworkcore.sqlserver -OutPutDir Models
  public partial class DataBaseContext : DbContext
  {
    public DataBaseContext()
    {
    }

    public DataBaseContext(DbContextOptions<DataBaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Persona> Personas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer("data source = HP-001; initial catalog = BDD_PRUEBA; integrated security = True;");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

      modelBuilder.Entity<Persona>(entity =>
      {
        entity.ToTable("Persona");

        entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

        entity.Property(e => e.Identificacion)
                  .IsRequired()
                  .HasMaxLength(10)
                  .IsFixedLength(true);

        entity.Property(e => e.Nombres)
                  .IsRequired()
                  .HasMaxLength(100)
                  .IsUnicode(false);
      });

      OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
  }
}
