using Razorpay.Integration.Models;

namespace Razorpay.Integration
{
    public interface IPaymentService
    {
        Task<MerchantOrder> ProcessMerchantOrder(PaymentRequest payRequest);
        Task<string> CompleteOrderProcess(IHttpContextAccessor _httpContextAccessor);
    }
}
