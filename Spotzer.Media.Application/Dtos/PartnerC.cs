using Newtonsoft.Json.Linq;
using Spotzer.Media.Application.Interfaces;
using Spotzer.Media.Application.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Media.Application.Dtos
{
    public class PartnerC :Order, IPartners
    {
        public int ExposureID { get; set; }
        public string UDAC { get; set; }
        public string RelatedOrder { get; set; }

        public ResponseModel CreateOrder(JObject order)
        {
            return new ResponseModel();
        }
        public void ValidatePartners()
        {

        }

        //Relation with Order , website and paidsearch
    }
}
