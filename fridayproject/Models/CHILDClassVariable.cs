using System.Collections.Generic;
namespace JobBoard.Models
{
  public class Contact
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    private  static List<Contact> _instances = new List<Contact>{};
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public Contact(string name, string email, string phonenumber)
    {
      Name = name;
      Email = email;
      PhoneNumber = phonenumber;
      _instances.Add(this);
    }
  }
}
