using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Spotzer.Media.Application.Dtos;
using Spotzer.Media.Application.Services;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Spotzer.Media.Application.Extensions;
using Spotzer.Media.Application.Validations;
using Swashbuckle.AspNetCore.Annotations;

namespace Spotzer.Media.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        // GET: HomeController
        private readonly ILogger<OrderController> _logger;
        private ResponseModel response;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpPost("AddOrder")]
        [SwaggerRequestExample(typeof(Order), typeof(SwaggerCustomizationFilter))]
        public IActionResult AddOrder([FromBody] Newtonsoft.Json.Linq.JObject order)
        {
            var partner = StaticHelper.GetJObjectValue(order, "Partner");

            if (String.IsNullOrEmpty(partner))
                throw new Exception("Partner value should not be null");

            var partnerList = StaticHelper.CheckPartnerFromList(partner);
            if (!partnerList)            
                throw new Exception("Partner not found in our records. Please contact company");

            switch (partner)
            {   
                case "A":
                    var creatorForA = new OrderCreator<PartnerA>(new PartnerA());
                    response = creatorForA.CreateOrder(order);
                    break;
                case "B":
                    var creatorForB = new OrderCreator<PartnerB>(new PartnerB());
                    response = creatorForB.CreateOrder(order);
                    break;
                case "C":
                    var creatorForC = new OrderCreator<PartnerC>(new PartnerC());
                    response = creatorForC.CreateOrder(order);
                    break;
                case "D":
                    var creatorForD = new OrderCreator<PartnerD>(new PartnerD());
                    response = creatorForD.CreateOrder(order);
                    break;
                default:
                    throw new Exception("No order is created!");
                    
            }


            return Ok(response);
        }

    

    }
}
