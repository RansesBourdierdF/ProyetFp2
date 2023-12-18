

using Hotel.Application.Core;
using Hotel.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotel.Application.Services
{
    internal class ClienteService : IBaseService<ClienteDtoAgregar, ClienteDtoActualizar, ClienteDtoRemover>
    {
        private readonly List<ClienteDto> clientes;  // Supongamos que tienes una lista de clientes como ejemplo

        public ClienteService()
        {
            // Inicializa la lista de clientes (esto puede variar según tu implementación real)
            this.clientes = new List<ClienteDto>
            {
                new ClienteDto { Id = 1, Nombre = "Cliente 1" },
                new ClienteDto { Id = 2, Nombre = "Cliente 2" },
                // Agrega más clientes según sea necesario
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
                // Loguea el error si es necesario
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
                // Loguea el error si es necesario
            }

            return result;
        }

        public ServiceResult Guardar(ClienteDtoAgregar dtoAgregar)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                // Realiza validaciones adicionales si es necesario

                ClienteDto nuevoCliente = new ClienteDto
                {
                    Id = this.clientes.Count + 1,  // Genera un nuevo Id (esto puede variar según tu implementación real)
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
                // Loguea el error si es necesario
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
                    // Actualiza más propiedades según sea necesario

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
                // Loguea el error si es necesario
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
        // Agrega más propiedades según sea necesario
    }

    public class ClienteDtoAgregar
    {
        public string Nombre { get; set; }
        // Agrega más propiedades según sea necesario
    }

    public class ClienteDtoActualizar
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        // Agrega más propiedades según sea necesario
    }

    public class ClienteDtoRemover
    {
        public int Id { get; set; }
        // Agrega más propiedades según sea necesario
    }
}
