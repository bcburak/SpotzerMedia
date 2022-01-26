using FluentValidation;
using Spotzer.Media.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Media.Application.Validations
{
    public class PartnerBValidator : AbstractValidator<PartnerB>
    {
        public PartnerBValidator()
        {
            #region Standart Order Field Validators
            RuleFor(x => x.OrderID)
               .NotNull()
               .WithMessage("OrderID is required");
            RuleFor(x => x.TypeOfOrder)
                .NotNull()
                .WithMessage("TypeOfOrder is required");
            RuleFor(x => x.SubmittedBy)
                .NotNull()
                .WithMessage("SubmittedBy is required");
            RuleFor(x => x.CompanyID)
                .NotNull()
                .WithMessage("CompanyID is required");
            RuleFor(x => x.CompanyName)
                .NotNull()
                .WithMessage("CompanyName is required");
            #endregion
            RuleFor(x => x.LineItems).NotNull().WithMessage("Order should include product items");

           
            RuleForEach(x => x.LineItems).ChildRules(orders =>
            {
                //orders.RuleFor(x => x.WebSiteDetails).NotNull().When(i => i.AdwordCampaign == null).WithMessage("Website and Adword product can not be null");
                orders.RuleFor(x => x.WebSiteDetails).NotNull().When(i => i.AdwordCampaign == null).WithMessage("Website product can not be null");
                orders.RuleFor(x => x.AdwordCampaign).NotNull().When(i => i.WebSiteDetails == null).WithMessage("Paid Search product can not be null");
                orders.RuleFor(x => x.WebSiteDetails).ChildRules(website => website.RuleFor(i => i.WebsiteEmail).EmailAddress());

            }).When(i=>i.LineItems.Count() > 1);

            RuleForEach(x => x.LineItems).ChildRules(orders =>
            {
                //orders.RuleFor(x => x.WebSiteDetails).NotNull().When(i => i.AdwordCampaign == null).WithMessage("Website and Adword product can not be null");
                orders.RuleFor(x => x.WebSiteDetails).NotNull().WithMessage("Website product can not be null");
                orders.RuleFor(x => x.AdwordCampaign).NotNull().WithMessage("Paid Search product can not be null");
                orders.RuleFor(x => x.WebSiteDetails).ChildRules(website => website.RuleFor(i => i.WebsiteEmail).EmailAddress());

            }).When(i => i.LineItems.Count() == 1);
        }
    }
}
