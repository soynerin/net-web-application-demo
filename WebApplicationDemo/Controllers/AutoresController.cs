using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Entidades;

namespace WebApplicationDemo.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>() { new Autor() { Id = 1, Nombre = "Neri" } }; 
        }
    }
}
