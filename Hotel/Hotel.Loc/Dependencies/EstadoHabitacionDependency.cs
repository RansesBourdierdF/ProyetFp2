using Microsoft.Extensions.DependencyInjection;
//using Hotel.Application.Contracts;
//using Hotel.Application.Services;
using Hotel.Infrastructrure.Repositories;
using Hotel.Infrastructrure.Interfaces;

namespace School.Ioc.Dependencies
{
    public static class CourseDependency
    {
        public static void AddCourseDependecy(this IServiceCollection service)
        {
            service.AddScoped<IEstadoHabitacionRepository, EstadoHabitacionRepository>();
           //service.AddTransient<ICourseService, CourseService>();
        }
    }
}

