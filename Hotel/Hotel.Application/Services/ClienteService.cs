
using Hotel.Application.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotel.Application.Services
{
    internal class ClienteService : IBaseService<ClienteDtoAgregar, ClienteDtoActualizar, ClienteDtoRemover>
    {
        private readonly List<ClienteDto> clientes;  

        public ClienteService()
        {
            
            this.clientes = new List<ClienteDto>
            {
                new ClienteDto { Id = 1, Nombre = "Cliente 1" },
                new ClienteDto { Id = 2, Nombre = "Cliente 2" },
               
            };
        }

        public ServiceResult ObtenerTodo()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = this.clientes;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Mensaje = $"Ocurrió un error al obtener todos los clientes.";
                
            }

            return result;
        }

        public ServiceResult ObtenerPorId(int Id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                var cliente = this.clientes.FirstOrDefault(c => c.Id == Id);

                if (cliente != null)
                {
                    result.Data = cliente;
                }
                else
                {
                    result.Success = false;
                    result.Mensaje = $"No se encontró el cliente con el Id {Id}.";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Mensaje = $"Ocurrió un error al obtener el cliente por Id.";
              
            }

            return result;
        }

        public ServiceResult Guardar(ClienteDtoAgregar dtoAgregar)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                

                ClienteDto nuevoCliente = new ClienteDto
                {
                    Id = this.clientes.Count + 1,  
                    Nombre = dtoAgregar.Nombre,
                    // Agrega más propiedades según sea necesario
                };

                this.clientes.Add(nuevoCliente);

                result.Mensaje = "El cliente fue agregado correctamente.";
                result.Data = nuevoCliente.Id;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Mensaje = $"Ocurrió un error al guardar el cliente.";
                
            }

            return result;
        }

        public ServiceResult Actualizar(ClienteDtoActualizar dtoActualizar)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                var clienteExistente = this.clientes.FirstOrDefault(c => c.Id == dtoActualizar.Id);

                if (clienteExistente != null)
                {
                    // Realiza validaciones adicionales si es necesario

                    clienteExistente.Nombre = dtoActualizar.Nombre;
                    // Actualizar más propiedades según sea necesario

                    result.Mensaje = "El cliente fue actualizado correctamente.";
                }
                else
                {
                    result.Success = false;
                    result.Mensaje = $"No se encontró el cliente con el Id {dtoActualizar.Id}.";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Mensaje = $"Ocurrió un error al actualizar el cliente.";
               
            }

            return result;
        }

        public ServiceResult Remover(ClienteDtoRemover dtoRemover)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                var clienteExistente = this.clientes.FirstOrDefault(c => c.Id == dtoRemover.Id);

                if (clienteExistente != null)
                {
                    // Realiza validaciones adicionales si es necesario

                    this.clientes.Remove(clienteExistente);

                    result.Mensaje = "El cliente fue eliminado correctamente.";
                }
                else
                {
                    result.Success = false;
                    result.Mensaje = $"No se encontró el cliente con el Id {dtoRemover.Id}.";
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Mensaje = $"Ocurrió un error al eliminar el cliente.";
                // Loguea el error si es necesario
            }

            return result;
        }
    }

    // Clases DTO para agregar, actualizar y remover clientes (puedes definirlas según tus necesidades)
    public class ClienteDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        
    }

    public class ClienteDtoAgregar
    {
        public string Nombre { get; set; }
     
    }

    public class ClienteDtoActualizar
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
   
    }

    public class ClienteDtoRemover
    {
        public int Id { get; set; }
        
    }
}
