﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrioridadesWebA.Api.DAL;

#nullable disable

namespace PrioridadesWebA.Api.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240302173526_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Library.Models.Clientes", b =>
                {
                    b.Property<int>("ClientesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CelularClientes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DireccionClientes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailClientes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombresClientes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RNC")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefonoClientes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClientesID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Library.Models.Prioridades", b =>
                {
                    b.Property<int>("IdPrioridades")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DiasCompromiso")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdPrioridades");

                    b.ToTable("Prioridades");
                });

            modelBuilder.Entity("Library.Models.Sistemas", b =>
                {
                    b.Property<int>("SistemasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SistemasNombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SistemasId");

                    b.ToTable("Sistema");
                });

            modelBuilder.Entity("Library.Models.Tickets", b =>
                {
                    b.Property<int>("TicketsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Asunto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ClientesId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("PrioridadesId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SistemasId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SolicitadoPor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TicketsId");

                    b.ToTable("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
