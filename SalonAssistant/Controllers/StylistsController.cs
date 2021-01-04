using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Collections.Generic;
using System;

namespace Salon.Controllers
{
  public class StylistsController : Controller
  {
    [HttpGet("/stylists")]
    public ActionResult Index()
    {
      List<Stylist> allStylists = Stylist.GetAll();
      return View(allStylists);
    }

    [HttpGet("/stylists/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/stylists")]
    public ActionResult Create(string name, string hireDate)
    {
      Stylist newStylist = new Stylist(name, hireDate);
      return RedirectToAction("Index");
    }

    [HttpGet("/stylists/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Stylist foundStylist = Stylist.Find(id);
      List<Client> stylistClients = foundStylist.Clients;
      model.Add("stylist", foundStylist);
      model.Add("clients", stylistClients);
      return View(model);
    }

    [HttpPost("/stylists/delete")]
    public ActionResult DeleteClient()
    {
      Stylist.ClearAll();
      return RedirectToAction("Index");
    }

    [HttpGet("/stylists/{stylistId}/clients")]
    public ActionResult Create(int stylistId, string name, string styleNotes, double stylePrice, string dateJoin)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Stylist foundStylist = Stylist.Find(stylistId);
      Client foundClient = new Client(stylistId, name, styleNotes, stylePrice, dateJoin);
      foundStylist.AddClient(foundClient);
      List<Client> stylistClients = foundStylist.Clients;
      model.Add("clients", stylistClients);
      model.Add("stylist", foundStylist);
      return View("Show", model);
    }
      [HttpPost("/stylists/{id}")]
      public ActionResult Destroy(int id)
      {
        Stylist foundStylist = Stylist.Find(id);
        Stylist.DeleteStylist(foundStylist.Id);
        return RedirectToAction("Index");
      }

      [HttpGet("/stylists/{id}/clients/new")]
      public ActionResult NewClient(int id)
      {
        Stylist foundStylist = Stylist.Find(id);
        return View(foundStylist);
      }
    }
  }