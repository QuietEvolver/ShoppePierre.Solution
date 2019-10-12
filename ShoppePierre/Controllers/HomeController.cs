using Microsoft.AspNetCore.Mvc;
namespace ShoppePierre.Controllers
{
     public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Splash()
      {
        return View();
      }

    //   [HttpGet("/vendors")]//home/vendors
    //     public ActionResult Index()
    //     {
    //         List<Vendor> allVendors = Vendor.GetAll();
    //         return View(allVendors);
    //     }

    //     [HttpGet("/vendors/new")]
    //     public ActionResult New()
    //     {
    //         return View();
    //     }

    }
}