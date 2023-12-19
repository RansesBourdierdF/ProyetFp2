using Hotel.Application.Core;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotel.Application.Services
{
    internal class CategoriaService : IBaseService<CategoriaDtoAgregar, CategoriaDtoActualizar, CategoriaDtoRemover>
    {
        private readonly List<CategoriaDto> categorias;  
        public CategoriaService()
        {
           
            this.categorias = new List<CategoriaDto>
            {
                new CategoriaDto { Id = 1, Nombre = "Categoria 1" },
                new CategoriaDto { Id = 2, Nombre = "Categoria 2" },
               
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
                
            }

            return result;
        }

        public ServiceResult Guardar(CategoriaDtoAgregar dtoAgregar)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                

                CategoriaDto nuevaCategoria = new CategoriaDto
                {
                    Id = this.categorias.Count + 1,  
                    Nombre = dtoAgregar.Nombre,
                   
                };

                this.categorias.Add(nuevaCategoria);

                result.Mensaje = "La categoría fue agregada correctamente.";
                result.Data = nuevaCategoria.Id;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Mensaje = $"Ocurrió un error al guardar la categoría.";
               
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
                    

                    categoriaExistente.Nombre = dtoActualizar.Nombre;
               

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
                
            }

            return result;
        }
    }

    
    public class CategoriaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        
    }

    public class CategoriaDtoAgregar
    {
        public string Nombre { get; set; }
       
    }

    public class CategoriaDtoActualizar
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        
    }

    public class CategoriaDtoRemover
    {
        public int Id { get; set; }
      
    }
}
