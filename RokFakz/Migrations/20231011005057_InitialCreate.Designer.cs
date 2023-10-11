﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RokFakz.Data;

#nullable disable

namespace RokFakz.Migrations
{
    [DbContext(typeof(RokFakzContext))]
    [Migration("20231011005057_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("RokFakz.Models.RokFak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Density")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fak")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("MohsHardness")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rock")
                        .HasColumnType("TEXT");

                    b.Property<string>("Texture")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RokFak");
                });
#pragma warning restore 612, 618
        }
    }
}
