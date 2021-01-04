using System.Collections.Generic;
using System;
using Salon;

namespace Salon.Models
{
  public class Client
  {
    public string Name { get; private set; }
    public string StyleNotes { get; private set; }
    public double StylePrice { get; private set; }
    public string DateJoin { get; set; }
    public int Id { get; set; }

    public int StylistId { get; set; }

    private static List<Client> _clients = new List<Client> { };

    public Client(int stylistId, string name, string styleNotes, double stylePrice, string dateJoin)
    {
      StylistId = stylistId;
      Name = name;
      StyleNotes = styleNotes;
      StylePrice = stylePrice;
      DateJoin = dateJoin;
      _clients.Add(this);
      Id = _clients.Count;
    }

    public static List<Client> GetAll()
    {
      return _clients;
    }

    public static void ClearAll()
    {
      _clients.Clear();
    }

    public static Client Find(int findId)
    {
      return _clients[findId -1];
    }

    public static void DeleteClient(int id)
    {
      _clients.RemoveAll(r => r.Id == id);
    }

  }
}