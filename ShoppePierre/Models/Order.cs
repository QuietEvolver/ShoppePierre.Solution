using System.Collections.Generic;
using ShoppePierre.Models;

namespace ShoppePierre.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int Id { get; }
    private  static List<Order> _instances = new List<Order>{};
    
    public Order(int vendorId, string name, string email, string phoneNumber)
    {
      Name = name;
      Email = email;
      PhoneNumber = phoneNumber;
      Id = _instances.Count; //put before instance to start at '0';
      _instances.Add(this); //Order class _instance
      Vendor vendor = Vendor.Find(vendorId); //Vendor.Find() parent Id
      vendor.Orders.Add(this);  //auto adds to correct vendor._instance
    }
    // order added to this particular Vendor
    public void AddToVendor(Vendor vendor)
    {
      vendor.Orders.Add(this); 
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
     
    public static void DeleteAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId];
    }
    
  }
}
