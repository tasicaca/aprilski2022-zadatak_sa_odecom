﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Template;

namespace Template.Migrations
{
    [DbContext(typeof(IspitDbContext))]
    [Migration("20220605142701_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrendProdavnica", b =>
                {
                    b.Property<int>("BrendID")
                        .HasColumnType("int");

                    b.Property<int>("ProdavnicaID")
                        .HasColumnType("int");

                    b.HasKey("BrendID", "ProdavnicaID");

                    b.HasIndex("ProdavnicaID");

                    b.ToTable("BrendProdavnica");
                });

            modelBuilder.Entity("BrendProizvod", b =>
                {
                    b.Property<int>("BrendID")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodID")
                        .HasColumnType("int");

                    b.HasKey("BrendID", "ProizvodID");

                    b.HasIndex("ProizvodID");

                    b.ToTable("BrendProizvod");
                });

            modelBuilder.Entity("Template.Models.Brend", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Brend");
                });

            modelBuilder.Entity("Template.Models.Prodavnica", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Prodavnica");
                });

            modelBuilder.Entity("Template.Models.Proizvod", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProdavnicaID")
                        .HasColumnType("int");

                    b.Property<int>("cena")
                        .HasColumnType("int")
                        .HasColumnName("Cena");

                    b.Property<int>("kolicina")
                        .HasColumnType("int")
                        .HasColumnName("Kolicina");

                    b.Property<string>("naziv")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Naziv");

                    b.Property<int>("sifra")
                        .HasColumnType("int")
                        .HasColumnName("Sifra");

                    b.Property<int>("velicina")
                        .HasColumnType("int")
                        .HasColumnName("Velicina");

                    b.HasKey("ID");

                    b.HasIndex("ProdavnicaID");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("BrendProdavnica", b =>
                {
                    b.HasOne("Template.Models.Brend", null)
                        .WithMany()
                        .HasForeignKey("BrendID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Template.Models.Prodavnica", null)
                        .WithMany()
                        .HasForeignKey("ProdavnicaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BrendProizvod", b =>
                {
                    b.HasOne("Template.Models.Brend", null)
                        .WithMany()
                        .HasForeignKey("BrendID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Template.Models.Proizvod", null)
                        .WithMany()
                        .HasForeignKey("ProizvodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Template.Models.Proizvod", b =>
                {
                    b.HasOne("Template.Models.Prodavnica", "Prodavnica")
                        .WithMany("Proizvod")
                        .HasForeignKey("ProdavnicaID");

                    b.Navigation("Prodavnica");
                });

            modelBuilder.Entity("Template.Models.Prodavnica", b =>
                {
                    b.Navigation("Proizvod");
                });
#pragma warning restore 612, 618
        }
    }
}
