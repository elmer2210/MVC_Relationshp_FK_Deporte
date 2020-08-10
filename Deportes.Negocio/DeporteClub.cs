namespace Deportes.Negocio
{
     public class DeporteClub
    {
        public int DetallesId { get; set; }
        public int DeporteId { get; set; }
        public int ClubId { get; set; }
        public Deporte Deporte { get; set; }
        public Club Clubes { get; set;  }

    }
}
