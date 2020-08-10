using System.ComponentModel.DataAnnotations;

namespace Deportes.CentroDeportivo.Entidades
{
     public class DeporteClub
    {
        [Key]
        public int DetallesId { get; set; }
        public int DeporteId { get; set; }
        public int ClubId { get; set; }
        public Deporte Deporte { get; set; }
        public Club Clubes { get; set;  }

    }
}
