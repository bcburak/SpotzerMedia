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
    public class PartnerD : Order , IPartners
    {
        public ResponseModel CreateOrder(JObject order)
        {
            var mappedPartner = order.ToObject<PartnerD>();

            var validator = new PartnerDValidator();

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
                response.Messages.Add("Partner D's order inserted successfully");
            }
            return response;
        }
      

        //Relation Order 
        //Relation PaidSearch
    }
}
