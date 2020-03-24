using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebAPIWithPostgreSQL.Models;

namespace NetCoreWebAPIWithPostgreSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class denemController : ControllerBase
    {
        private WebAPIWithPostgreSQLContext _context;
        
        public denemController(WebAPIWithPostgreSQLContext context)
        {
            _context = context;
        }
        public IActionResult Deneme(){
            User x = new User(){
                Id = 2,
                Name = "Osman",
                Email = "asd@asd.com"
            };
            _context.Users.Add(x);
            _context.SaveChanges();
            return Ok();
        }
    }
}