namespace ASM.IServices;

using ASM.Models;

public interface ICartServices
{
    public bool CreateNewCarts(Cart Cart);

    public bool DeleteCart(Guid id);

    public List<Cart> GetAllCarts();

    public Cart GetCartByUserId(Guid id);

    public bool UpdateCart(Cart Cart);
}