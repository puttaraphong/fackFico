using FaceProductAPI.Data;
using FaceProductAPI.Interface;
using FaceProductAPI.Models.ResponseProduct;
using FaceProductAPI.Models.ResponseProductDetail;
using FakeFICOAPI.Models.ProductDetailRequest;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Channels;
using static FaceProductAPI.Models.SearchApp.ResponseBody;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Application = FaceProductAPI.Models.ResponseProductDetail.Application;

namespace FaceProductAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DMProductController : ControllerBase
    {
        private readonly IProductDataMock _datamock;
        private readonly IWebHostEnvironment _env;
        public DMProductController(IProductDataMock datamock, IWebHostEnvironment env)
        {
            this._datamock = datamock;
            this._env = env;
        }

        //[HttpGet("[action]")]
        //public async Task<ResponseProduct> GetEligibleProductsResp()
        //{
        //    return await Task.FromResult(await _datamock.GetProductData());
        //}

        //[HttpPost("[action]")]
        //public async Task<ResponseProductDetail> GetProductDetailResp([FromBody] ResponseProductDetail request)
        //{
        //    ResponseProductDetail data = new ResponseProductDetail();
        //    if (request != null && request.application.requestDetail.callType == "GET_PRODUCT_CATALOG")
        //    {
        //        var path = $"{_env.ContentRootPath}\\JsonData\\ResponseProductDetail.json";
        //        if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Linux))
        //        {
        //            path = $"{_env.ContentRootPath}/JsonData/ResponseProductDetail.json";
        //        }



        //        using (StreamReader r = new StreamReader(path))
        //        {
        //            string json = r.ReadToEnd();
        //            data = JsonConvert.DeserializeObject<ResponseProductDetail>(json);
        //        }

        //        //ResponseProductDetail data = await Task.FromResult(await _datamock.GetProductDataDetails());


        //        List<Models.ResponseProductDetail.SuggestedProducts> SuggestionProductList = data.application.suggestedProducts;
        //        List<Models.ResponseProductDetail.Applicants> ApplicantsList = data.application.applicants;
        //        List<Models.ResponseProductDetail.RulesAudit> RuleAuditList = data.application.rulesAudit;

        //        var productCode = "";
        //        if (request != null)
        //        {
        //            productCode = request.application.suggestedProducts[0].productCode;
        //        }


        //        var SuggestList = new List<Models.ResponseProductDetail.SuggestedProducts>();
        //        SuggestList = SuggestionProductList.Where(s => s.productCode == productCode).ToList();
        //        data = new ResponseProductDetail()
        //        {
        //            application = new Models.ResponseProductDetail.Application()
        //            {
        //                requestDetail = new Models.ResponseProductDetail.RequestDetail()
        //                {
        //                    callType = data.application.requestDetail.callType,
        //                },
        //                applicationDetails = new Models.ResponseProductDetail.ApplicationDetails()
        //                {
        //                    channel = data.application.applicationDetails.channel,
        //                    leadRefNumber = data.application.applicationDetails.leadRefNumber,
        //                },
        //                applicants = ApplicantsList,
        //                suggestedProducts = SuggestList,
        //                rulesAudit = RuleAuditList
        //            }
        //        };
        //        return data;
        //    }

        //}




        [HttpPost]
        [Route("rest/service/processWithDecisionFlow")]
        public async Task<ResponseProductDetail> GetEligibleProductsResp([FromBody] ResponseProductDetail request, [FromQuery] string? solutionID)
        {
            //ResponseProductDetail dataList = new ResponseProductDetail();
            ResponseProductDetail data = new ResponseProductDetail();

            var path = $"{_env.ContentRootPath}\\JsonData\\ResponseProductDetail.json";
            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Linux))
            {
                path = $"{_env.ContentRootPath}/JsonData/ResponseProductDetail.json";
            }

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                data = JsonConvert.DeserializeObject<ResponseProductDetail>(json);
            }

            //ResponseProductDetail data = await Task.FromResult(await _datamock.GetProductDataDetails());

            List<Models.ResponseProductDetail.SuggestedProducts> SuggestionProductList = data.application.suggestedProducts;
            List<Models.ResponseProductDetail.Applicants> ApplicantsList = data.application.applicants;
            List<Models.ResponseProductDetail.RulesAudit> RuleAuditList = data.application.rulesAudit;

            if (request != null && request.application.requestDetail.callType == "GET_PRODUCT_CATALOG")
            {
                var productCode = "";
                if (request != null)
                {
                    productCode = request.application.suggestedProducts[0].productCode;
                }
                var SuggestList = new List<Models.ResponseProductDetail.SuggestedProducts>();
                SuggestList = SuggestionProductList.Where(s => s.productCode == productCode).ToList();
                data = new ResponseProductDetail()
                {
                    application = new Models.ResponseProductDetail.Application()
                    {
                        requestDetail = new Models.ResponseProductDetail.RequestDetail()
                        {
                            callType = data.application.requestDetail.callType,
                        },
                        applicationDetails = new Models.ResponseProductDetail.ApplicationDetails()
                        {
                            channel = data.application.applicationDetails.channel,
                            leadRefNumber = data.application.applicationDetails.leadRefNumber,
                        },
                        applicants = ApplicantsList,
                        suggestedProducts = SuggestList,
                        rulesAudit = RuleAuditList
                    }
                };


            }

            if (request != null && request.application.requestDetail.callType == "GET_ELIGIBLE_PRODUCTS")
            {
                Decimal inCome = 0;

                if (request != null)
                {
                    inCome = request.application.applicants[0].person.declaredIncome.Value;
                }

                var SuggestList = new List<Models.ResponseProductDetail.SuggestedProducts>();

                SuggestList = SuggestionProductList.ToList();
                data = new ResponseProductDetail()
                {
                    application = new Models.ResponseProductDetail.Application()
                    {
                        requestDetail = new Models.ResponseProductDetail.RequestDetail()
                        {
                            callType = data.application.requestDetail.callType,
                        },
                        applicationDetails = new Models.ResponseProductDetail.ApplicationDetails()
                        {
                            channel = data.application.applicationDetails.channel,
                            leadRefNumber = data.application.applicationDetails.leadRefNumber,
                        },
                        applicants = ApplicantsList,
                        suggestedProducts = SuggestList,
                        rulesAudit = RuleAuditList
                    }
                };
                //dataList.Add(data);


                if (inCome == 0)
                {
                    data = null;
                }
            }

            return data;
        }
    }
}
