using BLL.Implementations;
using DLL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Turnos_Reservas_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoIdentificacionController : ControllerBase
    {
        TipoIdentificacionBusiness tipoIdentificacionController = new TipoIdentificacionBusiness();

        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                return Ok(new
                {
                    status = 200,
                    message = "Solicitud procesada correctamente",
                    data = tipoIdentificacionController.GetAll()
                });
            }
            catch (System.Exception)
            {
                return BadRequest(new
                {
                    status = 400,
                    message = "Error al procesar la solicitud"
                });

            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(new
                {
                    status = 200,
                    message = "Solicitud procesada correctamente",
                    data = tipoIdentificacionController.GetById(id)
                });
            }
            catch (System.Exception)
            {
                return BadRequest(new
                {
                    status = 400,
                    message = "Error al procesar la solicitud"
                });
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] TipoIdentificacion tipoIdentificacion)
        {

            try
            {
                return Ok(new
                {
                    status = 200,
                    message = "Solicitud procesada correctamente",
                    data = tipoIdentificacionController.Add(tipoIdentificacion)
                });
            }
            catch (System.Exception)
            {
                return BadRequest(new
                {
                    status = 400,
                    message = "Error al procesar la solicitud"
                });
            }
        }

        [HttpPut]

        public IActionResult Put([FromBody] TipoIdentificacion tipoIdentificacion)
        {
            try
            {
                return Ok(new
                {
                    status = 200,
                    message = "Solicitud procesada correctamente",
                    data = tipoIdentificacionController.Update(tipoIdentificacion)
                });
            }
            catch (System.Exception)
            {
                return BadRequest(new
                {
                    status = 400,
                    message = "Error al procesar la solicitud"
                });
            }
        }

        [HttpDelete]

        public IActionResult Delete([FromBody] TipoIdentificacion tipoIdentificacion)
        {

            try
            {
                return Ok(new
                {
                    status = 200,
                    message = "Solicitud procesada correctamente",
                    data = tipoIdentificacionController.Delete(tipoIdentificacion)
                });
            }
            catch (System.Exception)
            {
                return BadRequest(new
                {
                    status = 400,
                    message = "Error al procesar la solicitud"
                });
            }

        }
    }

}
