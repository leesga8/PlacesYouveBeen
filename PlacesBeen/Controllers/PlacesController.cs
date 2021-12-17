using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;
using System.Collections.Generic;

namespace PlacesBeen.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/countries/{countryId}/places/new")]
    public ActionResult New(int countryId)
    {
      Country country = Country.Find(countryId);
      return View(country);
    }
    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }
    [HttpGet("/countries/{countryId}/places/{placeId}")]
    public ActionResult Show(int countryId, int placeId)
    {
      Place place = Place.Find(placeId);
      Country country = Country.Find(countryId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("place", place);
      model.Add("country", country);
      return View(model);
    }


  }
}