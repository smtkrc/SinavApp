﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SinavProje.Models;

namespace SinavProje.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210124180455_guncel")]
    partial class guncel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("SinavProje.Models.Sorular", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("SoruAd")
                        .HasMaxLength(1000)
                        .HasColumnType("Varchar(1000)");

                    b.Property<string>("tarih")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Sorulars");
                });

            modelBuilder.Entity("SinavProje.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Password")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("UserName")
                        .HasMaxLength(10)
                        .HasColumnType("Varchar(10)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}