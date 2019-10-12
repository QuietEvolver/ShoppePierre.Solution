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
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
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
        Dictionary<string, object> model = new Dictionary<string, object>();
        Vendor selectedVendor = Vendor.Find(id);
        List<Order> vendorOrders = selectedVendor.Orders;
        model.Add("vendor", selectedVendor);
        model.Add("orders", vendorOrders);
        return View(model);
        }
    
        //Vendors/newOrders
        [HttpPost("/vendors/{vendorId}/Orders")]
        public ActionResult Create(int vendorId, string orderDescription)
        {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Vendor foundVendor = Vendor.Find(vendorId);
        Order newOrder = new Order(orderDescription);
        found Vendor.AddOrder(newOrder);
        List<Order>  vendorOrders = foundVendor.Orders;
        model.Add("orders", vendorOrders);
        model.Add("vendor", foundVendor);
        return View("Show", model);
        }
    }
}
