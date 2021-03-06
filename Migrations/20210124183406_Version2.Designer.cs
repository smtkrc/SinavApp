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
    [Migration("20210124183406_Version2")]
    partial class Version2
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

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoruAd")
                        .HasMaxLength(1000)
                        .HasColumnType("Varchar(1000)");

                    b.Property<string>("tarih")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Sorulars");
                });

            modelBuilder.Entity("SinavProje.Models.SorularDetay", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<byte>("Durum")
                        .HasColumnType("tinyint");

                    b.Property<string>("S1A")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S1B")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S1C")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S1D")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S2A")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S2B")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S2C")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S2D")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S3A")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S3B")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S3C")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S3D")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S4A")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S4B")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S4C")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S4D")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SC1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SC2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SC3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SC4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soru4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoruBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoruMetin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tarih")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("SoruDetays");
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
