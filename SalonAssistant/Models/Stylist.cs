using System.Collections.Generic;
using System;
using Salon;

namespace Salon.Models
{
  public class Stylist
  {
    public string Name { get; set; }
    public string HireDate { get; set; }
    public int Id { get; set; }
    private static List<Stylist> _stylists = new List<Stylist> { };
    public List<Client> Clients { get; set; }

    public Stylist(string name, string hireDate)
    {
      Name = name;
      HireDate = hireDate;
      _stylists.Add(this);
      Id = _stylists.Count;
      Clients = new List<Client> { };
    }

    public static Stylist Find (int findId)
    {
      return _stylists[findId -1];
    }

    public static void ClearAll()
    {
      _stylists.Clear();
    }

    public static List<Stylist> GetAll()
    {
      return _stylists;
    }

    public void AddClient(Client client)
    {
      Clients.Add(client);
    }

    public static void DeleteStylist(int id)
    {
      _stylists.RemoveAll(r => r.Id == id);
    }

  }
}