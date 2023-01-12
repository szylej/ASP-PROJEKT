using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WypozyczalniaGierApp.Models;

namespace WypozyczalniaGierApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WypozyczalniaGierApp.Models.Game> Game { get; set; }
    }
}