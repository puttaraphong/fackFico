using FaceProductAPI.Models.ResponseProduct;

namespace FaceProductAPI.Interface
{
    public interface IDocumentDataMock
    {
        Task<FaceProductAPI.Models.SearchApp.ResponseBody.FICOApplicationResponse> GetDocumentSuggestion();

    }
}
