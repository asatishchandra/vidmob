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
    public class StatisticsController : ControllerBase
    {
        // GET api/<StatisticsController>/project/5
        [HttpGet]
        public IActionResult Get()
        {
            var response = new Response<IEnumerable<Statistics>>
            {
                Data = new List<Statistics>(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Ok(JsonConvert.SerializeObject(response));
        }
        // GET api/<StatisticsController>/project/5
        [HttpGet("project/{id}")]
        public IActionResult Get(int id)
        {
            var response = new Response<Statistics>
            {
                Data = new Statistics(),
                Status = new Status((int)HttpStatusCode.OK, true, string.Empty, string.Empty)
            };
            return Ok(JsonConvert.SerializeObject(response));
        }
    }
}
