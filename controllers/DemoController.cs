using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using web_api_base.Models;

namespace web_api_base.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        public DemoController()
        {
            
        }

        [HttpGet("getall")]
        public async Task<ActionResult> GetAll()
        {
            
            return Ok("ok");
        }

       

    }
}