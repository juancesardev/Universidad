using Microsoft.EntityFrameworkCore;
using Universidad.Models.DataModels;

namespace Universidad.DataAccess
{
    public class UniversidadDBContext :DbContext
    {
        public UniversidadDBContext(DbContextOptions<UniversidadDBContext> options) :
        base(options)
        {
        }

        //TODO DbSeet
        public DbSet<User> Users { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Chapter> Chapters{ get; set; }
    }
}

