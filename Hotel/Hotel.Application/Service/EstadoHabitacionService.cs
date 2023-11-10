using System;
using Hotel.Application.Core;
using Hotel.Application.Dtos.EstadoHabitacion;
using Hotel.Infrastructrure.Interfaces;
using Microsoft.Extensions.Logging;
using Hotel.Domain.Entities;
using Hotel.Application.Contracts;

namespace School.Application.Services
{
    public class EstadoHabitacionService : IEstadoHabitacionService
    {

        private readonly IEstadoHabitacionRepository estadoHabitacionRepository;
        private readonly ILogger<EstadoHabitacionService> logger;

        public EstadoHabitacionService(IEstadoHabitacionRepository estadoHabitacionRepository,
                             ILogger<EstadoHabitacionService> logger)
        {
            this.estadoHabitacionRepository = estadoHabitacionRepository;
            this.logger = logger;
        }


        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = this.estadoHabitacionRepository.GetEstadoHabitacions();
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = $"Error obteniendo los cursos.";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult GetById(int Id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = this.estadoHabitacionRepository.GetEstadoHabitacions(Id);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = $"Error obteniendo el curso";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }

        public ServiceResult Remove(EstadoHabitacionDtoRemove dtoRemove)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                EstadoHabitacion estadoHabitacion = new EstadoHabitacion()
                {
                    IdEstadoHabitacion = dtoRemove.IdEstadoHabitacion,
                    Deleted = dtoRemove.Deleted,
                    UserDeleted = dtoRemove.ChangeUser,
                    DeletedDate = dtoRemove.ChangeDate
                };

                this.estadoHabitacionRepository.Remove(estadoHabitacion);

                result.Message = "El curso fue removido correctamente.";
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = $"Error removiendo el curso";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }

        public ServiceResult Save(EstadoHabitacionDtoAdd dtoAdd)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                EstadoHabitacion estadoHabitacion = new EstadoHabitacion()
                {
                    IdEstadoHabitacion = dtoAdd.IdEstadoHabitacion,
                    Descripcion = dtoAdd.Descripcion,
                    FechaCreacion = dtoAdd.FechaCreacion,
                    Estado = dtoAdd.Estado
                };

                this.estadoHabitacionRepository.Save(estadoHabitacion);

                result.Message = "El curso fue guardado correctamente.";
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = $"Error guardando el curso";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }

        public ServiceResult Update(EstadoHabitacionDtoUpdate dtoUpdate)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                EstadoHabitacion estadoHabitacion = new EstadoHabitacion()
                {
                    IdEstadoHabitacion = dtoUpdate.IdEstadoHabitacion,
                    Descripcion = dtoUpdate.Descripcion,
                    ModifyDate = dtoUpdate.ChangeDate,
                    UserMod = dtoUpdate.ChangeUser,
                    Estado = dtoUpdate.Estado

                };

                this.estadoHabitacionRepository.Update(estadoHabitacion);

                result.Message = "El curso fue actualizado correctamente.";
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = $"Error actualizando el curso";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }
    }
}
        