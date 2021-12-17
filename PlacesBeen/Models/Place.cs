using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Place
  {
    public string Cityname { get; set; }
    public Place(string cityname)
    {
      Cityname = cityname;
    }
  }
}