using AuthSystem.Domain.Entities;
using AuthSystem.Infra.Extensions;
using AuthSystem.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace AuthSystem.Infra.Context
{
    public class AuthContext : DbContext
    {
        public AuthContext(DbContextOptions<AuthContext> options) : base (options)
        {
        }

        #region "DBSets"

        public DbSet<User> Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
