using System;
using Hotel.Application.Contracts;
using Hotel.Application.Core;
using Hotel.Application.Dtos.EstadoHabitacion;
using Hotel.Application.Dtos.Habitacion;
using Hotel.Domain.Entities;
using Hotel.Infrastructrure.Interfaces;
using Microsoft.Extensions.Logging;
using School.Application.Services;

namespace Hotel.Application.Service
{
    public class HabitacionService : IHabitacionService
    {
        private readonly IHabitacionRepository habitacionRepository;
        private readonly ILogger<HabitacionService> logger;

        public HabitacionService(IHabitacionRepository habitacionRepository,
                             ILogger<HabitacionService> logger)
        {
            this.habitacionRepository = habitacionRepository;
            this.logger = logger;
        }


        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = this.habitacionRepository.GetHabitacions();
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
                result.Data = this.habitacionRepository.GetHabitacions(Id);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = $"Error obteniendo el curso";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }

        public ServiceResult Remove(HabitacionDtoRemove dtoRemove)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                Habitacion habitacion = new Habitacion()
                {
                    IdHabitacion = dtoRemove.IdHabitacion,
                    Deleted = dtoRemove.Deleted,
                    UserDeleted = dtoRemove.ChangeUser,
                    DeletedDate = dtoRemove.ChangeDate
                };

                this.habitacionRepository.Remove(habitacion);

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

        public ServiceResult Save(HabitacionDtoAdd dtoAdd)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                Habitacion habitacion = new Habitacion()
                {
                    IdHabitacion = dtoAdd.IdHabitacion,
                    Numero = dtoAdd.Numero,
                    Detalle = dtoAdd.Detalle,
                    Precio = dtoAdd.Precio,
                    IdestadoHabitacion = dtoAdd.IdestadoHabitacion,
                    IdPiso = dtoAdd.IdPiso,
                    IdCategoria = dtoAdd.IdCategoria,
                    Estado = dtoAdd.Estado
                };

                this.habitacionRepository.Save(habitacion);

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

        public ServiceResult Update(HabitacionDtoUpdate dtoUpdate)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                Habitacion habitacion = new Habitacion()
                {
                    IdHabitacion = dtoUpdate.IdHabitacion,
                    Numero = dtoUpdate.Numero,
                    Detalle = dtoUpdate.Detalle,
                    Precio = dtoUpdate.Precio,
                    IdestadoHabitacion = dtoUpdate.IdestadoHabitacion,
                    IdPiso = dtoUpdate.IdPiso,
                    IdCategoria = dtoUpdate.IdCategoria,
                    ModifyDate = dtoUpdate.ChangeDate,
                    UserMod = dtoUpdate.ChangeUser,
                    Estado = dtoUpdate.Estado

                };

                this.habitacionRepository.Update(habitacion);

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

