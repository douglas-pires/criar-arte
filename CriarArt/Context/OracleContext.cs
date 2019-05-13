using CriarArt.Models;
using Microsoft.EntityFrameworkCore;

namespace CriarArt.Context
{
    public class OracleContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("CriarArtDabase");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
