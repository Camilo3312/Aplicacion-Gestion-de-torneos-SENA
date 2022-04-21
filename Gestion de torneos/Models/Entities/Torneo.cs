using System;
using System.Collections.Generic;

namespace Backend_API_Torneos.Models
{
    public class Torneo
    {
        public DateTime fecha { get; set; }
        public Equipo ganador { set; get; }
        public string tipo_torneo { set; get; }
        public List<Equipo> equipos { get; set; }
        public Torneo(DateTime fecha, string tipo_torneo, List<Equipo> equipos)
        {
            this.fecha = fecha;
            this.tipo_torneo = tipo_torneo;
            this.equipos = equipos;
        }
    }
}
