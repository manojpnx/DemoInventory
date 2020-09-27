﻿// <auto-generated />
using DemoInventory.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoInventory.Infrastructure.Data.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20200927204935_seed data")]
    partial class seeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoInventory.Domain.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ReorderLevel")
                        .HasColumnType("int");

                    b.Property<string>("Sku")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = -1L,
                            Description = "Apple iPhone X",
                            Name = "iPhone X",
                            Price = 1000m,
                            Quantity = 500,
                            ReorderLevel = 10,
                            Sku = "P-000001"
                        },
                        new
                        {
                            Id = -2L,
                            Description = "Google Pixel 4",
                            Name = "Pixel 4",
                            Price = 900m,
                            Quantity = 400,
                            ReorderLevel = 20,
                            Sku = "P-000002"
                        },
                        new
                        {
                            Id = -3L,
                            Description = "SAmsung Galaxy A30",
                            Name = "Galaxy A30",
                            Price = 700m,
                            Quantity = 800,
                            ReorderLevel = 30,
                            Sku = "P-000003"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}