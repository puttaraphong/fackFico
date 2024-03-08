using FaceProductAPI.Interface;
using FaceProductAPI.Models.ResponseProduct;
using FaceProductAPI.Models.ResponseProductDetail;

namespace FaceProductAPI.Data
{
    public class ProductDataMock : IProductDataMock
    {
        public Task<ResponseProduct> GetProductData()
        {
            return Task.FromResult(new ResponseProduct()
            {
                application = new Models.ResponseProduct.Application()
                {
                    requestDetail = new Models.ResponseProduct.RequestDetail()
                    {
                        callType = "GET_ELIGIBLE_PRODUCTS"
                    },
                    applicationDetails = new Models.ResponseProduct.ApplicationDetails()
                    {
                        channel = "MB",
                        leadRefNumber = "CSLO_MB_231214_c0b99d5e-7cd1-42b7-8b2f-ab0c403b66a5"
                    },
                    applicants = new List<Models.ResponseProduct.Applicants>()
                    {
                        new Models.ResponseProduct.Applicants() {
                            person = new Models.ResponseProduct.Person()
                            {
                                dateOfBirth="2000-01-01",
                                idType="CI",
                                issueDate= "2000-01-01",
                                nationality= "TH",
                                bblIalCode= "21",
                                allocationCode= "R",
                                preScreenedOrLead= false,
                                idIssueDate= "2000-01-01"

                            },
                            customerKYCDetail = new Models.ResponseProduct.CustomerKYCDetail()
                            {
                                kycStatus= "C",
                                riskLevel= ""
                            }
                        }
                    },
                    suggestedProducts = new List<Models.ResponseProduct.SuggestedProducts>()
                    {
                        new Models.ResponseProduct.SuggestedProducts() {
                            facilityCategory = "CC",
                            productNameTH = "บัตรเครดิตผู้นำแพลทินัม",
                            productNameEN = "Platinum Leader Card",
                            productShortNameTH = "",
                            productShortNameEN = "",
                            productCode= "CC03",
                            productDesc = "บัตรเครดิต",
                            saleSheet = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            productCatalog = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            compareTableLink = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            preApprovedFlag = "false",
                            categories = new List<Models.ResponseProduct.Categories>()
                            {
                                new Models.ResponseProduct.Categories()
                                {
                                        category = "ทั้งหมด"
                                },
                                new Models.ResponseProduct.Categories()
                                {
                                        category = "สิทธิพิเศษ"
                                },
                                new Models.ResponseProduct.Categories()
                                {
                                        category = "ไลฟ์สไตล์"
                                }
                            },
                            benefits = new List<Models.ResponseProduct.Benefits>()
                            {
                                new Models.ResponseProduct.Benefits()
                                {
                                    benefitCodebenefit="ทุก 25 บาทรับคะแนนสะสม 2 คะแนน เพื่อนำมาแลกรับของกำนัลหรือไมล์เดินทางจากสายการบินชั้นนำ"
                                },
                                new Models.ResponseProduct.Benefits()
                                {
                                    benefitCodebenefit="แผนคุ้มครองการรักษาพยาบาลขณะเดินทางในต่างประเทศ วงเงินคุ้มครองสูงสุด 2,000,000 บาทต่อเที่ยว"
                                },
                                new Models.ResponseProduct.Benefits()
                                {
                                    benefitCodebenefit="แผนพิทักษ์สินค้าที่ซื้อ วงเงินคุ้มครองสูงสุด 400,000 บาทต่อปี"
                                },
                                new Models.ResponseProduct.Benefits()
                                {
                                    benefitCodebenefit="แผนประกันอุบัติเหตุการเดินทาง วงเงินคุ้มครองสูงสุด 500,000 เหรียญสหรัฐ"
                                },
                                new Models.ResponseProduct.Benefits()
                                {
                                    benefitCodebenefit="บริการผู้ช่วยส่วนบุคคลตลอด 24 ชั่วโมง"
                                }
                            },
                            uwCriterias = new List<Models.ResponseProduct.UWCriterias>()
                            {
                                new Models.ResponseProduct.UWCriterias()
                                {
                                    entityType= "P",
                                    uwAuthorityLevel= "1",
                                    appealAllowed= false,
                                    reasonCode= "RR33",
                                    reasonDesc= "Refer : Gray App Score",
                                    decision= "REFER",
                                    partyId= "1",
                                    reasonPriority= ""
                                }
                            }
                        },
                        new Models.ResponseProduct.SuggestedProducts() {
                            facilityCategory = "CC",
                            productNameTH = "บัตรเครดิตแพลทินัม โรงพยาบาลบำรุงราษฎร์",
                            productNameEN = "Platinum Bumrungrad Hospital Credit Card",
                            productShortNameTH = "",
                            productShortNameEN = "",
                            productCode= "CC04",
                            productDesc = "บัตรเครดิต",
                            saleSheet = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            productCatalog = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            compareTableLink = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            preApprovedFlag = "false",
                            categories = new List<Models.ResponseProduct.Categories>()
                            {
                                new Models.ResponseProduct.Categories()
                                {
                                        category = "ทั้งหมด"
                                },
                                new Models.ResponseProduct.Categories()
                                {
                                        category= "สิทธิพิเศษ"
                                },
                                new Models.ResponseProduct.Categories()
                                {
                                        category= "สุขภาพ"
                                }
                            },
                            benefits = new List<Models.ResponseProduct.Benefits>()
                            {
                                new Models.ResponseProduct.Benefits()
                                {
                                    benefitCodebenefit="รับส่วนลดสูงสุด 30% ที่โรงพยาบาลบำรุงราษฎร์ พร้อมรับบัตรกำนัลตรวจสุขภาพสำหรับบัตรหลัก มูลค่า 8,300 บาท และบัตรกำนัลส่วนลดตรวจสุขภาพสำหรับบัตรเสริม มูลค่า 3,000 บาท*"
                                },
                                new Models.ResponseProduct.Benefits()
                                {
                                    benefitCodebenefit="บริการผู้ช่วยส่วนบุคคล 24 ชั่วโมง"
                                },
                                new Models.ResponseProduct.Benefits()
                                {
                                    benefitCodebenefit="*ผู้สมัครต้องสมัครเป็นสมาชิกโรงพยาบาลบำรุงราษฎร์พร้อมกันกับการสมัครบัตรเครดิตนี้"
                                }
                            },
                            uwCriterias = new List<Models.ResponseProduct.UWCriterias>()
                            {
                                new Models.ResponseProduct.UWCriterias()
                                {
                                    entityType= "P",
                                    uwAuthorityLevel= "1",
                                    appealAllowed= false,
                                    reasonCode= "RR33",
                                    reasonDesc= "Refer : Gray App Score",
                                    decision= "REFER",
                                    partyId= "1",
                                    reasonPriority= ""
                                }
                            }

                        },
                        new Models.ResponseProduct.SuggestedProducts() {
                            facilityCategory = "CC",
                            productNameTH = "บัตรเครดิตวีซ่าแพลทินัม",
                            productNameEN = "Visa Platinum Credit Card",
                            productShortNameTH = "",
                            productShortNameEN = "",
                            productCode= "CC05",
                            productDesc = "บัตรเครดิต",
                            saleSheet = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            productCatalog = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            compareTableLink = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            preApprovedFlag = "false",
                            categories = new List<Models.ResponseProduct.Categories>()
                            {
                                new Models.ResponseProduct.Categories()
                                {
                                        category = "ทั้งหมด"
                                },
                                new Models.ResponseProduct.Categories()
                                {
                                        category = "ไลฟ์สไตล์"
                                }
                            },
                            benefits = new List<Models.ResponseProduct.Benefits>()
                            {
                                new Models.ResponseProduct.Benefits()
                                {
                                    benefitCodebenefit="ทุก 25 บาท รับคะแนนสะสม 1 คะแนน เพื่อนำมาแลกรับของกำนัลหรือไมล์เดินทางจากสายการบินชั้นนำ"
                                },
                                new Models.ResponseProduct.Benefits()
                                {
                                    benefitCodebenefit="แผนประกันอุบัติเหตุการเดินทาง วงเงินคุ้มครอง สูงสุด 200,000 เหรียญสหรัฐ"
                                },
                                new Models.ResponseProduct.Benefits()
                                {
                                    benefitCodebenefit="บริการผู้ช่วยส่วนบุคคลตลอด 24 ชั่วโมง"
                                }
                            },
                            uwCriterias = new List<Models.ResponseProduct.UWCriterias>()
                            {
                                new Models.ResponseProduct.UWCriterias()
                                {
                                    entityType= "P",
                                    uwAuthorityLevel= "1",
                                    appealAllowed= false,
                                    reasonCode= "RR33",
                                    reasonDesc= "Refer : Gray App Score",
                                    decision= "REFER",
                                    partyId= "1",
                                    reasonPriority= ""
                                }
                            }

                        },
                    },
                    rulesAudit = new List<Models.ResponseProduct.RulesAudit>()
                    {
                        new Models.ResponseProduct.RulesAudit()
                        {
                            metaphorName= "",
                            rule= "",
                            timeStamp= ""
                        }
                    }
                }
            });
        }

