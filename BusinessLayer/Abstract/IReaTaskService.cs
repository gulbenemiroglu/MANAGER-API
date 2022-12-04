using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReaTaskService
    {
        void Add(ReaTask reaTask);
        void Delete(ReaTask reaTask);
        void Update(ReaTask reaTask);
        List<ReaTask> GetAll();
        ReaTask GetId(int id);
        ReaTask GetById(int reaTaskId);
        List<ReaTask> GetListWithComment();
    }
}
