using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntitiesLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReaTaskController : ControllerBase
    {
        IReaTaskService _reaTaskService;
        public ReaTaskController(IReaTaskService reaTaskService)
        {
            _reaTaskService = reaTaskService;
        }
        [HttpGet("getAll")]
        public List<ReaTask> GetAll()
        {
            return _reaTaskService.GetListWithComment();
        }
        //[HttpGet("getAllWithComment")]
        //public List<ReaTask> GetAllWithComment()
        //{
        //    return _reaTaskService.GetListWithComment();
        //}
        [HttpPost("add")]
        public void Add([FromBody] ReaTask reaTask)
        {
            //ReaTaskValidation reaTaskVal = new ReaTaskValidation();
            //ValidationResult result = reaTaskVal.Validate(reaTask);

            //if (result.IsValid)
            //{
            //    _reaTaskService.Add(reaTask);
            //}
            //else
            //{
            //    foreach (var item in result.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}
            _reaTaskService.Add(reaTask);
        }
        [HttpDelete("Delete/{id}")]
        public void Delete([FromBody] ReaTask reaTask)
        {
            //ReaTaskValidation reaTaskVal = new ReaTaskValidation();
            //ValidationResult result = reaTaskVal.Validate(reaTask);

            //if (result.IsValid)
            //{
            //    var selectedId = _reaTaskService.GetId(reaTask.ReaTaskId);
            //    _reaTaskService.Delete(selectedId);
            //}
            //else
            //{
            //    foreach (var item in result.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}

            _reaTaskService.Delete(reaTask);
        }
        [HttpPut("update")]
        public void Update([FromBody] ReaTask reaTask)
        {
            //ReaTaskValidation reaTaskVal = new ReaTaskValidation();
            //ValidationResult result = reaTaskVal.Validate(reaTask);
            //if (result.IsValid)
            //{
            //    _reaTaskService.Update(reaTask);
            //}
            //else
            //{
            //    foreach (var item in result.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}
          
            _reaTaskService.Update(reaTask);
        }
        [HttpGet("getId/{id}")]
        public ReaTask GetId(int id)
        {
            return _reaTaskService.GetId(id);
        }
        [HttpGet("getById/{id}")]
        public ReaTask GetById(int id)
        {
            return _reaTaskService.GetById(id);
        }
    }
}
