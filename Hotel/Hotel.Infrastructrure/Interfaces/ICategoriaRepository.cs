using Hotel.Domain.Entities;
using Hotel.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Infrastructrure.Interfaces
{
    public interface ICategoriaRepository : IBaseRepository<Categoria>
    {
        public string? CategoriaId { get; set; }
    }
}
