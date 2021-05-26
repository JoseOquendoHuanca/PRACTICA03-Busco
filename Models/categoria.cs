using System.Collections.Generic;

namespace PRACTICA03.Models
{
    public class categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }


        public int arteId { get; set; }
        public int ropaId { get; set; }
        public int muebleId { get; set; }

        public int tecnologiaId { get; set; }
        
         public ICollection<usuario> usuario { get; set; }
    }
}