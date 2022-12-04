using BusinessLayer.Abstract;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AdminUI.Controllers
{
    public class RegisterController : Controller
    {
        IUserService _userService;
        public RegisterController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(User user)
        {
            _userService.Add(user);
            return RedirectToAction("Index", "Login");
        }
    }
}
