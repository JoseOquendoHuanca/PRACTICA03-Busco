using System.Collections.Generic;

namespace PRACTICA03.Models
{
    public class muebles
    {
            public int Id { get; set; }
        public string Nombre { get; set; }

        
        public string Foto { get; set; }
          public ICollection<categoria> categoria { get; set; }


    }
}