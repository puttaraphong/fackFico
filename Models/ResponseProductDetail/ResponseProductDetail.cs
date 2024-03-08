

using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace FaceProductAPI.Models.ResponseProductDetail
{
    public class ResponseProductDetail
    {
        public Application application { get; set; }
    }

    public class Application
    {
        public RequestDetail? requestDetail { get; set; }
        public ApplicationDetails? applicationDetails { get; set; }
        public List<Applicants>? applicants { get; set; }
        public List<SuggestedProducts>? suggestedProducts { get; set; }
        public List<RulesAudit>? rulesAudit { get; set; }
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
        public Person? person { get; set; }
        public CustomerKYCDetail? customerKYCDetail { get; set; }
        public List<SuggestedDocuments>? suggestedDocuments { get; set; }
        public List<SuggestedConsents>? suggestedConsents { get; set; }
    }
    public class SuggestedDocuments
    {
        public string facilityCategory { get; set; }
        public string documentCategory { get; set; }
        public string documentPartyID { get; set; }
        public string documentType { get; set; }
        public string documentID { get; set; }
        public string documentDesc { get; set; }
        public string documentSubType { get; set; }
    }
    public class SuggestedConsents
    {
        public string facilityCategory { get; set; }
        public string productCode { get; set; }
        public string consentCode { get; set; }
        public string consentDesc { get; set; }
    }
    public class Person
    {
        public string dateOfBirth { get; set; }
        public string nationality { get; set; } = string.Empty;
        public decimal? declaredIncome { get; set; }
        public string idType { get; set; } = string.Empty;
        public string bblIalCode { get; set; } = string.Empty;
        public string allocationCode { get; set; } = string.Empty;
        public bool preScreenedOrLead { get; set; }
        public string idIssueDate { get; set; }
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
        public decimal requestedLimit { get; set; }

        public string productDesc { get; set; } = string.Empty;

        public string saleSheet { get; set; } = string.Empty;

        public string productCatalog { get; set; } = string.Empty;
        public string compareTableLink { get; set; } = string.Empty;

        public string preApprovedFlag { get; set; } = string.Empty;

        public string? firstEffectiveDate { get; set; }
        public string? lastEffectiveDate { get; set; }
        public string ddrRequired { get; set; } = string.Empty;
        public decimal minDDRRepaymentPercentage { get; set; }
        public decimal minDDRRepayment { get; set; }
        public decimal minAllowAge { get; set; }
        public decimal maxAllowAge { get; set; }
        public decimal minimumSalary { get; set; }
        public decimal minRequestLoan { get; set; }
        public decimal maxRequestLoan { get; set; }
        public decimal systemRecommendedMaxLoan { get; set; }
        public int orderId { get; set; }
        public List<AdditionalFee>? additionalFee { get; set; }
        public List<RepaymentPeriod>? repaymentPeriod { get; set; }
        public List<PaymentMethod>? paymentMethods { get; set; }
        public List<InterestRates>? interestRates { get; set; }
        public List<MultiplierRequestedLoans>? multiplierRequestedLoans { get; set; }
        public List<Categories>? categories { get; set; }
        public List<Benefits>? benefits { get; set; }
        public Decision? decision { get; set; }
       // public List<UWCriterias> uwCriterias { get; set; }
    }

    public class PaymentMethod
    {
        public string paymentMethod { get; set; }
    }

    public class AdditionalFee
    {
        public string feeType { get; set; } = string.Empty;
        public string feeUnit { get; set; } = string.Empty;
        public decimal feeValue { get; set; }
    }

    public class RepaymentPeriod
    {
        public decimal tentativeApprovedAmount { get; set; }
        public decimal tentativeLoanPeriod { get; set; }
        public decimal tentativeMI { get; set; }
        public decimal tentativeTotalRepayment { get; set; }
    }

    public class InterestRates
    {
        public string segment { get; set; } = string.Empty;
        public string rateType { get; set; } = string.Empty;
        public decimal minAmount { get; set; }
        public decimal maxAmount { get; set; }
        public decimal calculatedRate { get; set; }
        public decimal minRate { get; set; }
        public decimal maxRate { get; set; }
    }

    public class MultiplierRequestedLoans
    {
        public decimal minIncome { get; set; }
        public decimal maxIncome { get; set; }
        public decimal multiplier { get; set; }
        // public string listCategory { get; set; }
    }

    public class Categories
    {
        public string category { get; set; } = string.Empty;
    }

    public class Benefits
    {
        public string benefitCode { get; set; } = string.Empty;
    }

    public class Decision
    {
        public bool isAutoReject { get; set; }
        public bool overrideFlag { get; set; }
        public string recommendedCreditDecision { get; set; }
        public string finalReasonCode { get; set; }
        public string finalAuthorityLevel { get; set; }
        public string uwEmpowermentLevel { get; set; }
        public List<UWCriterias> uwCriteria { get; set; }
    }
    public class UWCriterias
    {
        public string entityType { get; set; } = string.Empty;
        public string partyID { get; set; } = string.Empty;
        public string reasonCode { get; set; } = string.Empty;
        public string reasonDesc { get; set; } = string.Empty;
        public bool isEligible { get; set; }
        public string decision { get; set; } = string.Empty;
        public string uwAuthorityLevel { get; set; } = string.Empty;
        public string reasonPriority { get; set; } = string.Empty;
        public bool appealAllowed { get; set; }

    }

    public class RulesAudit
    {
        public string metaphorName { get; set; } = string.Empty;
        public string rule { get; set; } = string.Empty;
        public string timeStamp { get; set; } = string.Empty;
    }
}
