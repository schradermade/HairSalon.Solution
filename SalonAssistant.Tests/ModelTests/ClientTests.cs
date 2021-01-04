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
      Assert.AreEqual(75, result);
    }

    [TestMethod]
    public void DateJoinProperty_ReturnsDateJoined_String()
    {
      // Arrange
      int stylistId = 1;
      string name = "Crystal";
      string styleNotes = "straight hair";
      double stylePrice = 75;
      string dateJoin = "12/31/2017";
      Client newClient = new Client(stylistId, name, styleNotes, stylePrice, dateJoin);

      // Act
      string result = newClient.DateJoin;

      // Assert
      Assert.AreEqual("12/31/2017", result);
    }

    [TestMethod]
    public void AssignId_AssignsIdToClient_Int()
    {
      // Arrange
      int stylistId = 1;
      string name = "Crystal";
      string styleNotes = "straight hair";
      double stylePrice = 75;
      string dateJoin = "12/31/2017";
      Client newClient = new Client(stylistId, name, styleNotes, stylePrice, dateJoin);
      
      // Act
      int result = newClient.StylistId;
      //Assert
      Assert.AreEqual(1, newClient.StylistId);
    }

    [TestMethod]
    public void GetAll_ReturnsListOfClients_String()
    {
      // Arrange
      int stylistId0 = 1;
      string name0 = "Crystal";
      string styleNotes0 = "straight hair";
      double stylePrice0 = 75;
      string dateJoin0 = "12/31/2017";
      Client newClient0 = new Client(stylistId0, name0, styleNotes0, stylePrice0, dateJoin0);
      
      int stylistId1 = 1;
      string name1 = "Crystal";
      string styleNotes1 = "straight hair";
      double stylePrice1 = 75;
      string dateJoin1 = "12/31/2017";
      Client newClient1 = new Client(stylistId1, name1, styleNotes1, stylePrice1, dateJoin1);

      int stylistId2 = 1;
      string name2 = "Crystal";
      string styleNotes2 = "straight hair";
      double stylePrice2 = 75;
      string dateJoin2 = "12/31/2017";
      Client newClient2 = new Client(stylistId2, name2, styleNotes2, stylePrice2, dateJoin2);

      List<Client> newList = new List<Client> { newClient0, newClient1, newClient2 };
      // Act
      List<Client> result = Client.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

        [TestMethod]
    public void ClearAll_ReturnsListOfClients_String()
    {
      // Arrange
      int stylistId0 = 1;
      string name0 = "Crystal";
      string styleNotes0 = "straight hair";
      double stylePrice0 = 75;
      string dateJoin0 = "12/31/2017";
      Client newClient0 = new Client(stylistId0, name0, styleNotes0, stylePrice0, dateJoin0);
      
      int stylistId1 = 1;
      string name1 = "Crystal";
      string styleNotes1 = "straight hair";
      double stylePrice1 = 75;
      string dateJoin1 = "12/31/2017";
      Client newClient1 = new Client(stylistId1, name1, styleNotes1, stylePrice1, dateJoin1);

      int stylistId2 = 1;
      string name2 = "Crystal";
      string styleNotes2 = "straight hair";
      double stylePrice2 = 75;
      string dateJoin2 = "12/31/2017";
      Client newClient2 = new Client(stylistId2, name2, styleNotes2, stylePrice2, dateJoin2);

      List<Client> newList = new List<Client> { };
      // Act
      Client.ClearAll();
      List<Client> result = Client.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_FindClientById_Int()
    {
      // Arrange
      int stylistId = 1;
      string name = "Crystal";
      string styleNotes = "straight hair";
      double stylePrice = 75;
      string dateJoin = "12/31/2017";
      Client newClient = new Client(stylistId, name, styleNotes, stylePrice, dateJoin);

      // Act
      Client result = Client.Find(1);

      // Assert
      Assert.AreEqual(newClient, result);
    }

  }
}