using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace VendorAndOrderTracker.Controllers;

public class VendorsController : Controller
{
  [HttpGet("/vendors")]
  public ActionResult Index()
  {
    List<Vendor> allVendors = Vendor.GetAll();
    return View(allVendors);
  }

  [HttpGet("/vendors/new")]
  public ActionResult New()
  {
    return View();
  }

  [HttpPost("/vendors")]
  public ActionResult Create(string name, string description)
  {
    Vendor newVendor = new Vendor(name, description);
    return RedirectToAction("Index");
  }

  [HttpGet("/vendors/{id}")]
  public ActionResult Show(int id)
  {
    Vendor foundVendor = Vendor.Find(id);
    return View(foundVendor);
  }
}