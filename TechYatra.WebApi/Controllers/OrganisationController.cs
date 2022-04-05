using Microsoft.AspNetCore.Mvc;
using TechYatra.WebApi.models;
using ToDo_List.Core.Entities;
using ToDo_List.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechYatra.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganisationController : ControllerBase
    {
        private readonly IOrganisationService _service;
        public OrganisationController(IOrganisationService service)
        {
            _service = service;
        }
        // GET: api/<OrganisationController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<OrganisationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet("GetOrganisationsByUserId/{userId}")]
        public List<OrganisationModel> GetOrganisationsByUserid(int userId)
        {
            var data =  _service.GetOrganisationsByUserId(userId);
            var models = new List<OrganisationModel>();
            data.ForEach(d =>
            {
                var model = new OrganisationModel();
                model.OrganisationId = d.Id;
                model.Name = d.Name;
                model.Purpose = d.Purpose;
                model.Description = d.Description;
                model.CreatedAt = d.CreatedAt;
                models.Add(model);
            });
            return models;
        }
        [HttpGet("GetUsersByOraganisation/{organisationId}")]
        public List<User> GetUsersByOrganisation(int oraganisationId)
        {
            var data = _service.GetAllUsersByOrganisationId(oraganisationId);
            return data;


        }

        // POST api/<OrganisationController>
        [HttpPost]
        public void Post([FromBody] Organisation  obj)
        {
        }


        // PUT api/<OrganisationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrganisationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
