using System;
using System.Collections.Generic;
using System.Text;

namespace Deportes.CentroDeportivo.Entidades
{
    public class Jugador : Persona
    {
        public int JugadorId { get; set; }
        public float Estatura { get; set; }
        public string Posicion { get; set; }
        //public int TecnicoId { get; set; }
        //public Tecnico Tecnicos { get; set; }
        public int EquipoId { get; set; }
        public Equipo Equipo { get; set; }
    
        public Jugador()
        {
            NombreComppleto = $"{PrimerNombre} {SegundoNombre} {ApellidoPaterno} {ApellidoMaterno}";
        }
    }
}
