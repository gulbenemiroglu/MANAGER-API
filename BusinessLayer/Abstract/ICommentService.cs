using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void Add(Comment comment);
        void Delete(Comment comment);
        void Update(Comment comment);
        List<Comment> GetAll();
        Comment GetId(int id);
        Comment GetById(int commentId);
    }
}
