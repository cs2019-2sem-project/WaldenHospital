using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Walden_Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        // GET api/Bill/{ID}
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // DELETE api/Bill/{ID}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // POST api/Bill/new
        [HttpPost("new")]
        public void Post([FromBody] string value)
        {
        }
    }
}
