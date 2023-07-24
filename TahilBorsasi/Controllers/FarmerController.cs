using Microsoft.AspNetCore.Mvc;

namespace TahilBorsasi.Api.Controllers
{
    public class FarmerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
