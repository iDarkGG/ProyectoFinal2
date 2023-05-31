using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dependencias.Models;

public class MainContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-26H39J7\\SQLSERVER2019;Database=Product;Trusted_Connection=True;TrustServerCertificate=True");
    }
}
