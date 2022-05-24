using Microsoft.AspNetCore.Mvc;
using ToDo_List.Core.Entities;
using ToDo_List.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechYatra.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkController : ControllerBase
    {
        private readonly IWorkService _workService;
        private object work;

        public WorkController(IWorkService workService)
        {
            _workService = workService;   
        }
        // GET: api/<WorkController>
        [HttpGet]
        public List<Work> Get()
        {
            return _workService.GetAllWorks();
        }

        [HttpGet("{userId}")]
        public List<Work> Get(int userId)
        {
            return _workService.GetUserWorks(userId);
        }


        // POST api/<WorkController>
        [HttpPost]
        public Work Post([FromBody] Work work)
        {
            return _workService.CreateWork(work);
        }

        // PUT api/<WorkController>/
        [HttpPut("{id}")]
        public Work Put(int id, [FromBody] Work work)
        {
            return _workService.UpdateWork(work);
        }

        // DELETE api/<WorkController>/5
        [HttpDelete("{userId}/{id}")]
        public List<Work> Delete(int userId,int id)
        {
            var works = _workService.GetAllWorks();
            var work = works.SingleOrDefault(s => s.Id == id);
             _workService.DeleteWork(work);
            var userWorks = _workService.GetUserWorks(userId);
            userWorks = userWorks.Where(w => w.IsDeleted == false).ToList();
            return userWorks;
        }
    }
}
