﻿// <auto-generated />
using System;
using EletrodomesticosAppWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EletrodomesticosAppWeb.Data.Migrations
{
    [DbContext(typeof(EletrodomesticoDbContext))]
    partial class EletrodomesticoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EletrodomesticosAppWeb.Models.Eletrodomestico", b =>
                {
                    b.Property<int>("EletrodomesticoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EletrodomesticoId"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FreteGratis")
                        .HasColumnType("bit");

                    b.Property<string>("ImagemUri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("EletrodomesticoId");

                    b.HasIndex("MarcaId");

                    b.ToTable("TBL_Eletrodomestico");
                });

            modelBuilder.Entity("EletrodomesticosAppWeb.Models.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarcaId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarcaId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("EletrodomesticosAppWeb.Models.Eletrodomestico", b =>
                {
                    b.HasOne("EletrodomesticosAppWeb.Models.Marca", null)
                        .WithMany("Eletrodomesticos")
                        .HasForeignKey("MarcaId");
                });

            modelBuilder.Entity("EletrodomesticosAppWeb.Models.Marca", b =>
                {
                    b.Navigation("Eletrodomesticos");
                });
#pragma warning restore 612, 618
        }
    }
}
