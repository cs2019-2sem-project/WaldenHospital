using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Walden_Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        // GET api/Patient/{ID}
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // PUT api/Patient/{ID}
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Patient/{ID}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET api/Patient/{ID}/record
        [HttpGet("{id}/record")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/Patient/register
        [HttpPost("register")]
        public void Post([FromBody] string value)
        {
        }
    }
}
