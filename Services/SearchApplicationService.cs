using FaceProductAPI.Data;
using FaceProductAPI.Interface;
using FaceProductAPI.Models.SearchApp;
using FakeFICOAPI.Models.CreateApp;
using FakeFICOAPI.Models.UpdateApplication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Reflection.Metadata;
using System.Text;
using static FaceProductAPI.Models.SearchApp.ResponseBody;
using Applicant = FaceProductAPI.Models.SearchApp.ResponseBody.Applicant;
using ApplicationDetails = FaceProductAPI.Models.SearchApp.ResponseBody.ApplicationDetails;
using Document = FaceProductAPI.Models.SearchApp.ResponseBody.Document;
using Facility = FaceProductAPI.Models.SearchApp.ResponseBody.Facility;
using Identification = FaceProductAPI.Models.SearchApp.ResponseBody.Identification;
using Person = FaceProductAPI.Models.SearchApp.ResponseBody.Person;

namespace FaceProductAPI.Services
{
    public class SearchApplicationService: ISearchApplicationService
    {
        private readonly DatabaseContext _context;
        public SearchApplicationService(DatabaseContext context)
        {
            _context = context;
        }

   
        public async Task<ResponseSubmit> CreateApplocationAsync(RequestApplicationSubmit body)
        {

            var appI = _context.AA_FicoLoanHistory.OrderByDescending(x => x.SubmittedDate).FirstOrDefault();
            var applicationId = "99924500001";
            var citizenId = "3102001149500";

            if (!string.IsNullOrWhiteSpace(body.applicants[0].person.identification[0].reference))
            {
                citizenId = body.applicants[0].person.identification[0].reference;
            }

            if (appI != null)
            {
                applicationId = (decimal.Parse(appI.ApplicationID) + 1).ToString("0000000000");
            }
            _context.AA_FicoLoanHistory.Add(new AA_FicoLoanHistory()
            {
                ApplicationID = applicationId,
                SubmittedDate = DateTime.Now,
                CitizenId = citizenId,
                ApplicationStatus = "Submitted",
                LoanType = "CREDITCARD"

            });

            _context.SaveChanges();

            return new ResponseSubmit() { applicationNumber = applicationId };
        }

        public async Task<ResponseBody.FICOApplicationResponse> SerachApplicationAsync(RequestBody body)
        {
            ResponseBody.FICOApplicationResponse product = new ResponseBody.FICOApplicationResponse();
            List<AA_FicoLoanHistory> historyResult=new List<AA_FicoLoanHistory>();
            if (body.FilterName == "APP_NUM")
            {
                historyResult = _context.AA_FicoLoanHistory.Where(p => p.LoanType == body.FacilityCategoryCode && p.ApplicationID == body.Field0).ToList();
            }
            else
            if (body.FilterName == "ID")
            {
                historyResult = _context.AA_FicoLoanHistory.Where(p => p.LoanType == body.FacilityCategoryCode && p.CitizenId == body.Field0).ToList();
            }


            if (historyResult.Count() == 0)
            {
                //productList.Add(productList);
                return product;
            }

            foreach (var item in historyResult)
            {
                product = new FaceProductAPI.Models.SearchApp.ResponseBody.FICOApplicationResponse()
                {
                    applicationSearchResult = new List<ResponseBody.ApplicationSearchResult>()
                    {
                        new ApplicationSearchResult() {
                            applicationDetails = new ApplicationDetails()
                            {
                                appCreationDatetime = Convert.ToDateTime(item.SubmittedDate),
                                applicationNumber = item.ApplicationID,
                                applicationStatusCode =item.ApplicationStatus,
                                channelCode = "",
                            },
                            applicants = new List<Applicant>()
                            {
                                new Applicant()
                                {
                                    person = new Person()
                                    {
                                        identification = new List<Identification>()
                                        {
                                            new Identification()
                                            {
                                                   idTypeCode = body.Field1,
                                                   reference = item.ApplicationID
                                            }
                                        },
                                    },

                                }
                            },
                            documents = new List<Document>()
                            {
                                 new Document()
                                {
                                    typeCode="Doc_6",
                                    documentLabelCode="",
                                    statusCode="Pending",
                                    isMandatory=false,
                                    entityName="",
                                    idNumber="",
                                    idTypeCode="",
                                    //docCreationDatetime = Convert.ToDateTime("2024-01-03 13:34:37.730")
                                },
                                new Document()
                                {
                                    typeCode="Doc_13",
                                    documentLabelCode="",
                                    statusCode="Pending",
                                    isMandatory=false,
                                    entityName="",
                                    idNumber="",
                                    idTypeCode="",
                                    //docCreationDatetime = Convert.ToDateTime("2024-01-03 13:50:00.730")
                                }
                                ,
                                new Document()
                                {
                                    typeCode="Doc_14",
                                    documentLabelCode="",
                                    statusCode="Fail",
                                    isMandatory=false,
                                    entityName="",
                                    idNumber="",
                                    idTypeCode="",
                                    //docCreationDatetime = Convert.ToDateTime("2024-01-03 13:52:00.730")
                                }
                                ,
                                new Document()
                                {
                                    typeCode="Doc_15",
                                    documentLabelCode="",
                                    statusCode="Submitted",
                                    isMandatory=false,
                                    entityName="",
                                    idNumber="",
                                    idTypeCode="",
                                    //docCreationDatetime = Convert.ToDateTime("2024-01-03 13:52:00.730")
                                }
                                 ,
                                new Document()
                                {
                                    typeCode="Doc_16",
                                    documentLabelCode="",
                                    statusCode="Not Applicable",
                                    isMandatory=false,
                                    entityName="",
                                    idNumber="",
                                    idTypeCode="",
                                    //docCreationDatetime = Convert.ToDateTime("2024-01-03 13:52:00.730")
                                }
                                  ,
                                new Document()
                                {
                                    typeCode="Doc_17",
                                    documentLabelCode="",
                                    statusCode="Pass",
                                    isMandatory=false,
                                    entityName="",
                                    idNumber="",
                                    idTypeCode="",
                                    //docCreationDatetime = Convert.ToDateTime("2024-01-03 13:52:00.730")
                                }
                            },
                            facilities = new List<Facility>()
                            {
                                new Facility()
                                {
                                    facilityCategoryCode = item.LoanType
                                }   
                            }
                        }
                    }
                };
            }
            return product;
        }

    }
}
