using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using VidMob.Models;

//should implement an action filter that pre process an incoming request to check if the current user has access to the project and is an authorized user who has permissions to perform CRUD.
namespace VidMob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        // GET: api/<ProjectController>
        [HttpGet]
        public IActionResult Get()
        {
            //this method should not return all the projects in the sytem but only the projects that the current user has access to.
            var response = new Response<IEnumerable<Project>>
            {
                Data = new List<Project>(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Ok(JsonConvert.SerializeObject(response));
        }

        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var response = new Response<Project>
            {
                Data = new Project(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Ok(JsonConvert.SerializeObject(response));
        }

        // GET api/project/5/persons
        [HttpGet("{id}/persons")]
        public IActionResult ProjectPersons(int id)
        {
            var response = new Response<IEnumerable<Person>>
            {
                Data = new List<Person>(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Ok(JsonConvert.SerializeObject(response));
        }

        // POST api/<ProjectController>
        [HttpPost]
        public IActionResult Post([FromBody] Project project)
        {
            var response = new Response<Project>
            {
                Data = new Project(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Created("/api/Project/{id}", JsonConvert.SerializeObject(response));
        }

        // PUT api/<ProjectController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Project project)
        {
            var response = new Response<Project>
            {
                Data = new Project(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Ok(JsonConvert.SerializeObject(response));
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
