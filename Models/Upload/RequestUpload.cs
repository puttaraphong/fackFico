namespace FakeFICOAPI.Models.Upload
{
    public class RequestUpload
    {
        public string typeCode { get; set; }
        public string documentLabelCode { get; set; }
        public bool isLastDocument { get; set; }
        public string applicationNumber { get; set; }
        public string idNumber { get; set; }
        public string idTypeCode { get; set; }
        public string entityName { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public IFormFile multipartFile { get; set; }
    }
}
