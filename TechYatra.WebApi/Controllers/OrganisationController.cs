using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechYatra.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganisationController : ControllerBase
    {
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

        // POST api/<OrganisationController>
        [HttpPost]
        public void Post([FromBody] string value)
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
