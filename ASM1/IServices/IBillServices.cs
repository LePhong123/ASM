namespace ASM.IServices;

using ASM.Models;

public interface IBillServices
{
    public bool CreateNewBills(Bill Bill);

    public bool DeleteBill(Guid id);

    public List<Bill> GetAllBills();

    public List<Bill> GetBillByDateTime(DateTime date);

    public Bill GetBillById(Guid id);

    public bool UpdateBill(Bill Bill);
}