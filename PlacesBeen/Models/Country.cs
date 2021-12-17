using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Country
  {
    private static List<Country> _instances = new List<Country> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Place> Places { get; set; }

    public Country(string countryName)
    {
      Name = countryName;
      _instances.Add(this);
      Id = _instances.Count;
      Places = new List<Place>{};
    }
  }
}