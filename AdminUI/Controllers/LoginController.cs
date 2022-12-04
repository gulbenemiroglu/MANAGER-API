using DataAccessLayer;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AdminUI.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        public IActionResult Index(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {

            var bilgi = c.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);
            if (bilgi != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,bilgi.Name),
                    new Claim(ClaimTypes.Role,bilgi.Role)


                };

                var identity = new ClaimsIdentity(claims, "Index");
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);

                if (TempData["returnUrl"] != null)
                {
                    if (Url.IsLocalUrl(TempData["returnUrl"].ToString()))
                    {
                        return Redirect(TempData["returnUrl"].ToString());
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

    }
}
