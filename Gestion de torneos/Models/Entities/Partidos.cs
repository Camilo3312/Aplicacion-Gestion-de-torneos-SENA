using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_de_torneos.Models.Entities
{
    public class Partidos
    {
        public int id { get; set; }
        public int equipo1 { get; set; }
        public int equipo2 { get; set; }
        public DateTime fechaencuentro { get; set; }
    }
}
