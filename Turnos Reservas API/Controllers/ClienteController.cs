using BLL.Implementations;
using DLL;
using Microsoft.AspNetCore.Mvc;


namespace Turnos_Reservas_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller {


        ClienteBusiness clienteBusiness = new ClienteBusiness();


        [HttpGet]
        public IActionResult Get()
        {
            List<Cliente> clientes = clienteBusiness.GetAll();

            if (clientes.Count == 0)
            {
                return NotFound(new
                {
                    message = "No hay clientes",
                    status = 404,
                    success = false
                });
            }

            return Ok(new
            {
                message = "Clientes encontrados",
                status = 200,
                success = true,
                data = clientes
            });



        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Cliente cliente = clienteBusiness.GetById(id);

            cliente.FechaNacimiento = cliente.FechaNacimiento.Date;

            if (cliente == null)
            {
                return NotFound(new {
                    message = "No existe dicho cliente",
                    status = 404,
                    success = false
                });
            }
            return Ok(new
            {
                message = "Cliente encontrado",
                status = 200,
                success = true,
                data = cliente
            });
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {

            return Ok(clienteBusiness.Add(cliente));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Cliente cliente)
        {

            bool result = clienteBusiness.Update(cliente);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }



        }

        [HttpDelete]
        public IActionResult Delete(int id)
           {
            return Ok(clienteBusiness.Delete(id));
        }



    }
}
