﻿namespace ASM.Controllers;

using ASM.IServices;
using ASM.Models;
using ASM.Services;

using Microsoft.AspNetCore.Mvc;

public class BillController : Controller
{
  private readonly IBillDetailsServices _billDetailsServices;

  private readonly IBillServices _billServices;

  public BillController()
  {
    this._billServices = new BillServices();
    this._billDetailsServices = new BillDetailsService();
  }

  public IActionResult Delete(Guid id)
  {
    this._billServices.DeleteBill(id);
    return this.RedirectToAction("ShowList");
  }

  public IActionResult DeleteInMyAccount(Guid id)
  {
    this._billServices.DeleteBill(id); // xóa bill
    return this.RedirectToAction("MyAccount", "Home"); //   trả về view MyAccount
  }

  public IActionResult ShowList()
  {
    var viewmodel = new ViewModelBill // tạo viewmodel kiểu ViewModelBill
    {
      Bill = this._billServices.GetAllBills().ToList(),
      BillDetails = this._billDetailsServices.GetAllBillDetails().ToList()
    }; // gán các giá trị cho viewmodel
    return this.View(viewmodel);
  }

  public IActionResult Update(Guid id)
  {
    var bill = this._billServices.GetBillById(id);
    bill.Status = 1;
    this._billServices.UpdateBill(bill);
    return this.RedirectToAction("MyAccount", "Home");
  }

  public class ViewModelBill
  {
    public List<Bill> Bill { get; set; }

    public List<BillDetails> BillDetails { get; set; }
  }

  // create action popup view
  public class ViewModelBills
  {
    public Bill Bill { get; set; }

    public List<BillDetails> BillDetails { get; set; }
  }
}
