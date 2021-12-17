using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;
using System.Collections.Generic;

namespace PlacesBeen.Controllers
{
  public class PlacesController : Controller
  {

    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityname)
    {
      Place myPlace = new Place(cityname);
      return RedirectToAction("Index");
    }

    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();

    }
  }
}