using ElissonFlix.Models;
using Microsoft.EntityFrameworkCore;

namespace ElissonFlix.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Genre> Genres { get; set; }
    
}