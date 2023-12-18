using Hotel.Application.Core;
using Hotel.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotel.Application.Services
{
    internal class CategoriaService : IBaseService<CategoriaDtoAgregar, CategoriaDtoActualizar, CategoriaDtoRemover>
    {
        private readonly List<CategoriaDto> categorias;  // Supongamos que tienes una lista de categorías como ejemplo

        public CategoriaService()
        {
            // Inicializa la lista de categorías (esto puede variar según tu implementación real)
            this.categorias = new List<CategoriaDto>
            {
                new CategoriaDto { Id = 1, Nombre = "Categoria 1" },
                new CategoriaDto { Id = 2, Nombre = "Categoria 2" },
                // Agrega más categorías según sea necesario
            };
        }

        public ServiceResult ObtenerTodo()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = this.categorias;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Mensaje = $"Ocurrió un error al obtener todas las categorías.";
                // Loguea el error si es necesario
            }

            return result;
        }

        public ServiceResult ObtenerPorId(int Id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                var categoria = this.categorias.FirstOrDefault(c => c.Id == Id);

                if (categoria != null)
                {
                    result.Data = categoria;
                }
                else
                {
                    result.Success = false;
                    result.Mensaje = $"No se encontró la categoría con el Id {Id}.";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Mensaje = $"Ocurrió un error al obtener la categoría por Id.";
                // Loguea el error si es necesario
            }

            return result;
        }

        public ServiceResult Guardar(CategoriaDtoAgregar dtoAgregar)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                // Realiza validaciones adicionales si es necesario

                CategoriaDto nuevaCategoria = new CategoriaDto
                {
                    Id = this.categorias.Count + 1,  // Genera un nuevo Id (esto puede variar según tu implementación real)
                    Nombre = dtoAgregar.Nombre,
                    // Agrega más propiedades según sea necesario
                };

                this.categorias.Add(nuevaCategoria);

                result.Mensaje = "La categoría fue agregada correctamente.";
                result.Data = nuevaCategoria.Id;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Mensaje = $"Ocurrió un error al guardar la categoría.";
                // Loguea el error si es necesario
            }

            return result;
        }

        public ServiceResult Actualizar(CategoriaDtoActualizar dtoActualizar)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                var categoriaExistente = this.categorias.FirstOrDefault(c => c.Id == dtoActualizar.Id);

                if (categoriaExistente != null)
                {
                    // Realiza validaciones adicionales si es necesario

                    categoriaExistente.Nombre = dtoActualizar.Nombre;
                    // Actualiza más propiedades según sea necesario

                    result.Mensaje = "La categoría fue actualizada correctamente.";
                }
                else
                {
                    result.Success = false;
                    result.Mensaje = $"No se encontró la categoría con el Id {dtoActualizar.Id}.";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Mensaje = $"Ocurrió un error al actualizar la categoría.";
                // Loguea el error si es necesario
            }

            return result;
        }

        public ServiceResult Remover(CategoriaDtoRemover dtoRemover)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                var categoriaExistente = this.categorias.FirstOrDefault(c => c.Id == dtoRemover.Id);

                if (categoriaExistente != null)
                {
                    // Realiza validaciones adicionales si es necesario

                    this.categorias.Remove(categoriaExistente);

                    result.Mensaje = "La categoría fue eliminada correctamente.";
                }
                else
                {
                    result.Success = false;
                    result.Mensaje = $"No se encontró la categoría con el Id {dtoRemover.Id}.";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Mensaje = $"Ocurrió un error al eliminar la categoría.";
                // Loguea el error si es necesario
            }

            return result;
        }
    }

    // Clases DTO para agregar, actualizar y remover categorías (puedes definirlas según tus necesidades)
    public class CategoriaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        // Agrega más propiedades según sea necesario
    }

    public class CategoriaDtoAgregar
    {
        public string Nombre { get; set; }
        // Agrega más propiedades según sea necesario
    }

    public class CategoriaDtoActualizar
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        // Agrega más propiedades según sea necesario
    }

    public class CategoriaDtoRemover
    {
        public int Id { get; set; }
        // Agrega más propiedades según sea necesario
    }
}
