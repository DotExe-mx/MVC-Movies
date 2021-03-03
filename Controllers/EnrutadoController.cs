
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
   /* [Route("api/[controller]")]
    [ApiController]*/
    [Route("Enrutado")]
    public class EnrutadoController : Controller
    {
         //[HttpGet]
        [Route("")]
        [Route("Index")]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
    }
}