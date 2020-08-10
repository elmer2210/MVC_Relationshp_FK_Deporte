using System;
using System.Collections.Generic;
using System.Text;
namespace Deportes.CentroDeportivo.Entidades
{
    public class Equipo
    {
        public int EquipoId { get; set; }
        public string NombreEquipo { get; set; }
        public int IntegrantesEquipo { get; set; }
        public int DeporteId { get; set; }
        public int TecnicoId { get; set; }
        public Deporte Deporte { get; set; }
        public Tecnico Tecnico { get; set; }

    }
}
