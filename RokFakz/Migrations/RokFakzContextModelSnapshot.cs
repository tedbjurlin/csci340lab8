﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RokFakz.Data;

#nullable disable

namespace RokFakz.Migrations
{
    [DbContext(typeof(RokFakzContext))]
    partial class RokFakzContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("RokFakz.Models.RokFak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Density")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fak")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("MohsHardness")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rock")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("Texture")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RokFak");
                });
#pragma warning restore 612, 618
        }
    }
}
