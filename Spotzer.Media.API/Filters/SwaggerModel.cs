using Spotzer.Media.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spotzer.Media.API
{
    public class SwaggerModel :Order
    {
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMobile { get; set; }
        public string ContactEmail { get; set; }
        public int ExposureID { get; set; }
        public string UDAC { get; set; }
        public string RelatedOrder { get; set; }
    }
}
