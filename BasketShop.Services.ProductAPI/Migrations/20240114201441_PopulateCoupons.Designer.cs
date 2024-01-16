﻿// <auto-generated />
using BasketShop.Services.ProductAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BasketShop.Services.ProductAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240114201441_PopulateCoupons")]
    partial class PopulateCoupons
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BasketShop.Services.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLocalPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryName = "Ball",
                            Description = "The latest model with improvements - the TF 1000 Legacy basketball, the official ball of PLK (Polska Liga Koszykarska)",
                            ImageUrl = "https://sklepkoszykarski.pl/userdata/public/gfx/6091/Oficjalna-pilka-Spalding-TF-1000-Legacy.jpg",
                            Name = "Spalding ball",
                            Price = 100.0
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryName = "Board",
                            Description = "The Wilson mini basketball backboard is the perfect solution for any basketball fan who wants to play in the room",
                            ImageUrl = "https://sklepkoszykarski.pl/userdata/public/gfx/6381/Mini-tablica-do-koszykowki-Wilson-NBA-Los-Angeles-Lakers.jpg",
                            Name = "Wilson NBA Los Angeles Lakers mini basketball backboard",
                            Price = 150.0
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryName = "Shoes",
                            Description = "Satin shine and iconic colors are a combination you must have in your wardrobe. And a classic cut.",
                            ImageUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/1eac4e3d-869d-44f3-abb3-233eea2f68f1/buty-air-jordan-1-high-og-satin-bred-gmhC5X.png",
                            Name = "Air Jordan 1 High OG „Satin Bred",
                            Price = 800.0
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryName = "T-shirt",
                            Description = "The Icon Edition T-shirt represents the true colors of the team and stands out with its distinctive, recognizable style. Inspired by the uniforms worn by professional players, the Nike NBA Swingman Golden State Warriors Icon Edition T-shirt is made of high-quality double-knit fabric and has a classic cut that looks great from any angle.",
                            ImageUrl = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/ff50ee77-053c-4d83-9b51-980752e6e85a/koszulka-dla-duzych-nba-swingman-warriors-icon-edition-22VQBL.png",
                            Name = "Nike NBA Swingman T-shirt",
                            Price = 400.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
