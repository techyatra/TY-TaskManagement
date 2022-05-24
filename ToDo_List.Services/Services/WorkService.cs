using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_List.Core.Entities;
using ToDo_List.Infrastructure.Interfaces;
using ToDo_List.Services.Interfaces;

namespace ToDo_List.Services.Services
{
    public class WorkService : IWorkService
    {
        private readonly IContextService _contextService;
        private object work;

        public WorkService(IContextService contextService)
        {
            _contextService = contextService;
        }
        public Work CreateWork(Work work)
        {
            return _contextService.CreateWork(work);
        }
        public Work UpdateWork(Work work)
        {
            return _contextService.UpdateWork(work);
        }

        public List<Work> GetAllWorks()
        {
            return _contextService.GetAllWorks();
        }

        public List<Work> GetUserWorks(int userId)
        {
            return _contextService.GetUserWorks(userId);
        }

        public bool DeleteWork(Work work)
        {
            return _contextService.DeleteWork(work);

        }

        
    }
}
