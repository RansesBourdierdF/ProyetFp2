using Hotel.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Hotel.Infrastructrure.Context
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {

        }

        public DbSet<EstadoHabitacion>? EstadoHabitacions { get; set; }
        public DbSet<Habitacion>? Habitacions{ get; set; }
    }
}
