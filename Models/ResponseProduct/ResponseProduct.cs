using System;

namespace FaceProductAPI.Models.ResponseProduct
{
    public class ResponseProduct
    {
        public Application application { get; set; }
    }


    public class Application
    {
        public RequestDetail requestDetail { get; set; }
        public ApplicationDetails applicationDetails { get; set; }
        public List<Applicants> applicants { get; set; }
        public List<SuggestedProducts> suggestedProducts { get; set; }
        public List<RulesAudit> rulesAudit { get; set; }
    }


    public class RequestDetail
    {
        public string callType { get; set; } = string.Empty;
    }

    public class ApplicationDetails
    {
        public string channel { get; set; } = string.Empty;
        public string leadRefNumber { get; set; } = string.Empty;
    }

    public class Applicants
    {
        public Person person { get; set; }
        public CustomerKYCDetail customerKYCDetail { get; set; }
    }

    public class Person
    {
        public string dateOfBirth { get; set; } = string.Empty;
        public string idType { get; set; } = string.Empty;
        public string issueDate { get; set; } = string.Empty;
        public string nationality { get; set; } = string.Empty;
        public string bblIalCode { get; set; } = string.Empty;
        public string allocationCode { get; set; } = string.Empty;
        public bool preScreenedOrLead { get; set; }
        public string idIssueDate { get; set; } = string.Empty;
    }

    public class CustomerKYCDetail
    {
        public string kycStatus { get; set; } = string.Empty;
        public string riskLevel { get; set; } = string.Empty;

    }

    public class SuggestedProducts
    {
        public string facilityCategory { get; set; } = string.Empty;
        public string productNameTH { get; set; } = string.Empty;
        public string productNameEN { get; set; } = string.Empty;

        public string productShortNameTH { get; set; } = string.Empty;
        public string productShortNameEN { get; set; } = string.Empty;

        public string productCode { get; set; } = string.Empty;

        public string productDesc { get; set; } = string.Empty;

        public string saleSheet { get; set; } = string.Empty;

        public string productCatalog { get; set; } = string.Empty;
        public string compareTableLink { get; set; } = string.Empty;

        public string preApprovedFlag { get; set; } = string.Empty;

        public List<Categories> categories { get; set; }
        public List<Benefits> benefits { get; set; }
        public List<UWCriterias> uwCriterias { get; set; }
    }

    public class Categories
    {
        public string category { get; set; } = string.Empty;
    }

    public class Benefits
    {
        public string benefitCodebenefit { get; set; } = string.Empty;
    }

    public class UWCriterias
    {
        public string entityType { get; set; } = string.Empty;
        public string uwAuthorityLevel { get; set; } = string.Empty;
        public bool appealAllowed { get; set; }
        public string reasonCode { get; set; } = string.Empty;
        public string reasonDesc { get; set; } = string.Empty;
        public string decision { get; set; } = string.Empty;
        public string partyId { get; set; } = string.Empty;
        public string reasonPriority { get; set; } = string.Empty;
    }


    public class RulesAudit
    {
        public string metaphorName { get; set; } = string.Empty;
        public string rule { get; set; } = string.Empty;
        public string timeStamp { get; set; } = string.Empty;
    }

}
