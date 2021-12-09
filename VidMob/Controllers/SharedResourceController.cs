using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using VidMob.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VidMob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharedResourceController : ControllerBase
    {
        // GET api/<SharedResourceController>/5
        [HttpGet("{resourceId}")]
        public IActionResult Get(int resourceId)
        {
            var response = new Response<IEnumerable<SharedResource>>
            {
                Data = new List<SharedResource>(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Ok(JsonConvert.SerializeObject(response));
        }

        // POST api/<SharedResourceController>
        [HttpPost]
        public IActionResult Post([FromBody] SharedResource sharedResource)
        {
            var response = new Response<SharedResource>
            {
                Data = new SharedResource(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Created("", JsonConvert.SerializeObject(response));
        }

        // DELETE api/<SharedResourceController>/5
        [HttpDelete("Resource/{resourceId}/Person/{personId}")]
        public IActionResult Delete(int resourceId, int personId)
        {
            return Ok();
        }
    }
}
