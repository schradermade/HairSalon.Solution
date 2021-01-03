using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Salon.Models;
using System;

namespace Salon.Test{
  {
    [TestClass]
    public class SalonTests : IDisposable
    {
      public void Dispose()
      {
        Salon.ClearAll();
      }

      [TestMethod]
      public void SalonConstructor_CreatesInstanceOfStylist_True()
      {
        // Arrange
        string name = "Chanel";
        DateTime hireDate = 12/31/2020;
        Stylist newStylist = new Stylist(name, hireDate);

        // Assert
        Assert.AreEqual(typeof(Stylist), newStylist.GetType());
      }
    }
  }
}

