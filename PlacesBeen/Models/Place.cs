using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Place
  {
    public string Cityname { get; set; }
    private static List<Place> _instances = new List<Place> { };
    public Place(string cityname)
    {
      Cityname = cityname;
      _instances.Add(this);
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}