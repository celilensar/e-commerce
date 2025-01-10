using System;
using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product>? Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new List<Product>() {
                new Product() { Id =1, Name="Iphone 15", Description="Telefon açıklaması", ImageUrl="1.jpg", IsActive= true, Price=18000, Stock= 100},
                new Product() { Id =2, Name="Iphone 16", Description="Telefon açıklaması", ImageUrl="2.jpg", IsActive= true, Price=18000, Stock= 100},
                new Product() { Id =3, Name="Iphone 17", Description="Telefon açıklaması", ImageUrl="3.jpg", IsActive= true, Price=18000, Stock= 100},
                new Product() { Id =4, Name="Iphone 18", Description="Telefon açıklaması", ImageUrl="4.jpg", IsActive= true, Price=18000, Stock= 100}
                }
        );
    }
}
