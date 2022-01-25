using Newtonsoft.Json.Linq;
using Spotzer.Media.Application.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Media.Application.Interfaces
{
    public interface IPartners
    {
        ResponseModel CreateOrder(JObject order);
        void ValidatePartners();
        
    }
}
