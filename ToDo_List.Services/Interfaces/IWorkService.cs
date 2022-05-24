using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_List.Core.Entities;

namespace ToDo_List.Services.Interfaces
{
    public interface IWorkService
    {
        List<Work> GetAllWorks();
        Work CreateWork(Work work);
        Work UpdateWork(Work work);
        bool DeleteWork(Work work);
        List<Work> GetUserWorks(int userId);
    }
}
