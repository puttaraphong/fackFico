using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using FaceProductAPI.Models.SearchApp;
using static FaceProductAPI.Models.SearchApp.ResponseBody;
using FaceProductAPI.Data;
using FaceProductAPI.Interface;
using FakeFICOAPI.Models.UpdateApplication;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using FakeFICOAPI.Models.Upload;
using System.Threading.Tasks;
using System;
using FakeFICOAPI.Models.CreateApp;


namespace FaceProductAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class servicesController : ControllerBase
    {
        private readonly DatabaseContext _context;
        private readonly ISearchApplicationService _searchApplicationService;
        private readonly IMapper _mapper;
        private readonly IDocumentDataMock _documentDataMock;
        private readonly ILogger<servicesController> _log;
        public servicesController(DatabaseContext context, IMapper mapper,ISearchApplicationService searchApplicationService, IDocumentDataMock documentDataMock, ILogger<servicesController> logger)
        {
            this._context = context;
            this._log = logger;
            this._mapper = mapper;
            this._searchApplicationService = searchApplicationService;
            this._documentDataMock = documentDataMock;
        }

        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public ActionResult<IEnumerable<AA_LoanHistory>> GetAA_LoanHistory()
        {
            return _context.AA_LoanHistory.ToList();
        }

        [HttpPost("registration/rest/client/token")]
        public  ActionResult<string> GetAccessTokenFake(Requesttoken requesttoken)
        {
            return Ok("ZDU1sdsaddfHDDNjVlNi00ZjsdasdadFjNDgtNDJkN2UwMTczMmEw");
        }

        [HttpPost("ficoOriginations/application/fakecreate")]
        public async Task<ActionResult<ResponseSubmit>> CreateApplication(RequestApplicationSubmit body)
        {
            return await _searchApplicationService.CreateApplocationAsync(body);
        }

       [HttpPost("ficoOriginations/application")]
        public async Task<ActionResult<FICOApplicationResponse>> SearchApplicationPost([FromBody] RequestBody body)
        {
            return await _searchApplicationService.SerachApplicationAsync(body);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpPost("GetDocumentSuggestion")]
        public async Task<ActionResult<FICOApplicationResponse>> GetDocumentSuggestion([FromBody] RequestBody body)
        {
            return await Task.FromResult(await _documentDataMock.GetDocumentSuggestion()); 
        }

        [HttpPost("ficoOriginations/updateApplicationStatus")]
        public async Task<IActionResult> UpdateApplicationStatus([FromForm] UpdateApplicationRequest updateApplicationRequest)
        {
            var messageinfo = $"[{this.GetType().Name}]  GenerateApplicatonId";
            _log.LogInformation(messageinfo);

          //  using (IDbContextTransaction transaction = this._context.Database.BeginTransaction())
          //  {
            //    try
           //     {
                    //var itemResult = await this._context.AA_FicoLoanHistory.FirstOrDefaultAsync(x => x.ApplicationID == updateApplicationRequest.applicationNumber);
                    //itemResult.ApplicationStatus = updateApplicationRequest.status;
                    //this._context.AA_FicoLoanHistory.Update(itemResult);
                    //this._context.SaveChanges();
                    //await transaction.CommitAsync();
                    // _logger.LogInformation($"Puttaraphong Running End Save {DateTime.Now.Subtract(datestart).TotalMilliseconds.ToString()}");
                    var dict = new Dictionary<string, bool>()
                        {

                            {"success" , true }

                        };
                    return Ok(dict);
           //     }
         //       catch (Exception ex)
                //{
                //    var message = $"[{this.GetType().Name}]  updateApplicationStatus exception " + ex.Message;
                //    _log.LogError(ex, message);

                //    transaction.Rollback();
                //    throw ex;
                //}
           // };

            return null;

        }

        [HttpPost("v/ficoOriginations/uploadDocument")]
        public IActionResult FakeUploadDoc([FromForm] RequestUpload requestUpload)
        {
            _log.LogInformation($"[{this.GetType().Name}] Upload File {requestUpload.multipartFile.FileName} size : {requestUpload.multipartFile.Length.ToString()}");
            if (requestUpload.multipartFile == null)
            {
                return StatusCode(500);
            }

            //Set Key Name
            string fileName = requestUpload.multipartFile.FileName;

            //Get url To Save
            string path = Path.Combine(Directory.GetCurrentDirectory(), "PDF", fileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                requestUpload.multipartFile.CopyTo(stream);
            }

            //var path = $"{_env.ContentRootPath}//PDF//{ImageName}";

            //var streamFile = new FileStream(path, FileMode.Open, FileAccess.Read);


            //if (streamFile == null)
            //    return NotFound(); // returns a NotFoundResult with Status404NotFound response.

            //return File(streamFile, "application/pdf", "merge.pdf"); // returns a FileStreamResult


            var dict = new Dictionary<string, bool>()
                        {

                            {"success" , true }

                        };
            return Ok(dict);
        }

    }

    public class Requesttoken
    {
        public string clientId { get; set; }
        public string secret { get; set; }
       
    }
}
