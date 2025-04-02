using BLL.Implementations;
using DLL;
using Microsoft.AspNetCore.Mvc;


namespace Turnos_Reservas_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
       ReservaBLL reservaBLL = new ReservaBLL();

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(new
                {
                    title = "Reservas",
                    status = 200,
                    detail = reservaBLL.GetAll()
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
        public IActionResult Get(int id)
        {

            try
            {
                return Ok(new
                {
                    title = "Reserva",
                    status = 200,
                    detail = reservaBLL.GetById(id)
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
        public IActionResult Post([FromBody] Reserva reserva)
        {
            try
            { 

                return Ok(new 
                {
                    title = "Reserva",
                    status = 200,
                    detail = reservaBLL.Add(reserva)
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
        public IActionResult Put(int id, [FromBody] Reserva reserva)
        {

            try
            {
                return Ok(new
                {
                    title = "Reserva",
                    status = 200,
                    detail = reservaBLL.Update(reserva)
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
                    title = "Reserva",
                    status = 200,
                    detail = reservaBLL.Delete(id)
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
