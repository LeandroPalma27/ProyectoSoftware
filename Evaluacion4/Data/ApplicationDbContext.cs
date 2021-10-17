using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static Evaluacion4.Data.ApplicationDbContext;

namespace Evaluacion4.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuario>
    {

        public class Usuario : IdentityUser
        {
            public string Nombre { get; set; }
            public string APaterno { get; set; }
            public string AMaterno { get; set; }
            public string DNI { get; set; }
            public string Direccion { get; set; }
            public string Imagen { get; set; }

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Usuario>(entityTypeBuilder => {
                entityTypeBuilder.ToTable("AspNetUsers");
                entityTypeBuilder.Property(u => u.UserName)
                .HasMaxLength(100)
                .HasDefaultValue(0);

                entityTypeBuilder.Property(u => u.Nombre)
                .HasMaxLength(50);

                entityTypeBuilder.Property(u => u.APaterno)
                .HasMaxLength(50);

                entityTypeBuilder.Property(u => u.AMaterno)
                .HasMaxLength(50);

                entityTypeBuilder.Property(u => u.DNI)
                .HasMaxLength(8);

                entityTypeBuilder.Property(u => u.Direccion)
                .HasMaxLength(60);

                entityTypeBuilder.Property(u => u.Imagen)
                .HasMaxLength(100);
            });
        }

        public ApplicationDbContext()
        {
        }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Evaluacion4.Models.Entidad.Categoria> Categoria { get; set; }
        public virtual DbSet<Evaluacion4.Models.Entidad.Compras> Compras { get; set; }
        public virtual DbSet<Evaluacion4.Models.Entidad.Producto> Producto { get; set; }

        public virtual DbSet<Evaluacion4.Models.Entidad.HistorialCompras> HistorialCompras { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-TFF0S2V1\LEANDRO;Database=ProyectoSoftware;User Id=sa;Password=1234;" +
                "Trusted_Connection=false;MultipleActiveResultSets=true");
        }
    }
}
