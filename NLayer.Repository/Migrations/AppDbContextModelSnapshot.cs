// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLayer.Repository;

#nullable disable

namespace NLayer.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NLayer.Core.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Computers"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Phones"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Books"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Games"
                        });
                });

            modelBuilder.Entity("NLayer.Core.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8326),
                            Name = "Asus Laptop",
                            Price = 2000m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8343),
                            Name = "Lenovo Laptop",
                            Price = 2000m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8344),
                            Name = "Macbook Laptop",
                            Price = 2000m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8346),
                            Name = "Monster Gamebook",
                            Price = 2000m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8347),
                            Name = "MSI Laptop",
                            Price = 2000m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8348),
                            Name = "Samsung Galaxy",
                            Price = 2000m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8349),
                            Name = "Xiaomi RedMi",
                            Price = 2000m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8351),
                            Name = "Iphone",
                            Price = 2000m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8352),
                            Name = "Google Pixel",
                            Price = 2000m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8353),
                            Name = "The Lord Of The Rings: The Fellowship Of The Ring",
                            Price = 30m,
                            Stock = 1000
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8354),
                            Name = "The Lord Of The Rings: The Two Towers",
                            Price = 30m,
                            Stock = 1000
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8355),
                            Name = "The Lord Of The Rings: Return Of The King",
                            Price = 30m,
                            Stock = 1000
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8357),
                            Name = "Red Dead Redemption",
                            Price = 60m,
                            Stock = 1000
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8358),
                            Name = "Red Dead Redemption 2",
                            Price = 60m,
                            Stock = 1000
                        });
                });

            modelBuilder.Entity("NLayer.Core.ProductFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductFeatures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Red",
                            Height = 2,
                            ProductId = 1,
                            Width = 36
                        },
                        new
                        {
                            Id = 2,
                            Color = "Blue",
                            Height = 2,
                            ProductId = 4,
                            Width = 42
                        });
                });

            modelBuilder.Entity("NLayer.Core.Product", b =>
                {
                    b.HasOne("NLayer.Core.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NLayer.Core.ProductFeature", b =>
                {
                    b.HasOne("NLayer.Core.Product", "Product")
                        .WithOne("ProductFeature")
                        .HasForeignKey("NLayer.Core.ProductFeature", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NLayer.Core.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("NLayer.Core.Product", b =>
                {
                    b.Navigation("ProductFeature");
                });
#pragma warning restore 612, 618
        }
    }
}
