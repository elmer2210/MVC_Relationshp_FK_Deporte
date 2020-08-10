using Deportes.CentroDeportivo;
using Deportes.CentroDeportivo.Entidades;
using System;

namespace Deportes.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que comienze el amor a los deportes!!");

            Jugador jugador = new Jugador
            {
                PrimerNombre = "Juan",
                SegundoNombre = "Miguel",
                ApellidoPaterno = "Perez",
                ApellidoMaterno = "Solano",
                Edad = 19,
                EquipoId = 2,
                Posicion = "Delantero Central",
                Estatura = 184,
                FechaCreacion = new DateTime(2020, 8, 7)
            };
            Equipo equipo = new Equipo
            {
                NombreEquipo = "Los chullas",
                IntegrantesEquipo = 11,
                TecnicoId = 2,
                DeporteId = 1
            };
            Tecnico tecnico = new Tecnico
            {
                PrimerNombre = "Pedro",
                SegundoNombre = "Javier",
                ApellidoPaterno = "Ruiz",
                ApellidoMaterno = "Manzaba",
                Edad = 55,
                AñosProfesion = 25,
                FechaCreacion = new DateTime(2020, 08, 07)
            };

            Deporte deporte = new Deporte
            {
                NombreDeporte = "Basketboll",
                NumeroJugadores = 9,
                TiempoJuego = "90 minutos",
                TipoDeporte = "Balonmano"
            };
            Deporte deporte1 = new Deporte
            {
                NombreDeporte = "Futbol",
                NumeroJugadores = 11,
                TiempoJuego = "90 minutos",
                TipoDeporte = "Balonpie"
            };

            Club club = new Club
            {
                Nombre = "Club de los leones"
            };

            Secretaria secretaria = new Secretaria();
            secretaria.IncribirClub(club, deporte);

            Secretaria secretaria1 = new Secretaria();
            secretaria.IncribirClub(club, deporte1);

            Console.WriteLine($"Hay {Secretaria.ClubInscritos} club inscriptos");
        
        }
        
    }
}
