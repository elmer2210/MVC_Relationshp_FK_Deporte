using Deportes.CentroDeportivo.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Deportes.AccesoDatos
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appConfig.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Deporte> Deportes { get; set; }
        public DbSet<Club> Clubes { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<DeporteClub> DeporteClubes { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
    }
}
