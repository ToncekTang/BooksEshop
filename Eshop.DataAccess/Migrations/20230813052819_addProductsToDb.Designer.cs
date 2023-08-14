﻿// <auto-generated />
using Eshop.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Eshop.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230813052819_addProductsToDb")]
    partial class addProductsToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.6.23329.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Eshop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Novel"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Action"
                        });
                });

            modelBuilder.Entity("Eshop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("PriceFifty")
                        .HasColumnType("float");

                    b.Property<double>("PriceHundred")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Tianqi Tang1",
                            Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                            ISBN = "TTQ0000001",
                            ListPrice = 99.0,
                            Price = 90.0,
                            PriceFifty = 85.0,
                            PriceHundred = 80.0,
                            Title = "CocaCola1"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Tianqi Tang2",
                            Description = "CocaCola classic.\r\n\r\nThe Baron Crispy Corn Nibbles. ",
                            ISBN = "TTQ0000002",
                            ListPrice = 40.0,
                            Price = 30.0,
                            PriceFifty = 25.0,
                            PriceHundred = 20.0,
                            Title = "CocaCola2"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Tianqi Tang3",
                            Description = "CocaCola classic.\r\n\r\nThe Baron Crispy Corn Nibbles. ",
                            ISBN = "TTQ0000003",
                            ListPrice = 55.0,
                            Price = 50.0,
                            PriceFifty = 40.0,
                            PriceHundred = 35.0,
                            Title = "CocaCola3"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Tianqi Tang4",
                            Description = "CocaCola classic.\r\n\r\nThe Baron Crispy Corn Nibbles. ",
                            ISBN = "TTQ0000004",
                            ListPrice = 70.0,
                            Price = 65.0,
                            PriceFifty = 60.0,
                            PriceHundred = 55.0,
                            Title = "CocaCola4"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Tianqi Tang5",
                            Description = "CocaCola classic.\r\n\r\nThe Baron Crispy Corn Nibbles.  ",
                            ISBN = "TTQ0000005",
                            ListPrice = 30.0,
                            Price = 27.0,
                            PriceFifty = 25.0,
                            PriceHundred = 20.0,
                            Title = "CocaCola5"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Tianqi Tang6",
                            Description = "CocaCola classic.\r\n\r\nThe Baron Crispy Corn Nibbles.  ",
                            ISBN = "TTQ0000006",
                            ListPrice = 25.0,
                            Price = 23.0,
                            PriceFifty = 22.0,
                            PriceHundred = 20.0,
                            Title = "CocaCola6"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}