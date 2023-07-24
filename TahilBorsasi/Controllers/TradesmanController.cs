using Microsoft.AspNetCore.Mvc;

namespace TahilBorsasi.Api.Controllers
{
    public class TradesmanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
