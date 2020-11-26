﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(LostFoundContext))]
    partial class LostFoundContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

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

                    b.Property<string>("pesEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("pesExcluido")
                        .HasColumnType("bit");

                    b.Property<bool>("pesInativo")
                        .HasColumnType("bit");

                    b.Property<string>("pesNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pesSenha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pesTel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pesUltNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pesCod");

                    b.ToTable("tbPes");
                });
#pragma warning restore 612, 618
        }
    }
}
