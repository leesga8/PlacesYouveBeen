using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesBeen.Models;
using System.Collections.Generic;
using System;

namespace PlacesBeen.Tests
{
  [TestClass]
  public class CountryTests : IDisposable
  {
    public void Dispose()
    {
      Country.ClearAll();
    }
    [TestMethod]
    public void CountryConstructor_CreatesInstanceofCountry_Country()
    {
      Country newCountry = new Country("test country");
      Assert.AreEqual(typeof(Country), newCountry.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Country";
      Country newCountry = new Country(name);

      //Act
      string result = newCountry.Name;

      //Assert
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsCountryId_Int()
    {
      //Arrange
      string name = "Test Country";
      Country newCountry = new Country(name);

      //Act
      int result = newCountry.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllCountryObjects_CountryList()
    {
      //Arrange
      string name01 = "USA";
      string name02 = "Japan";
      Country newCountry1 = new Country(name01);
      Country newCountry2 = new Country(name02);
      List<Country> newList = new List<Country> { newCountry1, newCountry2 };

      //Act
      List<Country> result = Country.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectCountry_Country()
    {
      //Arrange
      string name01 = "USA";
      string name02 = "Japan";
      Country newCountry1 = new Country(name01);
      Country newCountry2 = new Country(name02);

      //Act
      Country result = Country.Find(2);

      //Assert
      Assert.AreEqual(newCountry2, result);
    }
  }
}