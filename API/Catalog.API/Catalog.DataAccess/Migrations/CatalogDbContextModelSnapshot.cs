﻿// <auto-generated />
using System;
using Catalog.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Catalog.DataAccess.Migrations
{
    [DbContext(typeof(CatalogDbContext))]
    partial class CatalogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Catalog.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Telefon"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bilgisayar"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Tablet"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Kamera"
                        });
                });

            modelBuilder.Entity("Catalog.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Samsung S10",
                            ImageUrl = "1.jpg",
                            IsActive = true,
                            Name = "Samsung S10",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Dell....",
                            ImageUrl = "2.jpg",
                            IsActive = true,
                            Name = "Dell XPS 13",
                            Price = 10000.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Lenovo Tab 4",
                            ImageUrl = "3.jpg",
                            IsActive = true,
                            Name = "Lenovo Tab 4",
                            Price = 2000.0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            Description = "Canon EOS 5D",
                            ImageUrl = "4.jpg",
                            IsActive = true,
                            Name = "Canon EOS 5D",
                            Price = 3000.0
                        });
                });

            modelBuilder.Entity("Catalog.Entities.Product", b =>
                {
                    b.HasOne("Catalog.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Catalog.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
