using Hotel.Domain.Repository;
using Hotel.Infrastructrure.Context;
using Hotel.Infrastructrure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

//agregar dependencia del contexto//

builder.Services.AddDbContext<HotelContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("HotelContext")));

//Dependencia de los Repositorios//

builder.Services.AddTransient<IEstadoHabitacionRepository, EstadoHabitacionRepository>();
builder.Services.AddTransient<IHabitacionRepository, HabitacionRepository>();

//Dependencia de los App Services//

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
