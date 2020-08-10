using Deportes.CentroDeportivo.Entidades;

namespace Deportes.CentroDeportivo
{
    public class Secretaria
    {
        public static int ClubInscritos { get; set; }
        public void IncribirClub(Club club, Deporte deporte)
        { 
        club.DeporteClubs.Add(new DeporteClub
            {
                Clubes = club,
                Deporte = deporte
            });
            ClubInscritos++;
        }
    }
}
