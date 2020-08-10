﻿using System.Collections.Generic;

namespace Deportes.CentroDeportivo.Entidades
{
    public class Club
    {
        public int ClubID { get; set; }
        public string Nombre { get; set; }
        public List<DeporteClub> DeporteClubs { get; set;  } = new List<DeporteClub>();
    }
}
