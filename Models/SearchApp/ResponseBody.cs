namespace FaceProductAPI.Models.SearchApp
{
    public class ResponseBody
    {
        public class FICOApplicationResponse
        {
            public List<ApplicationSearchResult> applicationSearchResult { get; set; }

        }

        public class Address
        {
            public string line1 { get; set; }
            public string line2 { get; set; }
            public string postalCode { get; set; }
            public string countryCode { get; set; }
            public string line3 { get; set; }
            public string line4 { get; set; }
            public string district { get; set; }
            public string subDistrict { get; set; }
            public string province { get; set; }
            public bool isCommunicationAddress { get; set; }
            public int addressMonths { get; set; }
            public string addressResidenceTypeCode { get; set; }
            public string housingStatusCode { get; set; }
        }

        public class Applicant
        {
            public Person person { get; set; }
            public List<Address> address { get; set; }
        }

        public class ApplicationDetails
        {
            public string applicationStatusCode { get; set; }
            public string applicationNumber { get; set; }
            public string channelCode { get; set; }
            public DateTime appCreationDatetime { get; set; }
        }

        public class ApplicationSearchResult
        {
            public ApplicationDetails applicationDetails { get; set; }
            public List<Applicant> applicants { get; set; }
            public List<Facility> facilities { get; set; }
            public List<Document> documents { get; set; }
            public List<ApplicationStatusHistory> applicationStatusHistory { get; set; }
            public Parameters parameters { get; set; }
        }

        public class ApplicationStatusHistory
        {
            public string applicationStatus { get; set; }
            public DateTime applicationStatusDate { get; set; }
        }

        public class Document
        {
            public string typeCode { get; set; }
            public string documentLabelCode { get; set; }
            public string statusCode { get; set; }
            public bool isMandatory { get; set; }
            public string entityName { get; set; }
            public string idNumber { get; set; }
            public string idTypeCode { get; set; }
        }

        public class Facility
        {
            public string facilityCategoryCode { get; set; }
            public string productTypeCode { get; set; }
            public int systemDecision { get; set; }
            public int manualDecision { get; set; }
            public List<Offer> offers { get; set; }
            public FacilityCreditCard facilityCreditCard { get; set; }
            public FacilityUPL facilityUPL { get; set; }
            public FacilityUnsecuredBusinessLoan facilityUnsecuredBusinessLoan { get; set; }
        }

        public class FacilityCreditCard
        {
            public string paymentMethodCode { get; set; }
            public string paymentTermCode { get; set; }
            public string debitFromAccount { get; set; }
            public string cardDeliveryOptionCode { get; set; }
            public string creditCardToBeForwardToCode { get; set; }
            public string eStatementCode { get; set; }
        }

        public class FacilityUnsecuredBusinessLoan
        {
            public string paymentMethodCode { get; set; }
            public string paymentTermCode { get; set; }
            public string debitFromAccountCode { get; set; }
            public string accountNumberReceiving { get; set; }
        }

        public class FacilityUPL
        {
            public string accountNumber { get; set; }
            public string paymentMethodCode { get; set; }
            public string paymentTermCode { get; set; }
            public string debitFromAccountCode { get; set; }
        }

        public class Identification
        {
            public string idTypeCode { get; set; }
            public string reference { get; set; }
        }

        public class Offer
        {
            public int monthlyPayment { get; set; }
            public int limit { get; set; }
            public int interestRate { get; set; }
            public string loanTenureCode { get; set; }
            public string offerTypeCode { get; set; }
        }

        public class Parameters
        {
            public int maxDaysPendingDocument { get; set; }
        }

        public class Person
        {
            public string dateOfBirth { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public List<Identification> identification { get; set; }
        }

    }
}
