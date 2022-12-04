using DataAccessLayer;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using System;
using BusinessLayer.Abstract;
using EntitiesLayer.Concrete;
using FluentValidation.Results;
using BusinessLayer.ValidationRules;
using System.Linq;

namespace AdminUI.Controllers
  
{
    public class ReaTaskController : Controller
    {
        IReaTaskService _reaTaskService;
        public ReaTaskController(IReaTaskService reaTaskService)
        {
            _reaTaskService = reaTaskService;
        }
        public IActionResult Index()
        {
            return View();
        }
       

        [HttpGet]
        public IActionResult ListReaTask()
        {
           
            var result = _reaTaskService.GetListWithOwner();
            return View(result);

        }
        [HttpGet]
        public IActionResult AddReaTask()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddReaTask(ReaTask reaTask)
        {
            ReaTaskValidation productValid = new ReaTaskValidation();
            ValidationResult results = productValid.Validate(reaTask);
            if (results.IsValid)
            {
                _reaTaskService.Add(reaTask);
                TempData.Add("message", String.Format("Task added successfuly!"));

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    TempData.Add("message", String.Format("Task didn't add!"));
                }
            }
            return RedirectToAction("ListReaTask", "ReaTask");
        }

        [HttpGet]
        public IActionResult UpdateReaTask(int id)
        {
            using (Context context = new Context())
            {
                var result = context.ReaTasks.FirstOrDefault(x => x.ReaTaskId == id);
                return View(result);
            }

        }
        [HttpPost]
        public IActionResult UpdateReaTask(ReaTask reaTask)
        {
            _reaTaskService.Update(reaTask);
            return RedirectToAction("ListReaTask", "ReaTask");
        }
        [HttpGet]
        public IActionResult DeleteReaTaskById(int id)

        {
            var ent = _reaTaskService.GetId(id);
            _reaTaskService.Delete(ent);
            return RedirectToAction("ListReaTask", "ReaTask");

        }
    }
}
