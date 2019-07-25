﻿// <auto-generated />
using System;
using EShopWebApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EShopWebApi.Migrations
{
    [DbContext(typeof(EShopDbContext))]
    [Migration("20190725134648_EShopDb")]
    partial class EShopDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EShopWebApi.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("EShopWebApi.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnName("comment");

                    b.Property<DateTime>("Date_Of_Creation")
                        .HasColumnName("date_of_creation");

                    b.Property<int>("User_Id")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("User_Id");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("EShopWebApi.Models.Order_Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Order_Id")
                        .HasColumnName("order_id");

                    b.Property<int>("Product_Id")
                        .HasColumnName("product_id");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasColumnName("quantity");

                    b.HasKey("Id");

                    b.HasIndex("Order_Id");

                    b.HasIndex("Product_Id");

                    b.ToTable("order_items");
                });

            modelBuilder.Entity("EShopWebApi.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category_Id")
                        .HasColumnName("category_id");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnName("price");

                    b.Property<int>("Quantity")
                        .HasColumnName("quantity");

                    b.HasKey("Id");

                    b.HasIndex("Category_Id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("EShopWebApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_Of_Creation")
                        .HasColumnName("date_of_creation");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnName("login");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password");

                    b.Property<int>("Status")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("EShopWebApi.Models.Order", b =>
                {
                    b.HasOne("EShopWebApi.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EShopWebApi.Models.Order_Item", b =>
                {
                    b.HasOne("EShopWebApi.Models.Order", "Order")
                        .WithMany("Order_Items")
                        .HasForeignKey("Order_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EShopWebApi.Models.Product", "Product")
                        .WithMany("Order_Items")
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EShopWebApi.Models.Product", b =>
                {
                    b.HasOne("EShopWebApi.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
