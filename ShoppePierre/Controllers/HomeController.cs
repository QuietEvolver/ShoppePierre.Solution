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
  }
}