using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Salon.Models;
using System;

namespace Salon.Test
{
  [TestClass]
  public class ClientTests : IDisposable
  {
    public void Dispose()
    {
      Client.ClearAll();
    }

    [TestMethod]
    public void ClientConstructor_CreatesInstanceOfClient_Client()
    {
      // Arrange
      int stylistId = 1;
      string name = "Crystal";
      string styleNotes = "straight hair";
      double stylePrice = 75;
      string dateJoin = "12/31/2017";
      Client newClient = new Client(stylistId, name, styleNotes, stylePrice, dateJoin);

      // Act
      Assert.AreEqual(typeof(Client), newClient.GetType());
    }

    [TestMethod]
    public void NameProperty_ReturnsNameValue_String()
    {
      // Arrange
      int stylistId = 1;
      string name = "Crystal";
      string styleNotes = "straight hair";
      double stylePrice = 75;
      string dateJoin = "12/31/2017";
      Client newClient = new Client(stylistId, name, styleNotes, stylePrice, dateJoin);

      // Act
      string result = newClient.Name;

      //Assert
      Assert.AreEqual("Crystal", result);
    }

    [TestMethod]
    public void StyleNotesProperty_ReturnsStyleNotes_String()
    {
      // Arrange
      int stylistId = 1;
      string name = "Crystal";
      string styleNotes = "straight hair";
      double stylePrice = 75;
      string dateJoin = "12/31/2017";
      Client newClient = new Client(stylistId, name, styleNotes, stylePrice, dateJoin);

      // Act
      string result = newClient.StyleNotes;

      // Assert
      Assert.AreEqual("straight hair", result);
    }

    [TestMethod]
    public void StylePriceProperty_ReturnsStylePrice_Double()
    {
      // Arrange
      int stylistId = 1;
      string name = "Crystal";
      string styleNotes = "straight hair";
      double stylePrice = 75;
      string dateJoin = "12/31/2017";
      Client newClient = new Client(stylistId, name, styleNotes, stylePrice, dateJoin);

      // Act
      double result = newClient.StylePrice;

      // Assert
      Assert.AreEqual(125, result);
    }

  }
}