using Microsoft.AspNetCore.Mvc;
using Module5HW2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module5HW2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("Register")]
        public string Register([FromForm] User user)
        {
            Console.WriteLine(JsonConvert.SerializeObject(user));
            return "HW!";
        }
    }
}

