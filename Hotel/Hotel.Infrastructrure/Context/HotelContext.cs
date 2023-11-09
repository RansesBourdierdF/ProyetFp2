using Hotel.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Hotel.Infrastructrure.Context
{
    public class HotelContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }

        public DbSet<EstadoHabitacion> EstadoHabitacions{ get; set; }
        public DbSet<Habitacion> Habitacions{ get; set; }
    }
}
