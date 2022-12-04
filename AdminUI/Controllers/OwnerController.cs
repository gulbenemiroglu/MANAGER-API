using BusinessLayer.Abstract;
using DataAccessLayer;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdminUI.Controllers
{
    public class OwnerController : Controller
    {
        IOwnerService _ownerService;
        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListOwner()
        {
            
            var result = _ownerService.GetAll();
            return View(result);

        }
        [HttpGet]
        public IActionResult AddOwner()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddOwner(Owner owner)
        {
            _ownerService.Add(owner);
            return RedirectToAction("ListOwner", "Owner");
        }

        [HttpGet]
        public IActionResult UpdateOwner(int id)
        {
            using (Context context = new Context())
            {
                var result = context.Owners.FirstOrDefault(x => x.OwnerId == id);
                return View(result);
            }

        }
        [HttpPost]
        public IActionResult UpdateOwner(Owner owner)
        {
            _ownerService.Update(owner);
            return RedirectToAction("ListOwner", "Owner");
        }
        [HttpGet]
        public IActionResult DeleteOwnerById(int id)

        {
            var ent = _ownerService.GetId(id);
            _ownerService.Delete(ent);
            return RedirectToAction("ListOwner", "Owner");

        }
    }
}
