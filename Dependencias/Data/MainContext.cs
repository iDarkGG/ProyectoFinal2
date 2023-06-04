using System;
using System.Collections.Generic;
using Dependencias.Model;
using Microsoft.EntityFrameworkCore;

namespace Dependencias.Data;

public class MainContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=WILMAN-PC;Database=Tienda;Trusted_Connection=True;TrustServerCertificate=True");
    }

    public MainContext(DbContextOptions<MainContext> dbContext): base(dbContext)
    {

    }
}
