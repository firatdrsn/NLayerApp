using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Asus Laptop", Price = 2000, Stock = 15, CreatedDate = DateTime.Now },
                new Product { Id = 2, CategoryId = 1, Name = "Lenovo Laptop", Price = 2000, Stock = 15, CreatedDate = DateTime.Now },
                new Product { Id = 3, CategoryId = 1, Name = "Macbook Laptop", Price = 2000, Stock = 15, CreatedDate = DateTime.Now },
                new Product { Id = 4, CategoryId = 1, Name = "Monster Gamebook", Price = 2000, Stock = 15, CreatedDate = DateTime.Now },
                new Product { Id = 5, CategoryId = 1, Name = "MSI Laptop", Price = 2000, Stock = 15, CreatedDate = DateTime.Now },
                new Product { Id = 6, CategoryId = 2, Name = "Samsung Galaxy", Price = 2000, Stock = 15, CreatedDate = DateTime.Now },
                new Product { Id = 7, CategoryId = 2, Name = "Xiaomi RedMi", Price = 2000, Stock = 15, CreatedDate = DateTime.Now },
                new Product { Id = 8, CategoryId = 2, Name = "Iphone", Price = 2000, Stock = 15, CreatedDate = DateTime.Now },
                new Product { Id = 9, CategoryId = 2, Name = "Google Pixel", Price = 2000, Stock = 15, CreatedDate = DateTime.Now },
                new Product { Id = 10, CategoryId = 3, Name = "The Lord Of The Rings: The Fellowship Of The Ring", Price = 30, Stock = 1000, CreatedDate = DateTime.Now },
                new Product { Id = 11, CategoryId = 3, Name = "The Lord Of The Rings: The Two Towers", Price = 30, Stock = 1000, CreatedDate = DateTime.Now },
                new Product { Id = 12, CategoryId = 3, Name = "The Lord Of The Rings: Return Of The King", Price = 30, Stock = 1000, CreatedDate = DateTime.Now },
                new Product { Id = 13, CategoryId = 4, Name = "Red Dead Redemption", Price = 60, Stock = 1000, CreatedDate = DateTime.Now },
                new Product { Id = 14, CategoryId = 4, Name = "Red Dead Redemption 2", Price = 60, Stock = 1000, CreatedDate = DateTime.Now });
        }
    }
}
