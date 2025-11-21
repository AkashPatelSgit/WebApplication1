using System.Data.Entity;
using WebApplication1.Models;

public class AppDbContext : DbContext
{
    public AppDbContext() : base("DefaultConnection") { }

    public DbSet<student> students { get; set; }
}
