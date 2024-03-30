using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAutores.Entidades;

namespace WebApiAutores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AutoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>() { 
                new Autor { Id = 1, Nombre = "Marco" },  
                new Autor { Id = 2, Nombre = "David"}
            };
        }

        [HttpPost]
        public async Task<IActionResult> Post(Autor autor)
        {

        }
    }
}
