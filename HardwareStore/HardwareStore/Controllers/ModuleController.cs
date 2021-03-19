using HardwareStore.Data;
using HardwareStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HardwareStore.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : ControllerBase {

        private readonly HardwareStoreContext _db;
        public ModuleController(HardwareStoreContext hardwareStoreContext) {
            this._db = hardwareStoreContext;
        }

        // GET: api/<ModuleController>
        [HttpGet]
        public async Task<ActionResult> Get(int? userId = null) {            

            var query = this._db.Modules.Select(m => m);

            if (userId != null) query = query.Where(m => m.Users.Any(u => u.Id == userId));            

            var data = await query
                .Select(m => new { id = m.Id, name = m.Name })
                .ToListAsync();

            return Ok(data);
        }

        // GET api/<ModuleController>/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "value1";
        }

        // POST api/<ModuleController>
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/<ModuleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<ModuleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
