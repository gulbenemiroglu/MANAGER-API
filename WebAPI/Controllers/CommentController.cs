using BusinessLayer.Abstract;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    public class CommentController : Controller
    {
        ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpGet("getAll")]
        public List<Comment> GetAll()
        {
            return _commentService.GetAll();
        }
        
        [HttpPost("add")]
        public void Add([FromBody] Comment comment)
        {
            //CommentValidation commentVal = new CommentValidation();
            //ValidationResult result = commentVal.Validate(comment);

            //if (result.IsValid)
            //{
            //    _commentService.Add(comment);
            //}
            //else
            //{
            //    foreach (var item in result.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}
            _commentService.Add(comment);
        }
        [HttpDelete("Delete{id}")]
        public void Delete([FromBody] Comment comment)
        {
            //CommentValidation commentVal = new CommentValidation();
            //ValidationResult result = commentVal.Validate(comment);

            //if (result.IsValid)
            //{
            //    var selectedId = _commentService.GetId(comment.CommentId);
            //    _commentService.Delete(selectedId);
            //}
            //else
            //{
            //    foreach (var item in result.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}

            _commentService.Delete(comment);
        }
        [HttpPut("update")]
        public void Update([FromBody] Comment comment)
        {
            //CommentValidation commentVal = new CommentValidation();
            //ValidationResult result = commentVal.Validate(comment);
            //if (result.IsValid)
            //{
            //    _commentService.Update(comment);
            //}
            //else
            //{
            //    foreach (var item in result.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}

            _commentService.Update(comment);
        }
        [HttpGet("getId{id}")]
        public Comment GetId(int id)
        {
            return _commentService.GetId(id);
        }
        [HttpGet("getById{id}")]
        public Comment GetById(int id)
        {
            return _commentService.GetById(id);
        }
    }
}
