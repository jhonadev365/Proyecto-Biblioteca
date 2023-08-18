using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CondoriApazaJhonatan_2doParcial.Models.libroModelo
{
    public partial class ExamenLibroContext : DbContext
    {
        public ExamenLibroContext()
        {
        }

        public ExamenLibroContext(DbContextOptions<ExamenLibroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Libro> Libro { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-49HA4QV;Initial Catalog=ExamenLibro;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>(entity =>
            {
                entity.HasKey(e => e.Isbn)
                    .HasName("PK__libro__447D36EB1AD9D16E");

                entity.ToTable("libro");

                entity.Property(e => e.Isbn)
                    .HasColumnName("ISBN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Autor)
                    .HasColumnName("autor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Año)
                    .HasColumnName("año")
                    .HasColumnType("date");

                entity.Property(e => e.Edicion)
                    .HasColumnName("edicion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Editorial)
                    .HasColumnName("editorial")
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
