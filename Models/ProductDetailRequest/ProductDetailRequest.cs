namespace FakeFICOAPI.Models.ProductDetailRequest
{
    public class ProductDetailRequest
    {
        public Application? application { get; set; }
    }

    public class Application
    {
        public RequestDetail? requestDetail { get; set; }
        public ApplicationDetails? applicationDetails { get; set; }
        public List<Applicants>? applicants { get; set; }
        public List<SuggestedProducts>? suggestedProducts { get; set; }
    }

    public class RequestDetail
    {
        public string? callType { get; set; } = string.Empty;
    }

    public class ApplicationDetails
    {
        public string? channel { get; set; } = string.Empty;
        public string leadRefNumber { get; set; } = string.Empty;
    }

    public class Applicants
    {
        public Person? person { get; set; }
        public CustomerKYCDetail? customerKYCDetail { get; set; }
    }

    public class Person
    {
        public string? dateOfBirth { get; set; } = string.Empty;
        public string? idType { get; set; } = string.Empty;
        public Decimal declaredIncome { get; set; }
        public string? issueDate { get; set; } = string.Empty;
        public string? nationality { get; set; } = string.Empty;
        public string? bblIalCode { get; set; } = string.Empty;
        public string? allocationCode { get; set; } = string.Empty;
        public bool? preScreenedOrLead { get; set; }
        public string? idIssueDate { get; set; } = string.Empty;
        public CustomerKYCDetail? customerKYCDetail { get; set; }
    }

    public class CustomerKYCDetail
    {
        public string? kycStatus { get; set; } = string.Empty;
        public string? riskLevel { get; set; } = string.Empty;

    }

    public class SuggestedProducts
    {
        public string? facilityCategory { get; set; } = string.Empty;

        public string? productCode { get; set; } = string.Empty;

    }
}
