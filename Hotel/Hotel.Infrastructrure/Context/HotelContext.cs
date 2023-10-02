using Hotel.Infrastructure.Context;
using System.Collections.Generic;
using System.Diagnostics;

namespace Hotel.Infrastructure.Context
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
        

    }

    public DbSet<Cliente> Clientes { get; set; } = null!;
        public DbSet<Categoria> Categorias { get; set; } = null!;

        public class Cliente
        {
            public int Id { get; set; }
            // Otras propiedades del cliente
        }

        public class Categoria
        {
            public int Id { get; set; }
            // Otras propiedades de la categoría
        }
    }

    public class DbSet<T>
    {
    }

    // DbSet personalizado no parece ser necesario en este contexto.
    // public class DbSet<T>
    // {
    // }
}

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class DbContext
{
    public DbContext(DbContextOptions<HotelContext> options)
    {
        Options = options;
    }

    public DbContextOptions<HotelContext> Options { get; }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
