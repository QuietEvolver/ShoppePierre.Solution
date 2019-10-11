using System.Collections.Generic;
namespace ShoppePierre.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    private  static List<Order> _instances = new List<Order>{};
    
    public Order(string name, string email, string phoneNumber)
    {
      Name = name;
      Email = email;
      PhoneNumber = phoneNumber;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }
     
    public static List<Order> DeleteAll()
    {
      return _instances.Clear();
    }

    public static Find(int searchId)
    {
      return _instances[searchId - 1];;
    }
    
  }
}
