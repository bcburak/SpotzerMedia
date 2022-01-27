using FluentValidation.Results;
using Newtonsoft.Json.Linq;
using Spotzer.Media.Application.Interfaces;
using Spotzer.Media.Application.Validations;
using Swashbuckle.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Media.Application.Dtos
{
    public  class PartnerA : Order, IPartners
    {

        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMobile { get; set; }
        public string ContactEmail { get; set; }

        public ResponseModel CreateOrder(JObject order)
        {
            var mappedPartner = order.ToObject<PartnerA>();

            var validator = new PartnerAValidator();

            List<string> validationMessages = new List<string>();
            var validationResult = validator.Validate(mappedPartner);
            var response = new ResponseModel();
            if (!validationResult.IsValid)
            {
                response.IsSuccess = false;
                foreach (ValidationFailure failure in validationResult.Errors)
                {
                    validationMessages.Add(failure.ErrorMessage);
                }
                response.Messages = validationMessages;
            }
            else
            {
                response.IsSuccess = true;
                response.Messages.Add("Partner A's order inserted successfully");
            }
            return response;

        }
        //Relation with order, website
    }

}
