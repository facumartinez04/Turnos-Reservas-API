using BLL.Implementations;
using DLL;
using Microsoft.AspNetCore.Mvc;

namespace Turnos_Reservas_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        ServicioBLL servicioBLL = new ServicioBLL();

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(new
                {
                    title = "Servicios",
                    status = 200,
                    detail = servicioBLL.GetAll()
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    title = "Error",
                    status = 400,
                    detail = ex.Message

                });
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            try {
                return Ok(new
                {
                    title = "Servicio",
                    status = 200,
                    detail = servicioBLL.GetById(id)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    title = "Error",
                    status = 400,
                    detail = ex.Message
                });
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Servicio servicio)
        {
            try
            {
             bool result = servicioBLL.Add(servicio);

                return Ok(new
                {
                    title = "Servicio",
                    status = 200,
                    detail = result
                });

            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    title = "Error",
                    status = 400,
                    detail = ex.Message
                });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Servicio servicio)
        {
            try
            {
                return Ok(new
                {
                    title = "Servicio",
                    status = 200,
                    detail = servicioBLL.Update(servicio)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    title = "Error",
                    status = 400,
                    detail = ex.Message
                });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(new
                {
                    title = "Servicio",
                    status = 200,
                    detail = servicioBLL.Delete(id)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    title = "Error",
                    status = 400,
                    detail = ex.Message
                });
            }
        }
    }
}
