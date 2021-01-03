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
  }
}


