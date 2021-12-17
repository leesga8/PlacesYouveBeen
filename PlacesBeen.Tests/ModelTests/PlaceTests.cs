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
      Place newPlace = new Place("test", "friend", 2, "hi");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      //Arrange
      string cityName = "Seattle";

      //Act
      Place newPlace = new Place(cityName, "friend", 2, "hi");
      string result = newPlace.Cityname;

      //Assert
      Assert.AreEqual(cityName, result);
    }
    [TestMethod]
    public void SetCityName_SetCityName_String()
    {
      //Arrange
      string cityname = "Seattle";
      Place newPlace = new Place(cityname, "friend", 2, "hi");

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
      Place newPlace1 = new Place(city1,  "friend", 2, "hi");
      Place newPlace2 = new Place(city2, "friend", 2, "hi");
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
      Place newPlace = new Place(city, "friend", 2, "hi");

      //Act
      int result = newPlace.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectItem_Item()
    {
      //Arrange
      string city1 = "Seattle";
      string city2 = "Portland";
      Place newCity1 = new Place(city1, "friend", 2, "hi");
      Place newCity2 = new Place(city2, "friend", 2, "hi");

      //Act
      Place result = Place.Find(2);

      //Assert
      Assert.AreEqual(newCity2, result);
    }
  }
}
