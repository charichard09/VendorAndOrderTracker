using VendorAndOrderTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace VendorAndOrderTracker.Controllers;

public class HomeController : Controller
{

  [Route("/")]
  public ActionResult Index() 
  {
    return View();
  }
}
