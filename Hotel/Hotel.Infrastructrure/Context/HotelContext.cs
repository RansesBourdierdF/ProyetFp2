using Hotel.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Hotel.Infrastructrure.Context
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }
        public DbSet<Categoria>? Categoria { get; set; }    
        public DbSet<Cliente>? Cliente { get; set;}


    }
}
