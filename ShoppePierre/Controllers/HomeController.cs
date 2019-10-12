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

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}