using Microsoft.EntityFrameworkCore;

namespace AutoShopCrud.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Carros> Carro { get; set; }

    }
}
