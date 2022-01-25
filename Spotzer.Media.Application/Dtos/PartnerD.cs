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
    public class PartnerD : Order , IPartners
    {
        public ResponseModel CreateOrder(JObject order)
        {
            return new ResponseModel();
        }
        public void ValidatePartners()
        {

        }

        //Relation Order 
        //Relation PaidSearch
    }
}
