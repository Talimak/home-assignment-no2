using Microsoft.AspNetCore.Mvc;
using matala1y3.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace matala1y3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class moviesController : ControllerBase
    {
        private readonly Movie movie = new Movie();
        // GET: api/<moviesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Movie.Read());
        }

        [HttpGet("rating/{rating}")]
        public IActionResult Get(double rating)
        {
            try
            {
                return Ok (movie.ReadByRating(rating));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("duration")]
        public IActionResult GetByDuration([FromQuery] int duration)
        {
            try
            {
                return Ok(movie.ReadByDuration(duration));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<moviesController>
        [HttpPost]
        public IActionResult Post([FromBody] Movie m)
        {
            try
            {
                movie.Insert(m);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
