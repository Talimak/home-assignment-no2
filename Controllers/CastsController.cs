using matala1y3.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace matala1y3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastsController : ControllerBase
    {
        private readonly Cast cast = new Cast();
        // GET: api/<CastsController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Cast.Read());
        }

     

        // POST api/<CastsController>
        [HttpPost]
        public IActionResult Post([FromBody] Cast c)
        {
            try
            {
                cast.Insert(c);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
