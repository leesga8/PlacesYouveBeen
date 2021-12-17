using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;

namespace PlacesBeen.Controllers
{
  public class CountriesController : Controller
  {
    [HttpGet("/countries")]
    public ActionResult Index()
    {
      List<Country> allCountries = Country.GetAll();
      return View(allCountries);
    }
    [HttpGet("/countries/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/countries")]
    public ActionResult Create(string countryName)
    {
      Country newCountry = new Country(countryName);
      return RedirectToAction("Index");
    }
    [HttpGet("/countries/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Country selectedCountry = Country.Find(id);
      List<Place> countryPlaces = selectedCountry.Places;
      model.Add("country", selectedCountry);
      model.Add("places", countryPlaces);
      return View(model);
    }
    // This one creates new Places within a given Country, not new Countries:
    [HttpPost("/countries/{countryId}/places")]
    public ActionResult Create(int countryId, string cityname, string friend, int duration, string journal)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
       Country foundCountry = Country.Find(countryId);
       Place newPlace = new Place(cityname, friend, duration, journal);
       foundCountry.AddPlace(newPlace);
       List<Place> countryPlaces = foundCountry.Places;
       model.Add("places", countryPlaces);
       model.Add("country", foundCountry);
       return View("Show", model);
    }
  }
}