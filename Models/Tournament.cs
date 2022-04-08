namespace Backend_API_Torneos.Models
{
    public class Tournament
    {
        public DateTime fecha { get; set; }
        public string tipo_torneo { set; get; }
        public List<Team> equipos { get; set; }
    }
}
