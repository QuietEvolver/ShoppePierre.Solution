using System; 
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShoppePierre.Models;

namespace ShoppePierre.Controllers
{
     public class OrdersController : Controller
    {
        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult New(int vendorId)
        {
            Vendor vendor= Vendor.Find(vendorId);
            return View(vendor);
        }
        
        [HttpPost("/orders/new")]
        public ActionResult Create(int vendorId, string orderName, string orderEmail, string orderPhoneNumber)
        {
            Order myOrder= new Order(vendorId, orderName, orderEmail, orderPhoneNumber);
            Vendor foundVendor = Vendor.Find(vendorId);
            return View("Views/Vendors/Show.cshtml", foundVendor);
        }
        [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
        public ActionResult Show(int vendorId, int orderId)
        {
            Order order = Order.Find(orderId);
            Vendor vendor = Vendor.Find(vendorId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("order", order);              
            model.Add("vendor", vendor);
            return View(model);
        }
    
        [HttpPost("/orders/delete")]
        public ActionResult DeleteAll()
        {
            Order.DeleteAll();
            return View();
        }
    }
}