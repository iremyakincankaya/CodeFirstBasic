using CodeFirstBasic.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Data
{
    public class PatikaFirstDbContext:DbContext
    {
        public DbSet<Movie>Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=PatikaCodeFirstDb1;trusted_connection=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
