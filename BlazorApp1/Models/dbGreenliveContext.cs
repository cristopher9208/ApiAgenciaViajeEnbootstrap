using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorApp1.Models
{
    public partial class dbGreenliveContext : DbContext
    {
        public dbGreenliveContext()
        {
        }

        public dbGreenliveContext(DbContextOptions<dbGreenliveContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Registro> Registros { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=dbGreenlive;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registro>(entity =>
            {
                entity.HasKey(e => e.Cedula)
                    .HasName("PK__registro__415B7BE47A5817DC");

                entity.ToTable("registro");

                entity.Property(e => e.Cedula)
                    .ValueGeneratedNever()
                    .HasColumnName("cedula");

                entity.Property(e => e.Contraseña).HasColumnName("contraseña");

                entity.Property(e => e.Correo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono).HasColumnName("telefono");

                entity.Property(e => e.TelefonoEmergencia).HasColumnName("telefonoEmergencia");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
