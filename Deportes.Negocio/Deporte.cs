using System.Collections.Generic;

namespace Deportes.Negocio
{
    public class Deporte
    {
        public int DeporteId { get; set; }
        public string NombreDeporte { get; set; }
        public string TipoDeporte { get; set; }
        public int NumeroJugadores { get; set; }
        public string TiempoJuego { get; set; }
        public List<DeporteClub> DeportesClub { get; set; } = new List<DeporteClub>();
        public List<Equipo> Equipos { get; set; } = new List<Equipo>();
    }
}
