using FilmesAPI.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperarFilmesID), new {Id = filme.Id}, filme);
        }

        [HttpGet]
        public IActionResult RecuperarFilmes()
        {
            return Ok(filmes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarFilmesID(int id)
        {
            Filme filme = filmes.FirstOrDefault(filme => filme.Id == id);
            if(filme != null)
            {
                return Ok(filme);
            }
            return NotFound();
        }
    }
}
