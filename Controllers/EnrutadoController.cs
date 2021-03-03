
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrutadoController : Controller
    {
        //Nuevo enrutamiento de atributos a la pagina index.
        //[Route("/Enrutado/Tocayo")]

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}