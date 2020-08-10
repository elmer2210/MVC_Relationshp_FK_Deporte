using System;
using System.Collections.Generic;
using System.Text;

namespace Deportes.Negocio
{
    public class Tecnico : Persona
    {
        public int TecnicoId { get; set; }
        public int AñosProfesion { get; set; }
        public List<Equipo> Equipos { get; set; } = new List<Equipo>();
        public List<Jugador> Jugadores { get; set; }

        public Tecnico()
        {
            NombreComppleto = $"{PrimerNombre} {SegundoNombre} {ApellidoPaterno} {ApellidoMaterno}";
        }
    }
}
