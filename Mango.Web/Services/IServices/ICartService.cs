using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface ICartService
    {
        Task<ResponseDto?> GetCartByUserIdAsync(string userId);
        Task<ResponseDto?> UpsertCartAsync(CartDto cartDto);
        Task<ResponseDto?> RemoveCartAsync(int cartDetails);
        Task<ResponseDto?> ApplyCouponCartAsync(CartDto cartDto);

    }
}
