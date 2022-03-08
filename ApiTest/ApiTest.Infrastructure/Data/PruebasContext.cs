using System;
using ApiTest.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiTest.Infrastructure.Data
{
    public partial class PruebasContext : DbContext
    {
        public PruebasContext()
        {
        }

        public PruebasContext(DbContextOptions<PruebasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.CodCliente)
                    .HasName("PK__Cliente__DF8324D7361C355A");

                entity.ToTable("Cliente", "Adm");

                entity.Property(e => e.Abreviatura)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSap)
                    .HasColumnName("CodigoSAP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoFacturacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InactivoDesde).HasColumnType("datetime");

                entity.Property(e => e.NombreCompleto)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCorto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Ruc)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
