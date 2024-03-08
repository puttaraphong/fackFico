using FaceProductAPI.Controllers;
using FaceProductAPI.Interface;
using FaceProductAPI.Models.ResponseProductDetail;
using FakeFICOAPI.Models.ProductDetailRequest;
using FakeFICOAPI.Models.Upload;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FakeFICOAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UploadController : ControllerBase
    {
        private readonly ILogger<UploadController> _log;
        private readonly IWebHostEnvironment _env;
        public UploadController(ILogger<UploadController> logger, IWebHostEnvironment env)
        {
            this._log = logger;
            this._env = env;
        }


    
       
        [HttpGet("FakePDF")]
        public async Task<ActionResult> GetPDF()
        {
            var path = $"{_env.ContentRootPath}//PDF//DM Mapping_123.pdf";

            var streamFile = new FileStream(path, FileMode.Open, FileAccess.Read);

            if (streamFile == null)
                return NotFound(); // returns a NotFoundResult with Status404NotFound response.

            return File(streamFile, "application/pdf", "merge.pdf"); // returns a FileStreamResult
        }


        [HttpGet("FakePDF-IFORMFILE")]
        public async Task<ActionResult> GetPDF2()
        {
            string contentType = "application/pdf";
            var path = $"{_env.ContentRootPath}//PDF//DM Mapping_123.pdf";

            var streamFile = new FileStream(path, FileMode.Open, FileAccess.Read);

            if (streamFile == null)
                return NotFound(); // returns a NotFoundResult with Status404NotFound response.

            using (var stream = streamFile)
            {
                //Params
                Stream baseStream = stream;
                long baseStreamOffset = 0;
                long lenght = stream.Length;
                string name = Path.GetFileNameWithoutExtension(stream.Name);
                string fileName = Path.GetFileName(stream.Name);

                var file = new FormFile(baseStream, baseStreamOffset, lenght, name, fileName)
                {
                    Headers = new HeaderDictionary(),
                    ContentType = contentType
                };
                return Ok(file);
            }
        }


        //[HttpPost("[action]")]
        //public async Task<ActionResult<UploadFiles>> UploadFiles([FromForm] UploadFiles uploadFiles)
        //{
        //    if (uploadFiles.file != null)
        //    {

        //        //Set Key Name
        //        string ImageName = Guid.NewGuid().ToString() + Path.GetExtension(uploadFiles.file.FileName);

        //        //Get url To Save
        //        string SavePath = Path.Combine(Directory.GetCurrentDirectory(), "Upload", ImageName);

        //        using (var stream = new FileStream(SavePath, FileMode.Create))
        //        {
        //            uploadFiles.file.CopyTo(stream);
        //        }
        //        //FileStream fileStream = new FileStream(ImageName, FileMode.Open);
        //        //string line;
        //        //using (StreamReader reader = new StreamReader(fileStream))
        //        //{
        //        //    line = reader.ReadLine();
        //        //}
        //        var file = Path.Combine(Directory.GetCurrentDirectory(), "Upload", ImageName);

        //        string SendData = System.IO.File.ReadAllText(file);
        //        return Ok(SendData);
        //    }
        //    return StatusCode(500);
        //}


    }

}
