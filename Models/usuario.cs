namespace PRACTICA03.Models
{
    public class usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public categoria categoria { get; set; }
        public int arteId { get; set; }
        public int ropaId { get; set; }
        public int muebleId { get; set; }

        public int tecnologiaId { get; set; }
        
    }
}