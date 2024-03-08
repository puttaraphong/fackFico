using FaceProductAPI.Models.ResponseProduct;
using FaceProductAPI.Models.ResponseProductDetail;

namespace FaceProductAPI.Interface
{
    public interface IProductDataMock
    {
        Task<ResponseProduct> GetProductData();
        Task<ResponseProductDetail> GetProductDataDetails();
    }
}
