using System; 
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShoppePierre.Models;

namespace ShoppePierre.Controllers
{
     public class VendorsController : Controller
    {
        //Creates an variable for the vendor.cshtml View() to called by the vendor.Controller{Index()}
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            ViewData["Vendors"]  = Vendor.GetAll();

            return View("Views/Vendors/Index.cshtml");
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
            // Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(id);
            // List<Order> vendorOrders = selectedVendor.Orders;
            // model.Add("vendor", selectedVendor);
            // model.Add("orders", vendorOrders);
            return View(selectedVendor);
        }
    
        //Vendors/newOrders
        [HttpPost("/vendors/{vendorId}/Orders")]
        public ActionResult Create(int vendorId, string orderName, string orderEmail, string orderPhoneNumber)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor foundVendor = Vendor.Find(vendorId);
            List<Order>  vendorOrders = foundVendor.Orders; //AutoAdds Order to correct Vendor
            model.Add("vendor", foundVendor);
            model.Add("orders", vendorOrders);
            return View("Show", model);
        }
    }
}
