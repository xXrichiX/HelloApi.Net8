using HolaMundoAPI.Interfaces;
using HolaMundoAPI.Models;
using Microsoft.Extensions.Logging;

namespace HolaMundoAPI.Services
{
    public class MensajeService : IMensajeService
    {
        private readonly ILogger<MensajeService> _logger;

        public MensajeService(ILogger<MensajeService> logger)
        {
            _logger = logger;
        }

        public async Task<Mensaje> ObtenerMensajeAsync(int id)
        {
            _logger.LogInformation("Obteniendo mensaje desde el servicio");
            
            return await Task.FromResult(new Mensaje
            {
                Id = id,
                Contenido = "Hola Mundooo",
                FechaCreacion = DateTime.Now
            });
        }

        public async Task<IEnumerable<Mensaje>> ObtenerTodosAsync()
        {
            return await Task.FromResult(new List<Mensaje>());
        }

        public async Task<Mensaje> CrearMensajeAsync(Mensaje mensaje)
        {
            return await Task.FromResult(mensaje);
        }

        public async Task<Mensaje> ActualizarMensajeAsync(int id, Mensaje mensaje)
        {
            return await Task.FromResult(mensaje);
        }

        public async Task<bool> EliminarMensajeAsync(int id)
        {
            return await Task.FromResult(true);
        }
    }
}