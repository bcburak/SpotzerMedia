using Newtonsoft.Json.Linq;
using Spotzer.Media.Application.Interfaces;
using Spotzer.Media.Application.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Media.Application.Services
{
    public class OrderCreator<T>
        where T : IPartners
    {
        private T _partner;

        public OrderCreator(T partner)
        {
            _partner = partner;
        }

        public ResponseModel CreateOrder(JObject order)
        {
           return _partner.CreateOrder(order);
        }
    }
}
