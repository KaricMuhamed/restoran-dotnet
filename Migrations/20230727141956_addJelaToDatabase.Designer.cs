﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjekatRestoran.Data;

namespace ProjekatRestoran.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230727141956_addJelaToDatabase")]
    partial class addJelaToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ProjekatRestoran.Models.Meni", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cijena")
                        .HasColumnType("int");

                    b.Property<string>("NazivJela")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OznakaJela")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Jela");
                });
#pragma warning restore 612, 618
        }
    }
}
