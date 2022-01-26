using FluentValidation;
using Spotzer.Media.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Media.Application.Validations
{
    public class PartnerCValidator : AbstractValidator<PartnerC>
    {
        public PartnerCValidator()
        {
            RuleFor(x => x.ExposureID)
                .NotNull()
                .WithMessage("ExposureID is required");
            RuleFor(x => x.UDAC)
                .NotNull()
                .WithMessage("UDAC is required");
            RuleFor(x => x.RelatedOrder)
                .NotNull()
                .WithMessage("RelatedOrder is required");

            RuleFor(x => x.LineItems).NotNull().WithMessage("Order should include product items");

            RuleForEach(x => x.LineItems).ChildRules(orders =>
            {
                orders.RuleFor(x => x.WebSiteDetails).NotNull().When(i => i.AdwordCampaign == null).WithMessage("Website product can not be null");
                orders.RuleFor(x => x.AdwordCampaign).NotNull().When(i => i.WebSiteDetails == null).WithMessage("Paid Search product can not be null");
                orders.RuleFor(x => x.WebSiteDetails).ChildRules(website => website.RuleFor(i => i.WebsiteEmail).EmailAddress());

            }).When(i => i.LineItems.Count() > 1);

            RuleForEach(x => x.LineItems).ChildRules(orders =>
            {
                orders.RuleFor(x => x.WebSiteDetails).NotNull().WithMessage("Website product can not be null");
                orders.RuleFor(x => x.AdwordCampaign).NotNull().WithMessage("Paid Search product can not be null");
                orders.RuleFor(x => x.WebSiteDetails).ChildRules(website => website.RuleFor(i => i.WebsiteEmail).EmailAddress());

            }).When(i => i.LineItems.Count() == 1);
        }
    }
}
