using Microsoft.EntityFrameworkCore;

namespace Evaluacion4.Models
{
    public class EFContext : DbContext
    {
        private const string ConnectionString = "server=localhost;port=3306;database=curso_db;user=root;password=;Connect Timeout=5;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionString,
                new MySqlServerVersion(new Version(8, 0, 11)));
        }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>().HasKey(i => i.Id);
            modelBuilder.Entity<Curso>().HasKey(j => j.Id);

            modelBuilder.Entity<Alumno>()
                .HasOne<Curso>(s => s.Curso)
                .WithMany(g => g.Alumnos)
                .HasForeignKey(c => c.CursoId);

            modelBuilder.Entity<Alumno>().Property(s => s.CursoId).IsRequired();
            modelBuilder.Entity<Alumno>().Property(s => s.Nombre).IsRequired();
            modelBuilder.Entity<Alumno>().Property(s => s.Edad).IsRequired();

            modelBuilder.Entity<Curso>().Property(s => s.Descripcion).IsRequired();
            modelBuilder.Entity<Curso>().Property(s => s.NroSala).IsRequired();
            modelBuilder.Entity<Curso>().Property(s => s.FechaCreacion)
                .HasDefaultValue(DateTime.Now)
                .IsRequired();
        }
    }
}
