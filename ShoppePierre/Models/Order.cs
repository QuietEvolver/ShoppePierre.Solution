using System.Collections.Generic;
namespace ShoppePierre.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int Id { get; }
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
     
    public static void DeleteAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];;
    }
    
  }
}
