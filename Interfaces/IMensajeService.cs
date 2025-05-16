using HolaMundoAPI.Models;

namespace HolaMundoAPI.Interfaces
{
    public interface IMensajeService
    {
        Task<Mensaje> ObtenerMensajeAsync(int id);
        Task<IEnumerable<Mensaje>> ObtenerTodosAsync();
        Task<Mensaje> CrearMensajeAsync(Mensaje mensaje);
        Task<Mensaje> ActualizarMensajeAsync(int id, Mensaje mensaje);
        Task<bool> EliminarMensajeAsync(int id);
    }
} 