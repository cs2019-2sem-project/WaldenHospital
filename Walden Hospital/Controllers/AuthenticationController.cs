using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Walden_Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        // GET api/Authentication/login
        [HttpGet("login")]
        public ActionResult<string> Get()
        {
            return "testhash";
        }

        // GET api/Authentication/logout
        [HttpGet("logout")]
        public IActionResult Get()
        {
            return OK();
        }

        // POST api/Authentication/register
        [HttpPost("register")]
        public void Post([FromBody] string value)
        {
        }
        
    }
}
