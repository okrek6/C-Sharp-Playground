using CSharpPlayground.Models;
using CSharpPlayground.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSharpPlayground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        TaskService service;
        TaskController() 
        {
            service = new TaskService();
        }
        // GET: api/<TaskController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TaskController>/5
        [HttpGet("{id}")]
        public TaskModel Get(Guid id)
        {
            return service.GetTaskById(id);
        }

        // POST api/<TaskController2>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TaskController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TaskController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
