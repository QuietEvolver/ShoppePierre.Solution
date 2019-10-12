using System; 
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShoppePierre.Models;

namespace ShoppePierre.Controllers
{
     public class OrderController : Controller
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

        [HttpPost("/")]//** */
        public ActionResult Create(string vendorTitle, string description)
        {
            Vendor myVendor= new Vendor(vendorTitle, description);
            return RedirectToAction("Index", "Home");
            
        }
        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Vendor vendor = Vvendor.Find(id);
            List<Order> vendorOrders = vendor.Orders;
            Dictionary<string, object> model = new Dictionary<string, object>();
            
            model.Add("orders", orders);
            model.Add("vendor", vendor);
            return View(model);
        }
    
        [HttpPost("/orders/delete")]
        public ActionResult DeleteAll()
        {
        Item.ClearAll();
        return View();
        }
    }
}