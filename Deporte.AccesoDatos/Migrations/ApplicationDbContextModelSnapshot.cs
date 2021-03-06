﻿// <auto-generated />
using System;
using Deportes.AccesoDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Deportes.AccesoDatos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Deportes.CentroDeportivo.Club", b =>
                {
                    b.Property<int>("ClubID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClubID");

                    b.ToTable("Clubes");
                });

            modelBuilder.Entity("Deportes.CentroDeportivo.Deporte", b =>
                {
                    b.Property<int>("DeporteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreDeporte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroJugadores")
                        .HasColumnType("int");

                    b.Property<string>("TiempoJuego")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDeporte")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeporteId");

                    b.ToTable("Deportes");
                });

            modelBuilder.Entity("Deportes.CentroDeportivo.DeporteClub", b =>
                {
                    b.Property<int>("DetallesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClubId")
                        .HasColumnType("int");

                    b.Property<int>("DeporteId")
                        .HasColumnType("int");

                    b.HasKey("DetallesId");

                    b.HasIndex("ClubId");

                    b.HasIndex("DeporteId");

                    b.ToTable("DeporteClubes");
                });

            modelBuilder.Entity("Deportes.CentroDeportivo.Equipo", b =>
                {
                    b.Property<int>("EquipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeporteId")
                        .HasColumnType("int");

                    b.Property<int>("IntegrantesEquipo")
                        .HasColumnType("int");

                    b.Property<string>("NombreEquipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TecnicoId")
                        .HasColumnType("int");

                    b.HasKey("EquipoId");

                    b.HasIndex("DeporteId");

                    b.HasIndex("TecnicoId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Deportes.CentroDeportivo.Jugador", b =>
                {
                    b.Property<int>("JugadorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoMaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApellidoPaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<float>("Estatura")
                        .HasColumnType("real");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreComppleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Posicion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TecnicoId")
                        .HasColumnType("int");

                    b.HasKey("JugadorId");

                    b.HasIndex("EquipoId");

                    b.HasIndex("TecnicoId");

                    b.ToTable("Jugadores");
                });

            modelBuilder.Entity("Deportes.CentroDeportivo.Tecnico", b =>
                {
                    b.Property<int>("TecnicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoMaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApellidoPaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AñosProfesion")
                        .HasColumnType("int");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreComppleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TecnicoId");

                    b.ToTable("Tecnicos");
                });

            modelBuilder.Entity("Deportes.CentroDeportivo.DeporteClub", b =>
                {
                    b.HasOne("Deportes.CentroDeportivo.Club", "Clubes")
                        .WithMany("DeporteClubs")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Deportes.CentroDeportivo.Deporte", "Deporte")
                        .WithMany("DeportesClub")
                        .HasForeignKey("DeporteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Deportes.CentroDeportivo.Equipo", b =>
                {
                    b.HasOne("Deportes.CentroDeportivo.Deporte", "Deporte")
                        .WithMany("Equipos")
                        .HasForeignKey("DeporteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Deportes.CentroDeportivo.Tecnico", "Tecnico")
                        .WithMany("Equipos")
                        .HasForeignKey("TecnicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Deportes.CentroDeportivo.Jugador", b =>
                {
                    b.HasOne("Deportes.CentroDeportivo.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Deportes.CentroDeportivo.Tecnico", null)
                        .WithMany("Jugadores")
                        .HasForeignKey("TecnicoId");
                });
#pragma warning restore 612, 618
        }
    }
}
