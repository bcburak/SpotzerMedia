using Spotzer.Media.Application.Dtos;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spotzer.Media.API
{
    public class SwaggerCustomizationFilter : IMultipleExamplesProvider<SwaggerModel>
    {
        public IEnumerable<SwaggerExample<SwaggerModel>> GetExamples()
        {
            // An example without a summary.
            yield return SwaggerExample.Create(
                "Partner A",
                    new SwaggerModel
                    {
                        Partner ="A",
                        OrderID ="sample string1",
                        TypeOfOrder = "sample string 8",
                        SubmittedBy ="sample string 11",
                        CompanyName = "sample string 29",
                        CompanyID = "sample string 28",
                        ContactFirstName ="sample string",
                        ContactLastName = "sample strin123",
                        ContactTitle = "sample string 15",
                        ContactPhone ="sample string 234",
                        ContactMobile ="sample string 453",
                        ContactEmail = "sample string 453",
                        LineItems = new List<LineItems>()
                        {
                            new LineItems
                            {
                               ID =1,
                               ProductID ="sample string 17",
                               ProductType ="sample string 18",
                               Notes = "sample string 53",
                               Category ="sample string 245",
                               WebSiteDetails = new WebSiteDetails
                               {
                                   TemplateId ="sample string 245",
                                   WebsiteBusinessName = "sample string 245",
                                   WebsiteAddressLine1 = "sample string 246",
                                   WebsiteAddressLine2 = "sample string 247",
                                   WebsiteCity =  "sample string 248",
                                   WebsiteState = "sample string 249",
                                   WebsitePostCode ="sample string 250",
                                   WebsitePhone = "sample string 257",
                                   WebsiteEmail = "sample string 258",
                                   WebsiteMobile =  "sample string 259",
                               }
                            }

                        }

                    }
            );

            yield return SwaggerExample.Create(
                "Partner B",
                     new SwaggerModel
                     {
                         Partner = "B",
                         OrderID = "sample string1",
                         TypeOfOrder = "sample string 8",
                         SubmittedBy = "sample string 11",
                         CompanyName = "sample string 29",
                         CompanyID = "sample string 28",
                         LineItems = new List<LineItems>()
                        {
                            new LineItems
                            {
                               ID =1,
                               ProductID ="sample string 17",
                               ProductType ="sample string 18",
                               Notes = "sample string 53",
                               Category ="sample string 245",

                               WebSiteDetails = new WebSiteDetails
                               {
                                   TemplateId ="sample string 245",
                                   WebsiteBusinessName = "sample string 245",
                                   WebsiteAddressLine1 = "sample string 246",
                                   WebsiteAddressLine2 = "sample string 247",
                                   WebsiteCity =  "sample string 248",
                                   WebsiteState = "sample string 249",
                                   WebsitePostCode ="sample string 250",
                                   WebsitePhone = "sample string 257",
                                   WebsiteEmail = "sample string 258",
                                   WebsiteMobile =  "sample string 259",
                               },
                               
                            },
                            new LineItems
                            {
                               ID =1,
                               ProductID ="sample string 17",
                               ProductType ="sample string 18",
                               Notes = "sample string 53",
                               Category ="sample string 245",
                               AdwordCampaign = new AdwordCampaign
                               {
                                   CampaignName = "sample string 1",
                                   CampaignAddressLine1="sample string 2",
                                   CampaignPostCode = "sample string 6",
                                   CampaignRadius = "sample string 13",
                                   LeadPhoneNumber = "sample string 14",
                                   SMSPhoneNumber = "sample string 15",
                                   UniqueSellingPoint1= "sample string 18",
                                   UniqueSellingPoint2 = "sample string 19",
                                   UniqueSellingPoint3 = "sample string 20",
                                   Offer = "sample string 21",
                                   DestinationURL= "sample string 23",
                               }
                            }

                        }

                     }
            );

            yield return SwaggerExample.Create(
               "Partner C",
                    new SwaggerModel
                    {
                        Partner = "C",
                        OrderID = "sample string1",
                        TypeOfOrder = "sample string 8",
                        SubmittedBy = "sample string 11",
                        CompanyName = "sample string 29",
                        CompanyID = "sample string 28",
                        ExposureID = 123,
                        UDAC = "sample string 31",
                        RelatedOrder = "sample string 123",
                        LineItems = new List<LineItems>()
                        {
                            new LineItems
                            {
                               ID =1,
                               ProductID ="sample string 17",
                               ProductType ="sample string 18",
                               Notes = "sample string 53",
                               Category ="sample string 245",

                               WebSiteDetails = new WebSiteDetails
                               {
                                   TemplateId ="sample string 245",
                                   WebsiteBusinessName = "sample string 245",
                                   WebsiteAddressLine1 = "sample string 246",
                                   WebsiteAddressLine2 = "sample string 247",
                                   WebsiteCity =  "sample string 248",
                                   WebsiteState = "sample string 249",
                                   WebsitePostCode ="sample string 250",
                                   WebsitePhone = "sample string 257",
                                   WebsiteEmail = "sample string 258",
                                   WebsiteMobile =  "sample string 259",
                               },
                            },
                            new LineItems
                            {
                               ID =1,
                               ProductID ="sample string 17",
                               ProductType ="sample string 18",
                               Notes = "sample string 53",
                               Category ="sample string 245",
                               AdwordCampaign = new AdwordCampaign
                               {
                                   CampaignName = "sample string 1",
                                   CampaignAddressLine1="sample string 2",
                                   CampaignPostCode = "sample string 6",
                                   CampaignRadius = "sample string 13",
                                   LeadPhoneNumber = "sample string 14",
                                   SMSPhoneNumber = "sample string 15",
                                   UniqueSellingPoint1= "sample string 18",
                                   UniqueSellingPoint2 = "sample string 19",
                                   UniqueSellingPoint3 = "sample string 20",
                                   Offer = "sample string 21",
                                   DestinationURL= "sample string 23",
                               }
                            }

                        }

                    }
           );
            yield return SwaggerExample.Create(
               "Partner D",
                    new SwaggerModel
                    {
                        Partner = "D",
                        OrderID = "sample string1",
                        TypeOfOrder = "sample string 8",
                        SubmittedBy = "sample string 11",
                        CompanyName = "sample string 29",
                        CompanyID = "sample string 28",
                        LineItems = new List<LineItems>()
                       {
                            new LineItems
                            {
                               ID =1,
                               ProductID ="sample string 17",
                               ProductType ="sample string 18",
                               Notes = "sample string 53",
                               Category ="sample string 245",

                               AdwordCampaign = new AdwordCampaign
                               {
                                   CampaignName = "sample string 1",
                                   CampaignAddressLine1="sample string 2",
                                   CampaignPostCode = "sample string 6",
                                   CampaignRadius = "sample string 13",
                                   LeadPhoneNumber = "sample string 14",
                                   SMSPhoneNumber = "sample string 15",
                                   UniqueSellingPoint1= "sample string 18",
                                   UniqueSellingPoint2 = "sample string 19",
                                   UniqueSellingPoint3 = "sample string 20",
                                   Offer = "sample string 21",
                                   DestinationURL= "sample string 23",
                               }
                            }

                       }

                    }
           );

        }
    }
}
