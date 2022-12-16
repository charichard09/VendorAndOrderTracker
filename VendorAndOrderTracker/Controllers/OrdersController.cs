using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace VendorAndOrderTracker.Controllers;

public class OrdersController : Controller
{
  [HttpGet("/vendors/{id}/orders/new")]
  public ActionResult New(int id)
  {
    Vendor foundVendor = Vendor.Find(id);
    return View(foundVendor);
  }

  // [HttpGet("/vendors/new")]
  // public ActionResult New()
  // {
  //   return View();
  // }

  // [HttpGet("/vendors/{id}")]
  // public ActionResult Show(int id)
  // {
  //   Vendor foundVendor = Vendor.Find(id);
  //   return View(foundVendor);
  // }
}