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
    [TestMethod]
    public void SetCityName_SetCityName_String()
    {
      //Arrange
      string cityname = "Seattle";
      Place newPlace = new Place(cityname);

      //Act
      string updatedCityName = "Tacoma";
      newPlace.Cityname = updatedCityName;
      string result = newPlace.Cityname;

      //Assert
      Assert.AreEqual(updatedCityName, result);
    }
  }
}