using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using Microsoft.Data.SqlClient.DataClassification;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class ReaTaskDal:Repository<ReaTask>,IReaTaskDal
    {
        public List<ReaTask> GetListWithComment()
        {
            using (Context context = new Context())
            {
                return context.ReaTasks.Include(p => p.Comments).ToList();
            }
        }
    }
}
