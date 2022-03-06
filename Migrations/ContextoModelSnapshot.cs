﻿// <auto-generated />
using System;
using ExamenBlazor.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExamenBlazor.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("ExamenBlazor.Entidades.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Costo")
                        .HasColumnType("REAL");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<float>("Existencia")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("FechaExpiracion")
                        .HasColumnType("TEXT");

                    b.Property<float>("Ganancia")
                        .HasColumnType("REAL");

                    b.Property<float>("Precio")
                        .HasColumnType("REAL");

                    b.Property<float>("ValorInventario")
                        .HasColumnType("REAL");

                    b.HasKey("ProductoId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("ExamenBlazor.Entidades.ProductoDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Cantidad")
                        .HasColumnType("REAL");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<double>("Precio")
                        .HasColumnType("REAL");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.ToTable("ProductoDetalle");
                });

            modelBuilder.Entity("ExamenBlazor.Entidades.ProductoDetalle", b =>
                {
                    b.HasOne("ExamenBlazor.Entidades.Producto", null)
                        .WithMany("ProductoDetalle")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExamenBlazor.Entidades.Producto", b =>
                {
                    b.Navigation("ProductoDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
