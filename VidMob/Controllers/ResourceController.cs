using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using VidMob.Models;

//should implement an action filter that pre process an incoming request to check if the current user has access to the resource the user is trying to access.
namespace VidMob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        // GET api/<ResourcesController>
        [HttpGet]
        public IActionResult Resources()
        {
            //this method should not return all the resources in the sytem but only the resources that the current user has access to.
            var response = new Response<IEnumerable<Resource>>
            {
                Data = new List<Resource>(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Ok(JsonConvert.SerializeObject(response));
        }

        // GET api/<ResourcesController>/{resourceId}}
        [HttpGet("{id}")]
        public IActionResult Resources(int id)
        {
            Resource resource = new Resource();
            if (resource.IsFolder)
            {
                var response = new Response<Resource>
                {
                    Data = new Resource(),
                    Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
                };
                return Ok(JsonConvert.SerializeObject(response));
            }
            return File(new MemoryStream(), ".docx", "filename");
        }

        // GET api/<ResourcesController>/project/{projectId}}
        [HttpGet("project/{id}")]
        public IActionResult ProjectResources(int id)
        {
            var response = new Response<IEnumerable<Resource>>
            {
                Data = new List<Resource>(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Ok(JsonConvert.SerializeObject(response));
        }

        // POST api/<ResourcesController>
        [HttpPost]
        public IActionResult Post([FromBody] Resource resource)
        {
            var response = new Response<Resource>
            {
                Data = new Resource(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Created($"/api/Resources/{resource.Id}", JsonConvert.SerializeObject(response));
        }

        // PUT api/<ResourcesController>/{resourceId}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Resource resource)
        {
            var response = new Response<Resource>
            {
                Data = new Resource(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Ok(JsonConvert.SerializeObject(response));
        }

        // DELETE api/<ResourcesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
