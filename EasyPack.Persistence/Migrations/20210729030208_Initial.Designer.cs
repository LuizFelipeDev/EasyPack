﻿// <auto-generated />
using System;
using EasyPack.Persistence.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EasyPack.Persistence.Migrations
{
    [DbContext(typeof(EasyPackContext))]
    [Migration("20210729030208_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EasyPack.Domain.model.Carga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<double>("Comprimento")
                        .HasColumnType("float");

                    b.Property<int>("EntregaId")
                        .HasColumnType("int");

                    b.Property<double>("Largura")
                        .HasColumnType("float");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EntregaId");

                    b.ToTable("Cargas");
                });

            modelBuilder.Entity("EasyPack.Domain.model.Entrega", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data_Coleta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_Entrega")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Entregas");
                });

            modelBuilder.Entity("EasyPack.Domain.model.Carga", b =>
                {
                    b.HasOne("EasyPack.Domain.model.Entrega", "Entrega")
                        .WithMany("Cargas")
                        .HasForeignKey("EntregaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entrega");
                });

            modelBuilder.Entity("EasyPack.Domain.model.Entrega", b =>
                {
                    b.Navigation("Cargas");
                });
#pragma warning restore 612, 618
        }
    }
}