﻿// <auto-generated />
using System;
using Gorgan_Sorana_Proiect.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gorgan_Sorana_Proiect.Migrations
{
    [DbContext(typeof(Gorgan_Sorana_ProiectContext))]
    [Migration("20210108225950_M2")]
    partial class M2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gorgan_Sorana_Proiect.Models.Aroma", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumeAroma")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Aroma");
                });

            modelBuilder.Entity("Gorgan_Sorana_Proiect.Models.AromaParfum", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AromaID")
                        .HasColumnType("int");

                    b.Property<int>("ParfumID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AromaID");

                    b.HasIndex("ParfumID");

                    b.ToTable("AromaParfum");
                });

            modelBuilder.Entity("Gorgan_Sorana_Proiect.Models.Brand", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumeBrand")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("Gorgan_Sorana_Proiect.Models.Gen", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumeGen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Gen");
                });

            modelBuilder.Entity("Gorgan_Sorana_Proiect.Models.Parfum", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAparitie")
                        .HasColumnType("datetime2");

                    b.Property<string>("Denumire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descriere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenID")
                        .HasColumnType("int");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(6, 2)");

                    b.HasKey("ID");

                    b.HasIndex("BrandID");

                    b.HasIndex("GenID");

                    b.ToTable("Parfum");
                });

            modelBuilder.Entity("Gorgan_Sorana_Proiect.Models.AromaParfum", b =>
                {
                    b.HasOne("Gorgan_Sorana_Proiect.Models.Aroma", "Aroma")
                        .WithMany("AromeParfum")
                        .HasForeignKey("AromaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gorgan_Sorana_Proiect.Models.Parfum", "Parfum")
                        .WithMany("AromeParfum")
                        .HasForeignKey("ParfumID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gorgan_Sorana_Proiect.Models.Parfum", b =>
                {
                    b.HasOne("Gorgan_Sorana_Proiect.Models.Brand", "Brand")
                        .WithMany("Parfum")
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gorgan_Sorana_Proiect.Models.Gen", "Gen")
                        .WithMany("Parfumuri")
                        .HasForeignKey("GenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}