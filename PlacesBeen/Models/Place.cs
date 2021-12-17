using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Place
  {
    public string Cityname { get; set; }
    public int Id { get; }
    private static List<Place> _instances = new List<Place> { };
    public Place(string cityname)
    {
      Cityname = cityname;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}