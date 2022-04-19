namespace Backend_API_Torneos.Models
{
    public class Jugador
    {
        public string nombre { get; set; }
        public string ficha { get; set; }
        public string jornada { get; set; }
        public bool estado { get; set; }
        
        public Jugador(string nombre, string ficha, string jornada, bool estado)
        {
            this.nombre = nombre;
            this.ficha = ficha;
            this.jornada = jornada;
            this.estado = estado;
        }
    }
}
