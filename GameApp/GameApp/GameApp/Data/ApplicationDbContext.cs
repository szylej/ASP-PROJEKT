using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GameApp.Models;

namespace GameApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GameApp.Models.Game> Game { get; set; }
        public DbSet<GameApp.Models.Comment> Comment { get; set; }
    }
}