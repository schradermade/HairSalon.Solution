using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Collections.Generic;
using System;

namespace Salon.Controllers
{
  public class ClientsController : Controller
  {
    [HttpGet("/clients")]
    public ActionResult Index()
    {
      List<Client> allClients = Client.GetAll();
      return View(allClients);
    }

    [HttpGet("/clients/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/clients")]
    public ActionResult Create(int stylistId, string name, string styleNotes, double stylePrice, string dateJoin)
    {
      Client newClient = new Client(stylistId, name, styleNotes, stylePrice, dateJoin);
      var stylist = Stylist.Find(stylistId);
      stylist.AddClient(newClient);
      return RedirectToAction("Index");
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteClient()
    {
      Client.ClearAll();
      return RedirectToAction("Index");
    }

    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id)
    {
      Client foundClient = Client.Find(id);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Stylist foundStylist = Stylist.Find(foundClient.StylistId);
      model.Add("stylist", foundStylist);
      model.Add("client", foundClient);
      return View(model);
    }

  }
}