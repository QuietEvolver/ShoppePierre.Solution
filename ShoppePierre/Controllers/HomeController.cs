using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ShoppePierre.Models;

namespace ShoppePierre.Controllers
{
     public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Splash()
      {
        return View();
      }

      // [HttpGet("/vendors")]//home/vendors
      //   public ActionResult Vendors()
      //   {
      //       List<Vendor> allVendors = Vendor.GetAll();
      //       return View(allVendors);
      //   }

      //   [HttpGet("/vendors/new")]
      //   public ActionResult New()
      //   {
      //       return View();
      //   }

    }
}