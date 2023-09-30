using Hotel.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Hotel.Infrastructrure.Context
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
             
        }

        public DbSet<RolUsuario>? RolUsuarios { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }
    }
}
