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
            RuleForEach(x => x.LineItems).ChildRules(orders =>
            {
                orders.RuleFor(x => x.WebSiteDetails).NotNull();
                orders.RuleFor(x => x.AdwordCampaign).NotNull();
            });
        }
    }
}
