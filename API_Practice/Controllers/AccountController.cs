using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ITokenServices _tokenServices;
        private readonly IAccountServices _accountServices;
        public AccountController(ITokenServices tokenServices, IAccountServices accountServices)
        {
            _tokenServices = tokenServices;
            _accountServices = accountServices;
        }
        // GET: api/<ValuesController>
        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            UserLogin userLogin = _accountServices.UserLogin(userName, password); 
            if (userName == "admin" && password == "admin@123")
            {
                var token = _tokenServices.CreateToken(userLogin);
                return Ok(token);
            }
             return Unauthorized("Invalid username or password.");
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
