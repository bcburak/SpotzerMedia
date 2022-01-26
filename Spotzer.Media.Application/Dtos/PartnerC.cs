using FluentValidation.Results;
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
            var mappedPartner = order.ToObject<PartnerC>();

            var validator = new PartnerCValidator();

            List<string> validationMessages = new List<string>();
            var validationResult = validator.Validate(mappedPartner);
            var response = new ResponseModel();
            if (!validationResult.IsValid)
            {
                response.IsValid = false;
                foreach (ValidationFailure failure in validationResult.Errors)
                {
                    validationMessages.Add(failure.ErrorMessage);
                }
                response.Messages = validationMessages;
            }
            else
            {
                response.Messages.Add("Partner C's order inserted successfully");
            }
            return response;
        }

        //Relation with Order , website and paidsearch
    }
}
