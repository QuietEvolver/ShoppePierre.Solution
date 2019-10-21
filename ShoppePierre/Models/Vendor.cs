using System.Collections.Generic;

namespace ShoppePierre.Models
{
  public class Vendor
  {    
    private static List<Vendor> _instances = new List<Vendor>{ };
    public string VendorTitle { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
   
    public Vendor(string vendorTitle, string description)
    {
      VendorTitle = vendorTitle;
      Description = description;
      Orders = new List<Order>{ };
      Id = _instances.Count;
      _instances.Add(this);
    }
    
    public void AddOrder(Order order)
    { 
      Orders.Add(order);
    }
    public static Vendor Find(int searchId)
    { 
      return _instances[searchId];
    } 
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static void DeleteAll()
    {
       _instances.Clear();
    }
  }
} 