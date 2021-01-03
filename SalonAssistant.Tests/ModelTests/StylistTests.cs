using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Salon.Models;
using System;

namespace Salon.Test
{
  [TestClass]
  public class StylistTests : IDisposable
  {
    public void Dispose()
    {
      Stylist.ClearAll();
    }

    [TestMethod]
    public void SalonConstructor_CreatesInstanceOfStylist_True()
    {
      // Arrange
      string name = "Chanel";
      string hireDate = "12/31/2020";
      Stylist newStylist = new Stylist(name, hireDate);

      // Assert
      Assert.AreEqual(typeof(Stylist), newStylist.GetType());
    }

    [TestMethod]
    public void NameProperty_ReturnsNameValue_String()
    {
      // Arrange
      string name = "Chanel";
      string hireDate = "12/31/2020";
      Stylist newStylist = new Stylist(name, hireDate);

      // Act
      string result = newStylist.Name;

      //Assert
      Assert.AreEqual("Chanel", result);
    }

    [TestMethod]
    public void HireDateProperty_ReturnsHireDateValue_String()
    {
      // Arrange
      string name = "Chanel";
      string hireDate = "12/31/2020";
      Stylist newStylist = new Stylist(name, hireDate);

      // Act
      string result = newStylist.HireDate;

      // Assert
      Assert.AreEqual("12/31/2020", result);
    }

    [TestMethod]
    public void IdProperty_ReturnsIdProperty_Int()
    {
      // Arrange
      string name = "Chanel";
      string hireDate = "12/31/2020";
      Stylist newStylist = new Stylist(name, hireDate);

      // Act
      int result = newStylist.Id;

      // Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllStylists_Stylists()
    {
      // Arrange
      string name = "Chanel";
      string hireDate = "12/31/2020";
      Stylist newStylist0 = new Stylist(name, hireDate);
      Stylist newStylist1 = new Stylist(name, hireDate);
      Stylist newStylist2 = new Stylist(name, hireDate);
      List<Stylist> newList = new List<Stylist> { newStylist0, newStylist1, newStylist2 };

      // Act
      List<Stylist> result = Stylist.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);

    }

  }
}


