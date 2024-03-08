using FaceProductAPI.Models.SearchApp;
using FakeFICOAPI.Models.CreateApp;
using Microsoft.AspNetCore.Mvc;


namespace FaceProductAPI.Interface
{
    public interface ISearchApplicationService
    {
        Task<ResponseBody.FICOApplicationResponse> SerachApplicationAsync(RequestBody body);
        Task<ResponseSubmit> CreateApplocationAsync(RequestApplicationSubmit body);
    }
}
