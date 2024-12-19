using Microsoft.EntityFrameworkCore;
using Tabu.Class;

namespace Tabu.DAL
{
    public class TabuDbContext : DbContext
    {
        public TabuDbContext(DbContextOptions opt) : base(opt) 
        {
        }
        public DbSet<Language> Languages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TabuDbContext).Assembly);
           base.OnModelCreating(modelBuilder);
        }
    }
}
