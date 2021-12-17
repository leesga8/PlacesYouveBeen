using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Country
  {
    private static List<Country> _instances = new List<Country> { };
    public string Name { get; set; }
    public int Id { get; }
    public List<Place> Places { get; set; }

    public Country(string countryName)
    {
      Name = countryName;
      _instances.Add(this);
      Id = _instances.Count;
      Places = new List<Place> { };
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Country> GetAll()
    {
      return _instances;
    }
    public static Country Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public void AddPlace(Place place)
    {
      Places.Add(place);
    }

  }
}