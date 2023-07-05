using Discount.Grpc.Protos;

namespace Basket.API.GrpcServices.Interfaces
{
    public interface IDiscountGrpcService
    {
        Task<CouponModel> GetDiscount(string productName);
    }
}
