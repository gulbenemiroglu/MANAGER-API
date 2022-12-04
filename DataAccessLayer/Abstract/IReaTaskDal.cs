using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReaTaskDal : IRepository<ReaTask>
    {
        List<ReaTask> GetListWithComment();
    }
}
