using System.Collections.Generic;
using System;
using Salon;

namespace Salon.Models
{
  public class Stylist
  {
    public string Name { get; set; }
    public DateTime HireDate { get; set; }
    public int Id { get; set; }
    private static List<Stylist> _stylists = new List<Stylist> { };
    public List<Client> Clients { get; set; }

    public Stylist(string name, DateTime hireDate)
    {
      Name = name;
      HireDate = hireDate;
      _stylists.Add(this);
      Id = _stylists.Count;
      Clients = new List<Client> { };
    }

    //public static Stylist Find (int findId)
    //{
      //return 1;
    //}
  }
}