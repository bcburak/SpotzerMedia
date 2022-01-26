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
        [SwaggerRequestExample(typeof(Order), typeof(SwaggerCustomizationFilter))]
        public IActionResult AddOrder([FromBody] Newtonsoft.Json.Linq.JObject order)
        {
            var partner = GetJArrayValue(order, "Partner");

            if (String.IsNullOrEmpty(partner))
                throw new Exception("Partner value should not be null");

            OrderCreator<PartnerA> creator = new OrderCreator<PartnerA>(new PartnerA());
            var returnVal = creator.CreateOrder(order);


            return Ok(returnVal);
        }

        private string GetJArrayValue(JObject yourJArray, string key)
        {
            string withLowerKey = char.ToLower(key[0]) + key.Substring(1);
            foreach (KeyValuePair<string, JToken> keyValuePair in yourJArray)
            {
                if (key == keyValuePair.Key || withLowerKey == keyValuePair.Key)
                {
                    return keyValuePair.Value.ToString();
                }
            }
            return string.Empty;
        }

    }
}
