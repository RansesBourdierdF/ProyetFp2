
        public class Categoria
        {
            public int Id { get; set; }
            // Otras propiedades de la categoría
        }
    }

    public class DbContext
    {
        public DbContext(DbContextOptions<HotelContext> options)
        {
            Options = options;
        }

        public DbContextOptions<HotelContext> Options { get; }

    private string GetDebuggerDisplay()
    {
    }
}