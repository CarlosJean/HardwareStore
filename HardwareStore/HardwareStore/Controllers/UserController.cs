using HardwareStore.Data;
using HardwareStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace HardwareStore.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase {
        private readonly HardwareStoreContext _db;
        public UserController(HardwareStoreContext hardwareStoreContext) {
            this._db = hardwareStoreContext;
        }

        [HttpPost("login")]
        public ActionResult Login([FromBody]User user) {

            int userFound = this._db.Users
                .Where(u => u.Username == user.Username.ToUpper() && u.Pass == user.Pass)
                .ToList().Count;

            if (userFound == 0) return NotFound();
                
            return Ok();
        }

    }
}
