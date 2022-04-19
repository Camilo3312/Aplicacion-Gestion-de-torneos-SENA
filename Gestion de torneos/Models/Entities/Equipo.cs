using System;
using System.Collections.Generic;
using System.Linq;

namespace Backend_API_Torneos.Models
{
    public class Equipo
    {
        public string nombre { get; set; }
        public DateTime fecha { get; set; }
        public double puntuacion { get; set; }
        public Equipo contrincante { get; set; }
        public List<Jugador> jugadores { get; set; }

        public Equipo(string nombre, DateTime fecha, List<Jugador> jugadores)
        {
            this.nombre = nombre; 
            this.fecha = fecha;
            this.jugadores = jugadores;
        }

        public void AsignarContrincante(Equipo contrincante)
        {
            this.contrincante = contrincante;
        }
    }
}
