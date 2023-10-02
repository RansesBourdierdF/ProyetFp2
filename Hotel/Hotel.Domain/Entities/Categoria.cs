using Hotel.Domain.Core;
using System;

namespace Hotel.Domain.Entities
{
    public class Categoria : BaseEntity, IEquatable<Categoria?>
    {
        private readonly bool eliminar;

        public Categoria(DateTime? modificarFecha, string? idCategoria, string? descripcion, string? estado) : base(modificarFecha)
        {
            IdCategoria = idCategoria;
            Descripcion = descripcion;
            Estado = estado;
        }

        public Categoria(bool eliminar) : base(eliminar)
        {
            // Asignar el valor de eliminar a la propiedad local o realizar otras operaciones si es necesario.
            this.eliminar = eliminar;
        }

        public string? IdCategoria { get; set; }
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Categoria);
        }

        public bool Equals(Categoria? other)
        {
            return !(other is null) &&
                   FechaCreacion == other.FechaCreacion &&
                   CreacionDeUsuario == other.CreacionDeUsuario &&
                   ModificarFecha == other.ModificarFecha &&
                   UsuarioMod == other.UsuarioMod &&
                   EliminacionDeUsuario == other.EliminacionDeUsuario &&
                   FechaDeEliminacion == other.FechaDeEliminacion &&
                   Eliminar == other.Eliminar &&
                   IdCliente == other.IdCliente &&
                   eliminar == other.eliminar &&
                   IdCategoria == other.IdCategoria &&
                   Descripcion == other.Descripcion &&
                   Estado == other.Estado;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}


