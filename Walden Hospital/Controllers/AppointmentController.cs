using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Walden_Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        // GET api/Appointment/{ID}
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // PUT api/Appointment/{ID}
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Appointment/{ID}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // POST api/Appointment/new
        [HttpPost("new")]
        public void Post([FromBody] string value)
        {
        }
    }
}
