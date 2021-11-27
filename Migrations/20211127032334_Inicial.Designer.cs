﻿// <auto-generated />
using Entrenamiento_Bateo.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entrenamiento_Bateo.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211127032334_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Entrenamiento_Bateo.Models.Bateadores", b =>
                {
                    b.Property<int>("BateadorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Afeccion")
                        .HasColumnType("REAL");

                    b.Property<double>("BolasBateadas")
                        .HasColumnType("REAL");

                    b.Property<double>("BolasLanzadas")
                        .HasColumnType("REAL");

                    b.Property<double>("CambiosBateados")
                        .HasColumnType("REAL");

                    b.Property<double>("CambiosLanzados")
                        .HasColumnType("REAL");

                    b.Property<double>("CurvasBateadas")
                        .HasColumnType("REAL");

                    b.Property<double>("CurvasLanzadas")
                        .HasColumnType("REAL");

                    b.Property<string>("Estado")
                        .HasColumnType("TEXT");

                    b.Property<double>("Fouls")
                        .HasColumnType("REAL");

                    b.Property<double>("Hits")
                        .HasColumnType("REAL");

                    b.Property<double>("HitsCambios")
                        .HasColumnType("REAL");

                    b.Property<double>("HitsCurvas")
                        .HasColumnType("REAL");

                    b.Property<double>("HitsNudillos")
                        .HasColumnType("REAL");

                    b.Property<double>("HitsRectas")
                        .HasColumnType("REAL");

                    b.Property<double>("HitsSliders")
                        .HasColumnType("REAL");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<double>("NudillosBateados")
                        .HasColumnType("REAL");

                    b.Property<double>("NudillosLanzados")
                        .HasColumnType("REAL");

                    b.Property<double>("PorcentajeBateo")
                        .HasColumnType("REAL");

                    b.Property<double>("PorcentajeCambio")
                        .HasColumnType("REAL");

                    b.Property<double>("PorcentajeCurva")
                        .HasColumnType("REAL");

                    b.Property<double>("PorcentajeHits")
                        .HasColumnType("REAL");

                    b.Property<double>("PorcentajeHitsCambios")
                        .HasColumnType("REAL");

                    b.Property<double>("PorcentajeHitsCurvas")
                        .HasColumnType("REAL");

                    b.Property<double>("PorcentajeHitsNudillos")
                        .HasColumnType("REAL");

                    b.Property<double>("PorcentajeHitsRectas")
                        .HasColumnType("REAL");

                    b.Property<double>("PorcentajeHitsSliders")
                        .HasColumnType("REAL");

                    b.Property<double>("PorcentajeNudillo")
                        .HasColumnType("REAL");

                    b.Property<double>("PorcentajeRecta")
                        .HasColumnType("REAL");

                    b.Property<double>("PorcentajeSlider")
                        .HasColumnType("REAL");

                    b.Property<double>("RectasBateadas")
                        .HasColumnType("REAL");

                    b.Property<double>("RectasLanzadas")
                        .HasColumnType("REAL");

                    b.Property<double>("SlidersBateadas")
                        .HasColumnType("REAL");

                    b.Property<double>("SlidersLanzados")
                        .HasColumnType("REAL");

                    b.HasKey("BateadorId");

                    b.ToTable("Bateadores");
                });
#pragma warning restore 612, 618
        }
    }
}
