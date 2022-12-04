using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReaTaskManager : IReaTaskService
    {
        IReaTaskDal _reaTaskDal;
        public ReaTaskManager(IReaTaskDal reaTaskDal)
        {
            _reaTaskDal=reaTaskDal; 
        }
        public void Add(ReaTask reaTask)
        {
            _reaTaskDal.Add(reaTask);   
        }

        public void Delete(ReaTask reaTask)
        {
            _reaTaskDal.Delete(reaTask);
        }

        public List<ReaTask> GetAll()
        {
            return _reaTaskDal.GetAll();
        }

        public ReaTask GetById(int reaTaskId)
        {
            return _reaTaskDal.GetById(x => x.ReaTaskId == reaTaskId);
        }

        public ReaTask GetId(int id)
        {
            return _reaTaskDal.GetId(id);
        }

        public List<ReaTask> GetListWithComment()
        {
            return _reaTaskDal.GetListWithComment();
        }

        public void Update(ReaTask reaTask)
        {
            _reaTaskDal.Update(reaTask);
        }
    }
}
