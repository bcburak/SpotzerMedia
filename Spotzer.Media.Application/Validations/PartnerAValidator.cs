using FluentValidation;
using Spotzer.Media.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Media.Application.Validations
{
    public class PartnerAValidator: AbstractValidator<PartnerA>
    {
        public PartnerAValidator()
        {
            #region PartnerA requirements
            RuleFor(x => x.ContactFirstName)
                .NotNull()
                .WithMessage("ContactFirstName is required");
            RuleFor(x => x.ContactLastName)
                .NotNull()
                .WithMessage("ContactLastName is required");
            RuleFor(x => x.ContactTitle)
                .NotNull()
                .WithMessage("ContactTitle is required");
            RuleFor(x => x.ContactPhone)
                .NotNull()
                .WithMessage("ContactPhone is required");
            RuleFor(x => x.ContactMobile)
                .NotNull()
                .WithMessage("ContactMobile is required");
            RuleFor(x => x.ContactEmail).EmailAddress();
            #endregion
            RuleFor(x => x.LineItems).NotNull().WithMessage("Order should include product items");

            RuleForEach(x => x.LineItems).ChildRules(orders =>
            {
                orders.RuleFor(x => x.WebSiteDetails).NotNull().WithMessage("Website product can not be null");
                orders.RuleFor(x => x.WebSiteDetails).ChildRules(website => website.RuleFor(i => i.WebsiteEmail).EmailAddress());
            });
        }
    }
}
