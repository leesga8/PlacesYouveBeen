using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesBeen.Models;
using System;

namespace PlacesBeen.Tests
{
  [TestClass]
  public class PlaceTests /*: IDisposable*/
  {

    // public void Dispose()
    // {
    //   Place.ClearAll();
    // }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      //Arrange
      string cityName = "Seattle";

      //Act
      Place newPlace = new Place(cityName);
      string result = newPlace.Cityname;

      //Assert
      Assert.AreEqual(cityName, result);
    }
  }
}