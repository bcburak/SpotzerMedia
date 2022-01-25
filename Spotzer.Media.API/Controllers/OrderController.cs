using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Spotzer.Media.Application.Dtos;
using Spotzer.Media.Application.Extensions;
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
        //[SwaggerRequestExample(typeof(Order), typeof(OrderOperationModel))]
        public IActionResult AddOrder([FromBody] Newtonsoft.Json.Linq.JObject order)
        {
            var partner = GetJArrayValue(order, "Partner");

            if (String.IsNullOrEmpty(partner))
                throw new Exception("Partner value should not be null");

            OrderCreator<PartnerA> creator = new OrderCreator<PartnerA>(new PartnerA());
            var returnVal = creator.CreateOrder(order);


            //var orderCollection = DynamicExtensions.ToCollections(order);
            //var dic = orderCollection as Dictionary<string, object>;
            //var asd = DynamicExtensions.DictionaryToObject<PartnerA>(dic);





            //var dic = new Dictionary<string, string>();

            //foreach (var item in dic)
            //{
            //    var property = typeof(ICollection).GetProperty("Count");
            //    int count = (int)property.GetValue(item.Value, null);
            //}

            //var orderModal = new Order();

            //for(int i=0; i<= dic.Count();i++)
            //{
            //    orderModal.CompanyName
            //}
            ////var asd = order.ToObject<IDictionary<string, object>>();
            //var partnerA = new PartnerA();
            //partnerA.Partner
            //partnerA.ContactFirstName = dic["ContactFirstName"].ToString();

            return Ok(returnVal);
        }

        private string GetJArrayValue(JObject yourJArray, string key)
        {
            foreach (KeyValuePair<string, JToken> keyValuePair in yourJArray)
            {
                if (key == keyValuePair.Key)
                {
                    return keyValuePair.Value.ToString();
                }
            }
            return string.Empty;
        }

    }
}
