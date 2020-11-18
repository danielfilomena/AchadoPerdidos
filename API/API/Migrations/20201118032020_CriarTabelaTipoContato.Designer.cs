﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(LostFoundContext))]
    [Migration("20201118032020_CriarTabelaTipoContato")]
    partial class CriarTabelaTipoContato
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("API.Models.Categoria", b =>
                {
                    b.Property<int>("catCod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("catDsc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("catDtaAlt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("catDtaCad")
                        .HasColumnType("datetime2");

                    b.Property<bool>("catExcluido")
                        .HasColumnType("bit");

                    b.Property<bool>("catInativo")
                        .HasColumnType("bit");

                    b.HasKey("catCod");

                    b.ToTable("tbCat");
                });

            modelBuilder.Entity("API.Models.Pessoa", b =>
                {
                    b.Property<int>("pesCod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("pesCPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("pesDtaAlt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("pesDtaCad")
                        .HasColumnType("datetime2");

                    b.Property<bool>("pesExcluido")
                        .HasColumnType("bit");

                    b.Property<bool>("pesInativo")
                        .HasColumnType("bit");

                    b.Property<string>("pesNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pesSenha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pesUltNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pesCod");

                    b.ToTable("tbPes");
                });

            modelBuilder.Entity("API.Models.TipoContato", b =>
                {
                    b.Property<int>("cttTipCod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("cttTipDsc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cttTipCod");

                    b.ToTable("tbCttTip");
                });
#pragma warning restore 612, 618
        }
    }
}
