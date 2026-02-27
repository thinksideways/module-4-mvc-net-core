using Microsoft.EntityFrameworkCore;
using Northwind.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Category> Category { get; set; }
    public DbSet<Product> Products { get; set; }
}
