using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesBeen.Models;
using System;

namespace PlacesBeen.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

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
    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlaceList()
    {
      // Arrange
      List<Place> newList = new List<Place> { };

      // Act
      List<Place> result = Place.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsPlaces_PlaceList()
    {
      //Arrange
      string city1 = "Seattle";
      string city2 = "Tacoma";
      Place newPlace1 = new Place(city1);
      Place newPlace2 = new Place(city2);
      List<Place> newList = new List<Place> { newPlace1, newPlace2 };

      //Act
      List<Place> result = Place.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_PlacesInstantiateWithAnIdAndGetterReturns_String()
    {
      //Arrange
      string city = "Seattle";
      Place newPlace = new Place(city);

      //Act
      int result = newPlace.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

  }
}