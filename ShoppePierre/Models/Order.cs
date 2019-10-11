using System.Collections.Generic;
namespace ShoppePierre.Models
{
  public class Order
  {
    public string OrderNumber { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    private  static List<Order> _instances = new List<Order>{};
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public Order(string name, string email, string orderNumber)
    {
      OrderNumber = orderNumber;
      Name = name;
      Email = email;
      _instances.Add(this);
    }
  }
}
