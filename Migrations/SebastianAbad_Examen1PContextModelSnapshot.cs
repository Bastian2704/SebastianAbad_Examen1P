﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SebastianAbad_Examen1P.Data;

#nullable disable

namespace SebastianAbad_Examen1P.Migrations
{
    [DbContext(typeof(SebastianAbad_Examen1PContext))]
    partial class SebastianAbad_Examen1PContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SebastianAbad_Examen1P.Models.SA_Carro", b =>
                {
                    b.Property<int>("SA_CARROID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SA_CARROID"));

                    b.Property<DateTime>("SA_FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SA_Gasolina")
                        .HasColumnType("bit");

                    b.Property<string>("SA_Marca")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("SA_MecanicosAcargo")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.Property<string>("SA_Modelo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("SA_Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SA_CARROID");

                    b.ToTable("SA_Tabla1");
                });
#pragma warning restore 612, 618
        }
    }
}