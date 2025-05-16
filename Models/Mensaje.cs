namespace HolaMundoAPI.Models
{
    public class Mensaje
    {
        public int Id { get; set; }
        public string Contenido { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}