        public Task<ResponseProductDetail> GetProductDataDetails()
        {
            return Task.FromResult(new ResponseProductDetail()
            {
                application = new Models.ResponseProductDetail.Application()
                {
                    requestDetail = new Models.ResponseProductDetail.RequestDetail()
                    {
                        callType = "GET_ELIGIBLE_PRODUCTS"
                    },
                    applicationDetails = new Models.ResponseProductDetail.ApplicationDetails()
                    {
                        channel = "MB",
                        leadRefNumber = "CSLO_MB_231214_c0b99d5e-7cd1-42b7-8b2f-ab0c403b66a5"
                    },
                    applicants = new List<Models.ResponseProductDetail.Applicants>()
                    {
                        new Models.ResponseProductDetail.Applicants() {
                            person = new Models.ResponseProductDetail.Person()
                            {
                                dateOfBirth= DateTime.Now.AddYears(-40).ToString("yyyy-MM-dd"),
                                idType="CI",
                                nationality= "TH",
                                bblIalCode= "21",
                                allocationCode= "R",
                                preScreenedOrLead= false,
                                idIssueDate= DateTime.Now.AddYears(-30).ToString("yyyy-MM-dd")

                            },
                            customerKYCDetail = new Models.ResponseProductDetail.CustomerKYCDetail()
                            {
                                kycStatus= "C",
                                riskLevel= ""
                            }
                        }
                    },
                    suggestedProducts = new List<Models.ResponseProductDetail.SuggestedProducts>()
                    {
                        new Models.ResponseProductDetail.SuggestedProducts() {
                            facilityCategory = "CC",
                            productNameTH = "บัตรเครดิตผู้นำแพลทินัม",
                            productNameEN = "Platinum Leader Card",
                            productShortNameTH = "",
                            productShortNameEN = "",
                            productCode= "CC03",
                            productDesc = "บัตรเครดิต",
                            saleSheet = "https://www-u.bangkokbank.com/-/media/files/personal/cards/creditcard/Document%20Download/CreditCard_SalesSheet.pdf",
                            productCatalog = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            compareTableLink = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            preApprovedFlag = "false",
                            firstEffectiveDate= DateTime.Now.AddYears(-30).ToString("yyyy-MM-dd"),
                            lastEffectiveDate= DateTime.Now.AddDays(2).ToString("yyyy-MM-dd"),
                            ddrRequired= "",
                            minDDRRepaymentPercentage= 0,
                            minDDRRepayment= 0,
                            minAllowAge= 20,
                            maxAllowAge= 60,
                            minimumSalary= 15000,
                            minRequestLoan= 0,
                            maxRequestLoan= 0,
                            systemRecommendedMaxLoan= 0,
                            additionalFee=new  List<Models.ResponseProductDetail.AdditionalFee>()
                            {
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="PrimaryCardAdditionalFee",
                                    feeUnit= "baht",
                                    feeValue= 4000
                                },
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="SupplementaryCardAdditionalFee",
                                    feeUnit= "baht",
                                    feeValue= 2000
                                },
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="EntranceFee",
                                    feeUnit= "baht",
                                    feeValue= 0
                                }
                            },
                            repaymentPeriod =new List<RepaymentPeriod>()
                            {
                                new Models.ResponseProductDetail.RepaymentPeriod()
                                {
                                    tentativeApprovedAmount= 0,
                                    tentativeLoanPeriod= 0,
                                    tentativeMI= 0,
                                    tentativeTotalRepayment= 0
                                }
                            },
                            interestRates =new List<InterestRates>()
                            {
                                new Models.ResponseProductDetail.InterestRates()
                                {
                                    segment="",
                                    rateType= "",
                                    minAmount= 0,
                                    maxAmount=0,
                                    calculatedRate= 0,
                                    minRate= 0,
                                    maxRate= 0
                                }
                            },
                            multiplierRequestedLoans =new List<MultiplierRequestedLoans>()
                            {
                                new Models.ResponseProductDetail.MultiplierRequestedLoans()
                                {
                                    minIncome= 0,
                                    maxIncome= 0,
                                    multiplier= 0,
                                 //   listCategory= ""
                                }
                            },
                            categories = new List<Models.ResponseProductDetail.Categories>()
                            {
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category = "ทั้งหมด"
                                },
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category = "สิทธิพิเศษ"
                                },
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category = "ไลฟ์สไตล์"
                                }
                            },
                            benefits = new List<Models.ResponseProductDetail.Benefits>()
                            {
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode="ทุก 25 บาทรับคะแนนสะสม 2 คะแนน เพื่อนำมาแลกรับของกำนัลหรือไมล์เดินทางจากสายการบินชั้นนำ"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode="แผนคุ้มครองการรักษาพยาบาลขณะเดินทางในต่างประเทศ วงเงินคุ้มครองสูงสุด 2,000,000 บาทต่อเที่ยว"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode="แผนพิทักษ์สินค้าที่ซื้อ วงเงินคุ้มครองสูงสุด 400,000 บาทต่อปี"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode="แผนประกันอุบัติเหตุการเดินทาง วงเงินคุ้มครองสูงสุด 500,000 เหรียญสหรัฐ"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode="บริการผู้ช่วยส่วนบุคคลตลอด 24 ชั่วโมง"
                                }
                            },
                        },
                        new Models.ResponseProductDetail.SuggestedProducts() {
                            facilityCategory = "CC",
                            productNameTH = "บัตรเครดิตแพลทินัม โรงพยาบาลบำรุงราษฎร์",
                            productNameEN = "Platinum Bumrungrad Hospital Credit Card",
                            productShortNameTH = "",
                            productShortNameEN = "",
                            productCode= "CC04",
                            productDesc = "บัตรเครดิต",
                            saleSheet = "https://www-u.bangkokbank.com/-/media/files/personal/cards/creditcard/Document%20Download/CreditCard_SalesSheet.pdf",
                            productCatalog = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            compareTableLink = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            preApprovedFlag = "false",
                            firstEffectiveDate= DateTime.Now.AddYears(-40).ToString("yyyy-MM-dd"),
                            lastEffectiveDate= DateTime.Now.AddYears(40).ToString("yyyy-MM-dd"),
                            ddrRequired= "",
                            minDDRRepaymentPercentage= 0,
                            minDDRRepayment= 0,
                            minAllowAge= 20,
                            maxAllowAge= 60,
                            minimumSalary= 100000,
                            minRequestLoan= 0,
                            maxRequestLoan= 0,
                            systemRecommendedMaxLoan= 0,
                            additionalFee=new  List<Models.ResponseProductDetail.AdditionalFee>()
                            {
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="PrimaryCardAdditionalFee",
                                    feeUnit= "baht",
                                    feeValue= 4000
                                },
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="SupplementaryCardAdditionalFee",
                                    feeUnit= "baht",
                                    feeValue= 2000
                                },
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="EntranceFee",
                                    feeUnit= "baht",
                                    feeValue= 0
                                }
                            },
                            repaymentPeriod =new List<RepaymentPeriod>()
                            {
                                new Models.ResponseProductDetail.RepaymentPeriod()
                                {
                                    tentativeApprovedAmount= 0,
                                    tentativeLoanPeriod= 0,
                                    tentativeMI= 0,
                                    tentativeTotalRepayment= 0
                                }
                            },
                            interestRates =new List<InterestRates>()
                            {
                                new Models.ResponseProductDetail.InterestRates()
                                {
                                    segment="",
                                    rateType= "",
                                    minAmount= 0,
                                    maxAmount=0,
                                    calculatedRate= 0,
                                    minRate= 0,
                                    maxRate= 0
                                }
                            },
                            multiplierRequestedLoans =new List<MultiplierRequestedLoans>()
                            {
                                new Models.ResponseProductDetail.MultiplierRequestedLoans()
                                {
                                    minIncome= 0,
                                    maxIncome= 0,
                                    multiplier= 0,
                                  //  listCategory= ""
                                }
                            },
                            categories = new List<Models.ResponseProductDetail.Categories>()
                            {
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category = "ทั้งหมด"
                                },
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category = "สิทธิพิเศษ"
                                },
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category = "สุขภาพ"
                                }
                            },
                            benefits = new List<Models.ResponseProductDetail.Benefits>()
                            {
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode="รับส่วนลดสูงสุด 30% ที่โรงพยาบาลบำรุงราษฎร์ พร้อมรับบัตรกำนัลตรวจสุขภาพสำหรับบัตรหลัก มูลค่า 8,300 บาท และบัตรกำนัลส่วนลดตรวจสุขภาพสำหรับบัตรเสริม มูลค่า 3,000 บาท*"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode="บริการผู้ช่วยส่วนบุคคล 24 ชั่วโมง"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode="*ผู้สมัครต้องสมัครเป็นสมาชิกโรงพยาบาลบำรุงราษฎร์พร้อมกันกับการสมัครบัตรเครดิตนี้"
                                }
                            },
                            decision = new Decision()
                            {


                                            isAutoReject= false,
                               overrideFlag= false,
                                 recommendedCreditDecision="",
                                 finalReasonCode= "",
                               finalAuthorityLevel= "",
                                 uwEmpowermentLevel= "",
                                 uwCriteria = new List<Models.ResponseProductDetail.UWCriterias>()
                                 {
                                      new Models.ResponseProductDetail.UWCriterias()
                                      {
                                           entityType= "P",
                            uwAuthorityLevel= "1",
                            appealAllowed= false,
                            reasonCode= "RR33",
                            reasonDesc= "Refer : Gray App Score",
                            decision= "REFER",
                            partyID= "1",
                            reasonPriority= ""
                                      }

                                 }
                            }

                        },
                        new Models.ResponseProductDetail.SuggestedProducts() {
                            facilityCategory = "CC",
                            productNameTH = "บัตรเครดิตวีซ่าแพลทินัม",
                            productNameEN = "Visa Platinum Credit Card",
                            productShortNameTH = "",
                            productShortNameEN = "",
                            productCode= "CC05",
                            productDesc = "บัตรเครดิต",
                            saleSheet = "https://www-u.bangkokbank.com/-/media/files/personal/cards/creditcard/Document%20Download/CreditCard_SalesSheet.pdf",
                            productCatalog = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            compareTableLink = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            preApprovedFlag = "false",
                            firstEffectiveDate= DateTime.Now.AddYears(-40).ToString("yyyy-MM-dd"),
                            lastEffectiveDate= DateTime.Now.AddYears(4).ToString("yyyy-MM-dd"),
                            ddrRequired= "",
                            minDDRRepaymentPercentage= 0,
                            minDDRRepayment= 0,
                            minAllowAge= 20,
                            maxAllowAge= 60,
                            minimumSalary= 15000,
                            minRequestLoan= 0,
                            maxRequestLoan= 0,
                            systemRecommendedMaxLoan= 0,
                            additionalFee=new  List<Models.ResponseProductDetail.AdditionalFee>()
                            {
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="PrimaryCardAdditionalFee",
                                    feeUnit= "baht",
                                    feeValue= 3000
                                },
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="SupplementaryCardAdditionalFee",
                                    feeUnit= "baht",
                                    feeValue= 3000
                                },
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="EntranceFee",
                                    feeUnit= "baht",
                                    feeValue= 0
                                }
                            },
                            repaymentPeriod =new List<RepaymentPeriod>()
                            {
                                new Models.ResponseProductDetail.RepaymentPeriod()
                                {
                                    tentativeApprovedAmount= 0,
                                    tentativeLoanPeriod= 0,
                                    tentativeMI= 0,
                                    tentativeTotalRepayment= 0
                                }
                            },
                            interestRates =new List<InterestRates>()
                            {
                                new Models.ResponseProductDetail.InterestRates()
                                {
                                    segment="",
                                    rateType= "",
                                    minAmount= 0,
                                    maxAmount=0,
                                    calculatedRate= 0,
                                    minRate= 0,
                                    maxRate= 0
                                }
                            },
                            multiplierRequestedLoans =new List<MultiplierRequestedLoans>()
                            {
                                new Models.ResponseProductDetail.MultiplierRequestedLoans()
                                {
                                    minIncome= 0,
                                    maxIncome= 0,
                                    multiplier= 0,
                                  // listCategory= ""
                                }
                            },
                            categories = new List<Models.ResponseProductDetail.Categories>()
                            {
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category = "ทั้งหมด"
                                },
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category= "ไลฟ์สไตล์"
                                }
                            },
                            benefits = new List<Models.ResponseProductDetail.Benefits>()
                            {
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode="ทุก 25 บาท รับคะแนนสะสม 1 คะแนน เพื่อนำมาแลกรับของกำนัลหรือไมล์เดินทางจากสายการบินชั้นนำ"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode="แผนประกันอุบัติเหตุการเดินทาง วงเงินคุ้มครอง สูงสุด 200,000 เหรียญสหรัฐ"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode="บริการผู้ช่วยส่วนบุคคลตลอด 24 ชั่วโมง"
                                }
                            },
                            //decision = new Models.ResponseProductDetail.Decision()
                            //{
                            //     isAutoReject= false,
                            //     overrideFlag= false,
                            //     recommendedCreditDecision="",
                            //     finalReasonCode= "",
                            //     finalAuthorityLevel= "",
                            //     uwEmpowermentLevel= ""
                            //},
                            //uwCriterias = new List<Models.ResponseProductDetail.UWCriterias>()
                            //{
                            //    new Models.ResponseProductDetail.UWCriterias()
                            //    {
                            //        entityType= "P",
                            //        uwAuthorityLevel= "1",
                            //        appealAllowed= false,
                            //        reasonCode= "RR33",
                            //        reasonDesc= "Refer : Gray App Score",
                            //        decision= "REFER",
                            //        partyID= "1",
                            //        reasonPriority= ""
                            //    }
                            //}

                        },
                        new Models.ResponseProductDetail.SuggestedProducts() {
                            facilityCategory = "CC",
                            productNameTH = "บัตรเครดิตไทเทเนียม",
                            productNameEN = "Titanium Credit Card",
                            productShortNameTH = "",
                            productShortNameEN = "",
                            productCode= "CC07",
                            productDesc = "บัตรเครดิต",
                            saleSheet = "https://www-u.bangkokbank.com/-/media/files/personal/cards/creditcard/Document%20Download/CreditCard_SalesSheet.pdf",
                            productCatalog = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            compareTableLink = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            preApprovedFlag = "false",
                            firstEffectiveDate= DateTime.Now.AddYears(-40).ToString("yyyy-MM-dd"),
                            lastEffectiveDate= DateTime.Now.AddMonths(6).ToString("yyyy-MM-dd"),
                            ddrRequired= "",
                            minDDRRepaymentPercentage= 0,
                            minDDRRepayment= 0,
                            minAllowAge= 20,
                            maxAllowAge= 60,
                            minimumSalary= 15000,
                            minRequestLoan= 0,
                            maxRequestLoan= 0,
                            systemRecommendedMaxLoan= 0,
                            additionalFee=new  List<Models.ResponseProductDetail.AdditionalFee>()
                            {
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="PrimaryCardAdditionalFee",
                                    feeUnit= "baht",
                                    feeValue= 0
                                },
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="SupplementaryCardAdditionalFee",
                                    feeUnit= "baht",
                                    feeValue= 0
                                },
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="EntranceFee",
                                    feeUnit= "baht",
                                    feeValue= 0
                                }
                            },
                            repaymentPeriod =new List<RepaymentPeriod>()
                            {
                                new Models.ResponseProductDetail.RepaymentPeriod()
                                {
                                    tentativeApprovedAmount= 0,
                                    tentativeLoanPeriod= 0,
                                    tentativeMI= 0,
                                    tentativeTotalRepayment= 0
                                }
                            },
                            interestRates =new List<InterestRates>()
                            {
                                new Models.ResponseProductDetail.InterestRates()
                                {
                                    segment="",
                                    rateType= "",
                                    minAmount= 0,
                                    maxAmount=0,
                                    calculatedRate= 0,
                                    minRate= 0,
                                    maxRate= 0
                                }
                            },
                            multiplierRequestedLoans =new List<MultiplierRequestedLoans>()
                            {
                                new Models.ResponseProductDetail.MultiplierRequestedLoans()
                                {
                                    minIncome= 0,
                                    maxIncome= 0,
                                    multiplier= 0,
                                   // listCategory= ""
                                }
                            },
                            categories = new List<Models.ResponseProductDetail.Categories>()
                            {
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category = "ทั้งหมด"
                                },
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category= "ไลฟ์สไตล์"
                                }
                            },
                            benefits = new List<Models.ResponseProductDetail.Benefits>()
                            {
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "รับเงินคืนสูงสุด 2% จากยอดรวมค่าใช้จ่ายผ่านบัตร สูงสุดไม่เกิน 2,000 บาท/รอบบัญชี"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "แผนประกันอุบัติเหตุการเดินทาง วงเงินคุ้มครองสูงสุด 3,000,000 บาท"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "บริการผู้ช่วยส่วนบุคคล 24 ชั่วโมง"
                                }
                            },
                            //decision = new Models.ResponseProductDetail.Decision()
                            //{
                            //     isAutoReject= false,
                            //     overrideFlag= false,
                            //     recommendedCreditDecision="",
                            //     finalReasonCode= "",
                            //     finalAuthorityLevel= "",
                            //     uwEmpowermentLevel= ""
                            //},
                            //uwCriterias = new List<Models.ResponseProductDetail.UWCriterias>()
                            //{
                            //    new Models.ResponseProductDetail.UWCriterias()
                            //    {
                            //        entityType= "P",
                            //        uwAuthorityLevel= "1",
                            //        appealAllowed= false,
                            //        reasonCode= "RR33",
                            //        reasonDesc= "Refer : Gray App Score",
                            //        decision= "REFER",
                            //        partyID= "1",
                            //        reasonPriority= ""
                            //    }
                            //}

                        },
                        new Models.ResponseProductDetail.SuggestedProducts() {
                            facilityCategory = "CC",
                            productNameTH = "บัตรเครดิตไทเทเนียม โรงพยาบาลรามาธิบดี",
                            productNameEN = "Titanium Piyavate Hospital Credit Card",
                            productShortNameTH = "",
                            productShortNameEN = "",
                            productCode= "CC13",
                            productDesc = "บัตรเครดิต",
                            saleSheet = "https://www-u.bangkokbank.com/-/media/files/personal/cards/creditcard/Document%20Download/CreditCard_SalesSheet.pdf",
                            productCatalog = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            compareTableLink = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            preApprovedFlag = "false",
                            firstEffectiveDate= DateTime.Now.AddYears(-40).ToString("yyyy-MM-dd"),
                            lastEffectiveDate= DateTime.Now.AddMonths(6).ToString("yyyy-MM-dd"),
                            ddrRequired= "",
                            minDDRRepaymentPercentage= 0,
                            minDDRRepayment= 0,
                            minAllowAge= 20,
                            maxAllowAge= 60,
                            minimumSalary= 15000,
                            minRequestLoan= 0,
                            maxRequestLoan= 0,
                            systemRecommendedMaxLoan= 0,
                            additionalFee=new  List<Models.ResponseProductDetail.AdditionalFee>()
                            {
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="PrimaryCardAdditionalFee",
                                    feeUnit= "baht",
                                    feeValue= 0
                                },
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="SupplementaryCardAdditionalFee",
                                    feeUnit= "baht",
                                    feeValue= 0
                                },
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="EntranceFee",
                                    feeUnit= "baht",
                                    feeValue= 0
                                }
                            },
                            repaymentPeriod =new List<RepaymentPeriod>()
                            {
                                new Models.ResponseProductDetail.RepaymentPeriod()
                                {
                                    tentativeApprovedAmount= 0,
                                    tentativeLoanPeriod= 0,
                                    tentativeMI= 0,
                                    tentativeTotalRepayment= 0
                                }
                            },
                            interestRates =new List<InterestRates>()
                            {
                                new Models.ResponseProductDetail.InterestRates()
                                {
                                    segment="",
                                    rateType= "",
                                    minAmount= 0,
                                    maxAmount=0,
                                    calculatedRate= 0,
                                    minRate= 0,
                                    maxRate= 0
                                }
                            },
                            multiplierRequestedLoans =new List<MultiplierRequestedLoans>()
                            {
                                new Models.ResponseProductDetail.MultiplierRequestedLoans()
                                {
                                    minIncome= 0,
                                    maxIncome= 0,
                                    multiplier= 0,
                                  //  listCategory= ""
                                }
                            },
                            categories = new List<Models.ResponseProductDetail.Categories>()
                            {
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category = "ทั้งหมด"
                                },
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category= "สุขภาพ"
                                }
                            },
                            benefits = new List<Models.ResponseProductDetail.Benefits>()
                            {
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "รับเงินคืนสูงสุด 2% จากยอดรวมค่าใช้จ่ายผ่านบัตร สูงสุดไม่เกิน 2,000 บาท/รอบบัญชี"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "ธนาคารกรุงเทพร่วมบริจาค 0.2% จากทุกยอดใช้จ่ายผ่านบัตรให้แก่คณะแพทยศาสตร์ โรงพยาบาลรามาธิบดี"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "แผนประกันอุบัติเหตุการเดินทาง วงเงินคุ้มครองสูงสุด 3,000,000 บาท"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "บริการผู้ช่วยส่วนบุคคล 24 ชั่วโมง"
                                }
                            },
                            //decision = new Models.ResponseProductDetail.Decision()
                            //{
                            //     isAutoReject= false,
                            //     overrideFlag= false,
                            //     recommendedCreditDecision="",
                            //     finalReasonCode= "",
                            //     finalAuthorityLevel= "",
                            //     uwEmpowermentLevel= ""
                            //},
                            //uwCriterias = new List<Models.ResponseProductDetail.UWCriterias>()
                            //{
                            //    new Models.ResponseProductDetail.UWCriterias()
                            //    {
                            //        entityType= "P",
                            //        uwAuthorityLevel= "1",
                            //        appealAllowed= false,
                            //        reasonCode= "RR33",
                            //        reasonDesc= "Refer : Gray App Score",
                            //        decision= "REFER",
                            //        partyID= "1",
                            //        reasonPriority= ""
                            //    }
                            //}

                        },
                        new Models.ResponseProductDetail.SuggestedProducts() {
                            facilityCategory = "CC",
                            productNameTH = "บัตรเครดิตไทเทเนียม โรงพยาบาลปิยะเวท ธนาคารกรุงเทพ",
                            productNameEN = "Titanium Piyavate Hospital Credit Card",
                            productShortNameTH = "",
                            productShortNameEN = "",
                            productCode= "CC14",
                            productDesc = "บัตรเครดิต",
                            saleSheet = "https://www-u.bangkokbank.com/-/media/files/personal/cards/creditcard/Document%20Download/CreditCard_SalesSheet.pdf",
                            productCatalog = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            compareTableLink = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            preApprovedFlag = "false",
                           firstEffectiveDate= DateTime.Now.AddYears(-40).ToString("yyyy-MM-dd"),
                            lastEffectiveDate= DateTime.Now.AddMonths(6).ToString("yyyy-MM-dd"),
                            ddrRequired= "",
                            minDDRRepaymentPercentage= 0,
                            minDDRRepayment= 0,
                            minAllowAge= 20,
                            maxAllowAge= 60,
                            minimumSalary= 15000,
                            minRequestLoan= 0,
                            maxRequestLoan= 0,
                            systemRecommendedMaxLoan= 0,
                            additionalFee=new  List<Models.ResponseProductDetail.AdditionalFee>()
                            {
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="PrimaryCardAdditionalFee",
                                    feeUnit= "baht",
                                    feeValue= 0
                                },
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="SupplementaryCardAdditionalFee",
                                    feeUnit= "baht",
                                    feeValue= 0
                                },
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="EntranceFee",
                                    feeUnit= "baht",
                                    feeValue= 0
                                }
                            },
                            repaymentPeriod =new List<RepaymentPeriod>()
                            {
                                new Models.ResponseProductDetail.RepaymentPeriod()
                                {
                                    tentativeApprovedAmount= 0,
                                    tentativeLoanPeriod= 0,
                                    tentativeMI= 0,
                                    tentativeTotalRepayment= 0
                                }
                            },
                            interestRates =new List<InterestRates>()
                            {
                                new Models.ResponseProductDetail.InterestRates()
                                {
                                    segment="",
                                    rateType= "",
                                    minAmount= 0,
                                    maxAmount=0,
                                    calculatedRate= 0,
                                    minRate= 0,
                                    maxRate= 0
                                }
                            },
                            multiplierRequestedLoans =new List<MultiplierRequestedLoans>()
                            {
                                new Models.ResponseProductDetail.MultiplierRequestedLoans()
                                {
                                    minIncome= 0,
                                    maxIncome= 0,
                                    multiplier= 0,
                                   // listCategory= ""
                                }
                            },
                            categories = new List<Models.ResponseProductDetail.Categories>()
                            {
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category = "ทั้งหมด"
                                },
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category= "สุขภาพ"
                                }
                            },
                            benefits = new List<Models.ResponseProductDetail.Benefits>()
                            {
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "รับเงินคืนสูงสุด 2% จากยอดรวมค่าใช้จ่ายผ่านบัตร สูงสุดไม่เกิน 2,000 บาท/รอบบัญชี"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "แผนประกันอุบัติเหตุการเดินทาง วงเงินคุ้มครองสูงสุด 3,000,000 บาท"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "บริการผู้ช่วยส่วนบุคคล 24 ชั่วโมง"
                                }
                            },
                            //decision = new Models.ResponseProductDetail.Decision()
                            //{
                            //     isAutoReject= false,
                            //     overrideFlag= false,
                            //     recommendedCreditDecision="",
                            //     finalReasonCode= "",
                            //     finalAuthorityLevel= "",
                            //     uwEmpowermentLevel= ""
                            //},
                            //uwCriterias = new List<Models.ResponseProductDetail.UWCriterias>()
                            //{
                            //    new Models.ResponseProductDetail.UWCriterias()
                            //    {
                            //        entityType= "P",
                            //        uwAuthorityLevel= "1",
                            //        appealAllowed= false,
                            //        reasonCode= "RR33",
                            //        reasonDesc= "Refer : Gray App Score",
                            //        decision= "REFER",
                            //        partyID= "1",
                            //        reasonPriority= ""
                            //    }
                            //}

                        },
                        new Models.ResponseProductDetail.SuggestedProducts() {
                            facilityCategory = "CC",
                            productNameTH = "บัตรเครดิตอเมริกัน เอ็กซ์เพรส",
                            productNameEN = "Bangkok Bank M Luxe Visa Signature Credit Card",
                            productShortNameTH = "",
                            productShortNameEN = "",
                            productCode= "CC27",
                            productDesc = "บัตรเครดิต",
                            saleSheet = "https://www-u.bangkokbank.com/-/media/files/personal/cards/creditcard/Document%20Download/CreditCard_SalesSheet.pdf",
                            productCatalog = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            compareTableLink = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            preApprovedFlag = "false",
                           firstEffectiveDate= DateTime.Now.AddYears(-40).ToString("yyyy-MM-dd"),
                            lastEffectiveDate= DateTime.Now.AddMonths(6).ToString("yyyy-MM-dd"),
                            ddrRequired= "",
                            minDDRRepaymentPercentage= 0,
                            minDDRRepayment= 0,
                            minAllowAge= 20,
                            maxAllowAge= 60,
                            minimumSalary= 100000,
                            minRequestLoan= 0,
                            maxRequestLoan= 0,
                            systemRecommendedMaxLoan= 0,
                            additionalFee=new  List<Models.ResponseProductDetail.AdditionalFee>()
                            {
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="PrimaryCardAdditionalFee",
                                    feeUnit= "baht",
                                    feeValue= 4000
                                },
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="SupplementaryCardAdditionalFee",
                                    feeUnit= "baht",
                                    feeValue= 0
                                },
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="EntranceFee",
                                    feeUnit= "baht",
                                    feeValue= 0
                                }
                            },
                            repaymentPeriod =new List<RepaymentPeriod>()
                            {
                                new Models.ResponseProductDetail.RepaymentPeriod()
                                {
                                    tentativeApprovedAmount= 0,
                                    tentativeLoanPeriod= 0,
                                    tentativeMI= 0,
                                    tentativeTotalRepayment= 0
                                }
                            },
                            interestRates =new List<InterestRates>()
                            {
                                new Models.ResponseProductDetail.InterestRates()
                                {
                                    segment="",
                                    rateType= "",
                                    minAmount= 0,
                                    maxAmount=0,
                                    calculatedRate= 0,
                                    minRate= 0,
                                    maxRate= 0
                                }
                            },
                            multiplierRequestedLoans =new List<MultiplierRequestedLoans>()
                            {
                                new Models.ResponseProductDetail.MultiplierRequestedLoans()
                                {
                                    minIncome= 0,
                                    maxIncome= 0,
                                    multiplier= 0,
                                  //  listCategory= ""
                                }
                            },
                            categories = new List<Models.ResponseProductDetail.Categories>()
                            {
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category = "ทั้งหมด"
                                },
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category= "สิทธิพิเศษ"
                                },
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category= "ไลฟ์สไตล์"
                                },
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category= "ช้อปปิ้ง"
                                }
                            },
                            benefits = new List<Models.ResponseProductDetail.Benefits>()
                            {
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "รับเงินคืนสูงสุด 2% จากยอดรวมค่าใช้จ่ายผ่านบัตร สูงสุดไม่เกิน 2,000 บาท/รอบบัญชี"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "ทุกการใช้จ่าย 25 บาท รับ 1 M Point"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "รับคะแนน M Point สูงสุด 4 เท่า เมื่อช้อปที่ห้างฯ"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "รับส่วนลดเพิ่มสูงสุด 25% เมื่อแลกคะแนน M Point 2 เท่าของยอดใช้จ่าย"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "แลกคะแนน 800 M Point รับคูปองส่วนลดแทนเงินสด 100 บาท"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "ผ่อนชำระ 0% นาน 6 เดือน เมื่อซื้อสินค้าที่ห้างฯ ผ่านบัตรตั้งแต่ 3,000 บาทขึ้นไป/เซลล์สลิป ทั้งนี้ ตามเงื่อนไขที่บริษัทฯ กำหนด"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "บริการรถลีมูซีน รับ-ส่งสนามบิน และห้องรับรองสนามบิน (Airport Lounge)"
                                }
                                ,
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode= "รายละเอียดเงื่อนไขเป็นไปตามที่ธนาคารและบริษัทฯ กำหนด"
                                }
                            },
                            //decision = new Models.ResponseProductDetail.Decision()
                            //{
                            //     isAutoReject= false,
                            //     overrideFlag= false,
                            //     recommendedCreditDecision="",
                            //     finalReasonCode= "",
                            //     finalAuthorityLevel= "",
                            //     uwEmpowermentLevel= ""
                            //},
                            //uwCriterias = new List<Models.ResponseProductDetail.UWCriterias>()
                            //{
                            //    new Models.ResponseProductDetail.UWCriterias()
                            //    {
                            //        entityType= "P",
                            //        uwAuthorityLevel= "1",
                            //        appealAllowed= false,
                            //        reasonCode= "RR33",
                            //        reasonDesc= "Refer : Gray App Score",
                            //        decision= "REFER",
                            //        partyID= "1",
                            //        reasonPriority= ""
                            //    }
                            //}

                        },
                        new Models.ResponseProductDetail.SuggestedProducts() {
                            facilityCategory = "CC",
                            productNameTH = "บัตรเครดิตวีซ่าแพลทินัม1555555555555555555555",
                            productNameEN = "Visa Platinum Credit Card",
                            productShortNameTH = "",
                            productShortNameEN = "",
                            productCode= "CC06",
                            productDesc = "บัตรเครดิต",
                            saleSheet = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            productCatalog = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            compareTableLink = "https://www.bangkokbank.com/th-TH/Personal/Cards/Credit-Cards",
                            preApprovedFlag = "false",
                          firstEffectiveDate= DateTime.Now.AddYears(-40).ToString("yyyy-MM-dd"),
                            lastEffectiveDate= DateTime.Now.AddMonths(6).ToString("yyyy-MM-dd"),
                            ddrRequired= "",
                            minDDRRepaymentPercentage= 0,
                            minDDRRepayment= 0,
                            minAllowAge= 20,
                            maxAllowAge= 60,
                            minimumSalary= 300000,
                            minRequestLoan= 0,
                            maxRequestLoan= 0,
                            systemRecommendedMaxLoan= 0,
                            additionalFee=new  List<Models.ResponseProductDetail.AdditionalFee>()
                            {
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="PrimaryCardAdditionalFee",
                                    feeUnit= "baht",
                                    feeValue= 3000
                                },
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="SupplementaryCardAdditionalFee",
                                    feeUnit= "baht",
                                    feeValue= 3000
                                },
                                new Models.ResponseProductDetail.AdditionalFee()
                                {
                                    feeType="EntranceFee",
                                    feeUnit= "baht",
                                    feeValue= 0
                                }
                            },
                            repaymentPeriod =new List<RepaymentPeriod>()
                            {
                                new Models.ResponseProductDetail.RepaymentPeriod()
                                {
                                    tentativeApprovedAmount= 0,
                                    tentativeLoanPeriod= 0,
                                    tentativeMI= 0,
                                    tentativeTotalRepayment= 0
                                }
                            },
                            interestRates =new List<InterestRates>()
                            {
                                new Models.ResponseProductDetail.InterestRates()
                                {
                                    segment="",
                                    rateType= "",
                                    minAmount= 0,
                                    maxAmount=0,
                                    calculatedRate= 0,
                                    minRate= 0,
                                    maxRate= 0
                                }
                            },
                            multiplierRequestedLoans =new List<MultiplierRequestedLoans>()
                            {
                                new Models.ResponseProductDetail.MultiplierRequestedLoans()
                                {
                                    minIncome= 0,
                                    maxIncome= 0,
                                    multiplier= 0,
                                    //listCategory= ""
                                }
                            },
                            categories = new List<Models.ResponseProductDetail.Categories>()
                            {
                                new Models.ResponseProductDetail.Categories()
                                {
                                     category= "ไลฟ์สไตล์"
                                }
                            },
                            benefits = new List<Models.ResponseProductDetail.Benefits>()
                            {
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode="ทุก 25 บาท รับคะแนนสะสม 1 คะแนน เพื่อนำมาแลกรับของกำนัลหรือไมล์เดินทางจากสายการบินชั้นนำ"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode="แผนประกันอุบัติเหตุการเดินทาง วงเงินคุ้มครอง สูงสุด 200,000 เหรียญสหรัฐ"
                                },
                                new Models.ResponseProductDetail.Benefits()
                                {
                                    benefitCode="บริการผู้ช่วยส่วนบุคคลตลอด 24 ชั่วโมง"
                                }
                            },
                            //decision = new Models.ResponseProductDetail.Decision()
                            //{
                            //     isAutoReject= false,
                            //     overrideFlag= false,
                            //     recommendedCreditDecision="",
                            //     finalReasonCode= "",
                            //     finalAuthorityLevel= "",
                            //     uwEmpowermentLevel= ""
                            //},
                            //uwCriterias = new List<Models.ResponseProductDetail.UWCriterias>()
                            //{
                            //    new Models.ResponseProductDetail.UWCriterias()
                            //    {
                            //        entityType= "P",
                            //        uwAuthorityLevel= "1",
                            //        appealAllowed= false,
                            //        reasonCode= "RR33",
                            //        reasonDesc= "Refer : Gray App Score",
                            //        decision= "REFER",
                            //        partyID= "1",
                            //        reasonPriority= ""
                            //    }
                            //}

                        },

                    },
                    rulesAudit = new List<Models.ResponseProductDetail.RulesAudit>()
                    {
                        new Models.ResponseProductDetail.RulesAudit()
                        {
                            metaphorName= "",
                            rule= "",
                            timeStamp= ""
                        }
                    }
                }
            });
        }

    }
}
