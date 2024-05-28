namespace ASM.IServices;

using ASM.Models;

public interface IBillDetailsServices
{
    public bool CreateNewBillDetails(BillDetails BillDetails);

    public bool DeleteBillDetails(Guid id);

    public List<BillDetails> GetAllBillDetails();

    public BillDetails GetBillDetailsById(Guid id);

    public bool UpdateBillDetails(BillDetails BillDetails);
}