using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager:ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment comment)
        {
            _commentDal.Add(comment);
        }

        public void Delete(Comment comment)
        {
           _commentDal.Delete(comment);
        }

        public List<Comment> GetAll()
        {
           return _commentDal.GetAll();
        }

        public Comment GetById(int commentId)
        {
            return _commentDal.GetById(x => x.CommentId == commentId);
        }

        public Comment GetId(int id)
        {
            return _commentDal.GetId(id);
        }

        public void Update(Comment comment)
        {
            _commentDal.Update(comment);
        }
    }
}
