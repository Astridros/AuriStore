

using AuriStore.Domain.Entities;
using AuriStore.Infrastructure.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;

namespace AuriStore.Infrastructure.Persistence.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
        }
    }
}
