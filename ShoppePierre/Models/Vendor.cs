using System.Collections.Generic;

namespace ShoppePierre.Models
{
  public class Vendor
  {    
    private  static List<Vendor> _instances = new List<Vendor>{ };
    public string VendorTitle { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
   
    public Vendor(string vendorTitle, string description)
    {
      VendorTitle = vendorTitle;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{ };
    }
    public void AddOrder(Order order)
    { 
      Orders.Add(order);
    }
    public static Find(int searchId)
    { 
      return _instances[searchId-1];
    } 
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static List<Vendor> DeleteAll()
    {
      return _instances.Clear();
    }

/*
    catch blocks can take an Exception as a parameter, which can help handle exceptions even more effectively. The Exception class has a number of useful properties:

    Message: a short description of the exception;
    Source: the application name;
    StackTrace: the path to what caused the exception;
    TargetSite: the name of the method where the exception occurred. 
    
    ******output in the console:*******

    Message = Attempted to divide by zero.
    Source = DivideByZero
    StackTrace =    at Program.Main()
    TargetSite = Void Main()
    */
    // static void Exception()
    // {
    //   try
    //   {
    //     int value = 1 / int.Parse("0");
    //   }
    //   catch (Exception ex)
    //   {
    //     Console.WriteLine("Message = {0}", ex.Message);
    //     Console.WriteLine("Source = {0}", ex.Source);
    //     Console.WriteLine("StackTrace = {0}", ex.StackTrace);
    //     Console.WriteLine("TargetSite = {0}", ex.TargetSite);
    //   }
    // }