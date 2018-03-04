using Microsoft.EntityFrameworkCore;
using ProkkisDemo2.Core.Models;

namespace ProkkisDemo2.Persistance
{
    public class ProkkisDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ProkkisDbContext(DbContextOptions<ProkkisDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
