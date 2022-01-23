using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Spotzer.Media.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spotzer.Media.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        // GET: HomeController
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

      
        [HttpPost("AddOrder")]
        public IActionResult AddOrder([FromBody] dynamic order)
        {

            //    _logger.LogInformation("Test");
            //    return CreatedAtAction("User Created : ", new { user.FirstName }, user);
           
            return Ok();
        }

    }
}
