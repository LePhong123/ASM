namespace ASM.IServices;

using ASM.Models;

public interface ICartDetailsServices
{
    public bool CreateNewCartDetails(CartDetail CartDetail);

    public bool DeleteCartDetail(Guid id);

    public List<CartDetail> GetAllCartDetails();

    public CartDetail GetCartDetailById(Guid id);

    public bool UpdateCartDetail(CartDetail CartDetail);
}