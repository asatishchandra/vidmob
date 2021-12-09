using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using VidMob.Models;

namespace VidMob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        //GET  api/Persons
        [HttpGet]
        public IActionResult Get()
        {
            var response = new Response<IEnumerable<Person>>
            {
                Data = new List<Person>(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Ok(JsonConvert.SerializeObject(response));
        }
        // GET api/Persons/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var response = new Response<Person>
            {
                Data = new Person(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Ok(JsonConvert.SerializeObject(response));
        }

        // POST api/Persons
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            var response = new Response<Person>
            {
                Data = new Person(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Created("/api/Users/{id}", JsonConvert.SerializeObject(response));
        }

        // PUT api/Persons/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Person person)
        {
            var response = new Response<Person>
            {
                Data = new Person(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Ok(JsonConvert.SerializeObject(response));
        }

        // DELETE api/Persons/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
