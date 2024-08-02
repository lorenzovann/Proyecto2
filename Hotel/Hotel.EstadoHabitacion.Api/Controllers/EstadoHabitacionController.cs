using Hotel.EstadoHabitacion.Application.Dto;
using Hotel.EstadoHabitacion.Application.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hotel.EstadoHabitacion.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class EstadoHabitacionController : ControllerBase
    {
        public readonly IEstadoHabitacionService? estadoHabitacionService;
        
        public EstadoHabitacionController(IEstadoHabitacionService estadoHabitacionService) 
        { 
             this.estadoHabitacionService = estadoHabitacionService;    
        } 
        // GET: api/<EstadoHabitacionController>
        [HttpGet("Get EstadoHabitacion")]
        public IActionResult Get()
        {
            var result = this.estadoHabitacionService?.GetEstadoHabitacion();

            if (result?.Success != true)
            {
                return BadRequest(result);
            }
            return Ok(result);

            

        }

        // GET api/<EstadoHabitacionController>/5
        [HttpGet("Get EstadoHabitacion by id")]
        public IActionResult Get(int id)
        {
            var result = this.estadoHabitacionService?.GetEstadoHabitacionById(id);

            if (result?.Success != true)
            {
                return BadRequest(result);
            }
            return Ok(result);



        }

        // POST api/<EstadoHabitacionController>
        [HttpPost("Save EstadoHabitacion")]
        public IActionResult Post([FromBody] EstadoHabitacionDTOSave estadoHabitacionDTOSave)
        {
            var result = this.estadoHabitacionService?.SaveEstadoHabitacion(estadoHabitacionDTOSave);

            if (result?.Success != true)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        // PUT api/<EstadoHabitacionController>/5
        [HttpPut("Update EstadoHabitacion")]
        public IActionResult Put(EstadoHabitacionDTOUpdate estadoHabitacionDTOUpdate)
        {
            var result = this.estadoHabitacionService?.UpdateEstadoHabitacion(estadoHabitacionDTOUpdate);

            if (result?.Success != true)
            {
                return BadRequest(result);
            }
            return Ok();
        }

        // DELETE api/<EstadoHabitacionController>/5
        [HttpDelete("Remove EstadoHabitacion")]
        public IActionResult Delete(EstadoHabitacionDTORemove estadoHabitacionDTORemove)
        {
            var result = this.estadoHabitacionService?.RemoveEstadoHabitacion(estadoHabitacionDTORemove);

            if (result?.Success != true)
            {
                return BadRequest(result);
            }
            return Ok();
        }
    }
}
