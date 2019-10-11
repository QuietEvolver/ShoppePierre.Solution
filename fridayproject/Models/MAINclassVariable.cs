using System.Collections.Generic;
namespace FRIDAYPROJECT.Models
{
  public class FRIDAYCLASSVARIABLE
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public Contact Poster { get; set; }
    private  static List<JobOpening> _instances = new List<JobOpening>{};
    public static List<JobOpening> GetAll()
    {
      return _instances;
    }
    public JobOpening(string title, string description, string name, string email, string phonenumber)
    {
      Title = title;
      Description = description;
      Poster = new Contact(name, email, phonenumber);
      _instances.Add(this);
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
    static void Exception()
    {
      try
      {
        int value = 1 / int.Parse("0");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Message = {0}", ex.Message);
        Console.WriteLine("Source = {0}", ex.Source);
        Console.WriteLine("StackTrace = {0}", ex.StackTrace);
        Console.WriteLine("TargetSite = {0}", ex.TargetSite);
      }
    }