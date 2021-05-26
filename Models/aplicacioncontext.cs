using Microsoft.EntityFrameworkCore;

namespace PRACTICA03.Models
{
    public class aplicacioncontext : DbContext
    {
        public DbSet<arte> artes { get; set; }
        public DbSet<muebles> mueble { get; set; }
        public DbSet<ropa> ropas { get; set; }
        public DbSet<tecnologia> tecnologias { get; set; }
      

        public aplicacioncontext(DbContextOptions dco) : base(dco) {

        }
    }
}