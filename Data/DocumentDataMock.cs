using FaceProductAPI.Interface;
using FaceProductAPI.Models.ResponseProduct;
using Microsoft.AspNetCore.Http;
using System;
using static FaceProductAPI.Models.SearchApp.ResponseBody;

namespace FaceProductAPI.Data
{
    public class DocumentDataMock : IDocumentDataMock
    {
        public Task<FaceProductAPI.Models.SearchApp.ResponseBody.FICOApplicationResponse> GetDocumentSuggestion()
        {
            return Task.FromResult(
            new FaceProductAPI.Models.SearchApp.ResponseBody.FICOApplicationResponse()
            {
                applicationSearchResult = new List<ApplicationSearchResult>()
                {
                    new ApplicationSearchResult {
                        applicationDetails = new FaceProductAPI.Models.SearchApp.ResponseBody.ApplicationDetails()
                        {
                            appCreationDatetime = Convert.ToDateTime("2024-01-03 13:34:37.730"),
                            applicationNumber = "0001",
                            applicationStatusCode = "PENDOCUMENT",
                            channelCode = "",

                        },
                        applicants = new List<Applicant>()
                        {
                            new Applicant()
                            {
                                person = new FaceProductAPI.Models.SearchApp.ResponseBody.Person()
                                {

                                }
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

                        }
                    }
                }
            });
        } 
    }
      
    
}
