﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eHomeDesigner.Data.Contexts;

#nullable disable

namespace eHomeDesigner.Data.Migrations.FurnitureDb
{
    [DbContext(typeof(FurnitureDbContext))]
    [Migration("20211206023702_FurnitureEntity")]
    partial class FurnitureEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("eHomeDesigner.Data.Entities.FurnitureEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfCreate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("SquareMeters")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Furnitures");
                });
#pragma warning restore 612, 618
        }
    }
}
