using Dependencias.Model;
using Microsoft.EntityFrameworkCore;

namespace Dependencias.Data;

public class MainContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    
    public MainContext(DbContextOptions<MainContext> dbContext): base(dbContext)
    {

    }
}
