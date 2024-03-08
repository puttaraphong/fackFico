namespace FakeFICOAPI.Models.CreateApp
{
    public class RequestApplicationSubmit
    {
        public List<Applicant> applicants { get; set; }
        public ApplicationDetails applicationDetails { get; set; }
        public List<Facility> facilities { get; set; }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Address
    {
        public bool isCommunicationAddress { get; set; }
        public string addressResidenceTypeCode { get; set; }
        public string countryCode { get; set; }
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string line3 { get; set; }
        public string line4 { get; set; }
        public string postalCode { get; set; }
        public string province { get; set; }
        public string district { get; set; }
        public string subDistrict { get; set; }
        public int yearAtAddress { get; set; }
        public int addressMonth { get; set; }
        public string housingStatusCode { get; set; }
    }

    public class AlternateIdentification
    {
        public string idTypeCode { get; set; }
        public string reference { get; set; }
        public string expiryDate { get; set; }
        public string issueDate { get; set; }
        public string placeIssued { get; set; }
    }

    public class Applicant
    {
        public string applicationRoleCode { get; set; }
        public string relationShipToPrimaryCode { get; set; }
        public Person person { get; set; }
        public List<Email> emails { get; set; }
        public List<Address> address { get; set; }
        public List<Phone> phones { get; set; }
        public PdpaConsentVO pdpaConsentVO { get; set; }
        public BureauConsentVO bureauConsentVO { get; set; }
        public List<CommunicationChannel> communicationChannels { get; set; }
        public List<BotDeclaration> botDeclarations { get; set; }
        public List<SmeList> smeList { get; set; }
        public CddInformationVO cddInformationVO { get; set; }
    }

    public class ApplicationDetails
    {
        public string channelCode { get; set; }
        public string receivedDate { get; set; }
        public string mdsTeam { get; set; }
        public string applictionTypeCode { get; set; }
        public string applicatioCategoryCode { get; set; }
        public bool urgentCase { get; set; }
        public bool depositeGuaranteeCase { get; set; }
        public string branchRecomondedCode { get; set; }
        public string branchRecomondedComment { get; set; }
        public string branchCode { get; set; }
        public string staffEmployeeId { get; set; }
        public string pfCodeSegmentCode { get; set; }
        public string pfCodeNumber { get; set; }
        public string salesCode { get; set; }
        public string referralCode { get; set; }
        public string pfCodeBranchCode { get; set; }
        public string pfBranchName { get; set; }
        public bool bureauBypass { get; set; }
        public string specialHandlingCode { get; set; }
        public string specialHandlingComment { get; set; }
        public bool buApproved { get; set; }
        public string additionalCondition { get; set; }
        public string endorsementAuthorityCode { get; set; }
        public int creditLimit { get; set; }
        public bool isDocumentAvailable { get; set; }
    }

    public class BotDeclaration
    {
        public string declarationTypeCode { get; set; }
        public string financialInstitutionCode { get; set; }
        public int creditLine { get; set; }
    }

    public class BureauConsentVO
    {
        public bool creditModelConsent { get; set; }
        public string bureauConsentTypeCode { get; set; }
        public string ncbEtoken { get; set; }
        public string idNumber { get; set; }
    }

    public class BusinessActivity
    {
        public string businessActivityCode { get; set; }
    }

    public class CddInformationVO
    {
        public string countryofResidentCode { get; set; }
        public string sourceofAssetCode { get; set; }
        public string assetValueCode { get; set; }
        public string ROC1Code { get; set; }
        public string SourceofIncome1Code { get; set; }
        public string ROC2Code { get; set; }
        public string SourceofIncome2Code { get; set; }
        public string ROC3Code { get; set; }
        public string SourceofIncome3Code { get; set; }
    }

    public class CommunicationChannel
    {
        public string preferredCommunicationCode { get; set; }
    }

    public class Email
    {
        public bool isPreferredContact { get; set; }
        public string typeCode { get; set; }
        public string email { get; set; }
    }

    public class Employment
    {
        public string empTypeCode { get; set; }
        public string occupationCode { get; set; }
        public string otherOccupation { get; set; }
        public bool current { get; set; }
        public int yearsWithEmployer { get; set; }
        public int monthsWithEmployer { get; set; }
        public string employerName { get; set; }
        public string otherEmployerName { get; set; }
        public string businessRegistrationNumber { get; set; }
        public string companyIdTypeCode { get; set; }
        public string isicDVCode { get; set; }
        public string countryOfIncorporationCode { get; set; }
        public string natureOfBusinessCode { get; set; }
        public string natureOfBusinessOther { get; set; }
        public string employmentStatusCode { get; set; }
        public string employmentCharacteristicCode { get; set; }
        public string position { get; set; }
        public string userCode2Code { get; set; }
        public string businessTypeCode { get; set; }
        public int shareholdingPercentage { get; set; }
        public int netProfit { get; set; }
        public List<Income> incomes { get; set; }
    }

    public class Facility
    {
        public string facilityCategoryCode { get; set; }
        public string productTypeCode { get; set; }
        public int requestedLimit { get; set; }
        public string loanTenureCode { get; set; }
        public FacilityCreditCard facilityCreditCard { get; set; }
        public FacilityUnsecuredBusinessLoan facilityUnsecuredBusinessLoan { get; set; }
        public FacilityLimitIncrease facilityLimitIncrease { get; set; }
        public FacilityUPL facilityUPL { get; set; }
    }

    public class FacilityCreditCard
    {
        public string programCC { get; set; }
        public int requestedLimit { get; set; }
        public string primaryCardAccountNumber { get; set; }
        public string embossNameLine1 { get; set; }
        public string embossNameLine2 { get; set; }
        public bool priorityPass { get; set; }
        public string paymentMethodCode { get; set; }
        public string paymentTermCode { get; set; }
        public string debitFromAccount { get; set; }
        public string nameOfAccount { get; set; }
        public string eStatementCode { get; set; }
        public string cardDeliveryOptionCode { get; set; }
        public string creditCardToBeForwardToCC { get; set; }
        public string smsAlertCode { get; set; }
        public string smsMobileNumberCC { get; set; }
        public string typeOfGuaranteeCode { get; set; }
        public string accountNumber { get; set; }
        public int depositAmount { get; set; }
        public List<FacilitySupplCard> facilitySupplCard { get; set; }
    }

    public class FacilityLimitIncrease
    {
        public string accountNumber { get; set; }
        public int requestedLimit { get; set; }
        public string effectiveFrom { get; set; }
        public string effectiveTo { get; set; }
    }

    public class FacilitySupplCard
    {
        public string cardHolderName { get; set; }
        public string requestedLimitMethodCode { get; set; }
        public int limitOrAmount { get; set; }
        public string embossNameLine1 { get; set; }
        public string embossNameLine2 { get; set; }
        public string eStatementCode { get; set; }
        public string cardDeliveryOptionCode { get; set; }
        public string creditCardToBeForwardToCode { get; set; }
        public string smsAlertCode { get; set; }
        public string smsMobileNoSUP { get; set; }
        public bool priorityPass { get; set; }
    }

    public class FacilityUnsecuredBusinessLoan
    {
        public string productDetail { get; set; }
        public string tcgProjectCode { get; set; }
        public string paymentMethodCode { get; set; }
        public string paymentTermPercentageCode { get; set; }
        public string debitFromAccount { get; set; }
        public string loanTypeCode { get; set; }
        public string supplyChainGroupCode { get; set; }
        public string tlProductCode { get; set; }
        public string estatementCode { get; set; }
        public string smsAlertCode { get; set; }
        public string smsMobileNoSME { get; set; }
        public string accountNumberReceiving { get; set; }
        public string withdrawlCardNumber { get; set; }
        public string withdrawlCardExpiryDate { get; set; }
    }

    public class FacilityUPL
    {
        public string disburseCode { get; set; }
        public string accountNumber { get; set; }
        public string bankNameCode { get; set; }
        public string externalAccountNumber { get; set; }
        public string accountName { get; set; }
        public string walletId { get; set; }
        public string insuranceFlagCode { get; set; }
        public string eStatementCode { get; set; }
        public string cardDeliveryOptionCode { get; set; }
        public string creditCardToBeForwardToCode { get; set; }
        public string smsAlertCode { get; set; }
        public string smsMobileNumberUPL { get; set; }
        public string paymentMethodCode { get; set; }
        public string paymentTermCode { get; set; }
        public string debitFromAccountCode { get; set; }
        public int disburseAmount { get; set; }
        public string withdrawlCard { get; set; }
        public string withdrawalCardExpiryDate { get; set; }
        public string programCode { get; set; }
        public string isPayrollSixMonthFlagCode { get; set; }
        public string isSavingAccountLessThanSixMonthsCode { get; set; }
    }

    public class Identification
    {
        public string idTypeCode { get; set; }
        public string reference { get; set; }
        public string issueDate { get; set; }
        public string expiryDate { get; set; }
        public string placeIssued { get; set; }
    }

    public class Income
    {
        public string documentTypeCode { get; set; }
        public string typeCode { get; set; }
        public string frequencyCode { get; set; }
        public List<IncomeDetail> incomeDetails { get; set; }
    }

    public class IncomeDetail
    {
        public int year { get; set; }
        public int month { get; set; }
        public int grossIncome { get; set; }
        public int totalDebit { get; set; }
        public int totalCredit { get; set; }
    }

    public class PdpaConsentVO
    {
        public string pdpaConsentedCode { get; set; }
        public string pdpaAllCode { get; set; }
        public string pdpaNo1Code { get; set; }
        public string pdpaNo2Code { get; set; }
        public string pdpaNo3Code { get; set; }
        public string pdpaNo4Code { get; set; }
        public string pdpaNo5Code { get; set; }
        public string pdpaNo6Code { get; set; }
        public string pdpaNo7Code { get; set; }
        public string pdpaTemplate0Code { get; set; }
        public bool marketConductConsent { get; set; }
        public string marketConductVersionCode { get; set; }
    }

    public class Person
    {
        public string rmNumber { get; set; }
        public string applicationRoleCode { get; set; }
        public string prefixCode { get; set; }
        public string salutationOther { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string firstNameTH { get; set; }
        public string lastNameTH { get; set; }
        public string dateOfBirth { get; set; }
        public string nationalityCode { get; set; }
        public string nationality2Code { get; set; }
        public string nationality3Code { get; set; }
        public string genderCode { get; set; }
        public string educationLevelCode { get; set; }
        public int noOfDependents { get; set; }
        public string maritalStatusCode { get; set; }
        public List<Employment> employments { get; set; }
        public List<Identification> identification { get; set; }
        public List<AlternateIdentification> alternateIdentification { get; set; }
        public PersonFinancial personFinancial { get; set; }
    }

    public class PersonFinancial
    {
        public int declaredMonthlyExpenses { get; set; }
        public int declaredMonthlyInstallmentPayment { get; set; }
        public List<Income> incomes { get; set; }
    }

    public class Phone
    {
        public string phoneType { get; set; }
        public string countryCode { get; set; }
        public string phoneNumber { get; set; }
        public string ext { get; set; }
        public bool primaryPhone { get; set; }
    }

   
    public class SmeList
    {
        public string businessName { get; set; }
        public string businessTypeCode { get; set; }
        public string natureOfBusinessCode { get; set; }
        public string natureOfBusinessOther { get; set; }
        public string bblisicIdCode { get; set; }
        public string registrationTypeCode { get; set; }
        public int yearInBusiness { get; set; }
        public int yearOfExperienceInSimilarBusiness { get; set; }
        public string storeTypeCode { get; set; }
        public string onlineStoreName { get; set; }
        public string distributionChannelCode { get; set; }
        public string productServiceOfferedCode { get; set; }
        public string storeRepaymentStatusCode { get; set; }
        public int monthlyInstalmentPerMonth { get; set; }
        public int physicalStoreRentalFeePerMonth { get; set; }
        public int salesVolumePerMonth { get; set; }
        public int salesGeneratedChannelOnline { get; set; }
        public int salesGeneratedChannelOffline { get; set; }
        public int cashSales { get; set; }
        public int creditSales { get; set; }
        public int creditTermSalesDay { get; set; }
        public int cashPurchases { get; set; }
        public int creditPurchases { get; set; }
        public int creditTermPurchasesDay { get; set; }
        public int costOfGoodsSoldPerMonth { get; set; }
        public int sga { get; set; }
        public int estimatedStockValue { get; set; }
        public string hasEmployeeCode { get; set; }
        public int numberOfEmployee { get; set; }
        public int totalEmployeeSalary { get; set; }
        public string mainFinancialInstitutionCode { get; set; }
        public int averageBusinessCashFlow { get; set; }
        public int averageInboundDepositFlow { get; set; }
        public int averageDepositBalance { get; set; }
        public List<BusinessActivity> businessActivity { get; set; }
        public Address address { get; set; }
    }


}