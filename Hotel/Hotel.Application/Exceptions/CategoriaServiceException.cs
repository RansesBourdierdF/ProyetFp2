using System;
using System.IO;

namespace Hotel.Application.Exceptions
{
    internal class CategoriaServiceException : Exception
    {
        public CategoriaServiceException(string mensaje) : base(mensaje)
        {

            LogErrorDetails(mensaje);
        }

        private void LogErrorDetails(string mensaje)
        {
            // Implementacion la lógica para registrar detalles del error en un archivo de registro
            string logFilePath = "error_log.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"Fecha y Hora: {DateTime.Now}");
                    writer.WriteLine($"Mensaje de Error: {mensaje}");
                   
                    writer.WriteLine("-------------------------------------------------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al intentar registrar en el archivo de registro: {ex.Message}");
            }
        }
    }
}

