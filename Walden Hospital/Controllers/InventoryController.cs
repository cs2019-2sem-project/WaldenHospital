using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Walden_Hospital.Controllers
{
    [Route("api/Pharmacy/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        // GET api/Pharmacy/Inventory/{ID}
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // GET api/Pharmacy/Inventory/list
        [HttpGet("list")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // PUT api/Pharmacy/Inventory/{ID}
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Pharmacy/Inventory/{ID}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // POST api/Pharmacy/Inventory/new
        [HttpPost("new")]
        public void Post([FromBody] string value)
        {
        }
    }
}
