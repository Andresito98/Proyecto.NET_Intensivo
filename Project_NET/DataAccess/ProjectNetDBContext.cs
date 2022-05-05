using Microsoft.EntityFrameworkCore;
using Project_NET.Models.DataModels;

namespace Project_NET.DataAccess
{
    public class ProjectNetDBContext: DbContext
    {
        public ProjectNetDBContext(DbContextOptions<ProjectNetDBContext> options) : base(options)
        {

        }
        public DbSet<Curso>? Cursos { get; set; }
    }
}
