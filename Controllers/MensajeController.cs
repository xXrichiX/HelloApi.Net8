using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HolaMundoAPI.Interfaces;
using HolaMundoAPI.Models;

namespace HolaMundoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensajeController : ControllerBase
    {
        private readonly ILogger<MensajeController> _logger;
        private readonly IMensajeService _mensajeService;

        public MensajeController(ILogger<MensajeController> logger, IMensajeService mensajeService)
        {
            _logger = logger;
            _mensajeService = mensajeService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Mensaje), StatusCodes.Status200OK)]
        public async Task<ActionResult<Mensaje>> Get()
        {
            _logger.LogInformation("mensaje desde el controlador");
            var mensaje = await _mensajeService.ObtenerMensajeAsync(1);
            return Ok(mensaje);
        }
    }
}