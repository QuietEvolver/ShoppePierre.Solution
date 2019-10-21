using System; 
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShoppePierre.Models;

namespace ShoppePierre.Controllers
{
     public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            ViewData["Vendors"]  = Vendor.GetAll();
            return View();//"Views/Vendors/Index.cshtml"
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View("Views/Vendors/New.cshtml");
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string vendorTitle, string description)
        {
            Vendor myVendor= new Vendor(vendorTitle, description);
            return RedirectToAction("Index");
            
        }
        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Vendor selectedVendor = Vendor.Find(id);
            return View(selectedVendor);
        }
    
        [HttpPost("/vendors/{vendorId}/Orders")]
        public ActionResult Create(int vendorId, string orderName, string orderEmail, string orderPhoneNumber)
        {
            Vendor foundVendor = Vendor.Find(vendorId);
            return View("Show", foundVendor);
        }
    }
}
