using Microsoft.EntityFrameworkCore;
using Proyecto_0001_DriverSchool.Models;

namespace Proyecto_0001_DriverSchool
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Trabajador> Trabajador { get; set; }
        public DbSet<Evaluaciones> Evaluaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trabajador>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nombre).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Puesto).HasMaxLength(100);
                entity.Property(e => e.Salario);
                entity.Property(e => e.FechaCreacion);
                entity.Property(e => e.FechaModificacion);
                entity.Property(e => e.EsEliminado);

            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.IdTrabajador).IsRequired();
                entity.Property(e => e.NombreUsuario).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Contraseña).IsRequired();
                entity.Property(e => e.FechaCreacion);
                entity.Property(e => e.FechaModificacion);
                entity.Property(e => e.EsEliminado);

            });

            modelBuilder.Entity<Evaluaciones> (entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.IdTrabajador).IsRequired();
                entity.Property(e => e.TipoEvaluacion).IsRequired();
                entity.Property(e => e.NombreEvaluacion).IsRequired();
                entity.Property(e => e.FechaEvaluacion).IsRequired();
                entity.Property(e => e.Resultado).IsRequired();
                entity.Property(e => e.FechaCreacion);
                entity.Property(e => e.FechaModificacion);
                entity.Property(e => e.EsEliminado);

            });
        }
    }
}
