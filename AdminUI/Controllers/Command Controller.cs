using Microsoft.AspNetCore.Mvc;

namespace AdminUI.Controllers
{
    public class Command_Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
