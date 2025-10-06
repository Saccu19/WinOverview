using Microsoft.AspNetCore.Mvc;
using WinOverview.Data;
using WinOverview.Models;

namespace WinOverview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
        [HttpGet("List")]
        public IActionResult Get()
        {
            var employes = EmployeRepository.GetAll();
            return Ok(employes);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var employe = EmployeRepository.GetById(id);
            if (employe == null) return NotFound();
            return Ok(employe);
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                EmployeRepository.Remove(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody] Enploye employe)
        {
            if (!ModelState.IsValid || employe == null)
            {
                return BadRequest();
            }
            EmployeRepository.Add(employe);
            return Ok();
        }
    }
}
