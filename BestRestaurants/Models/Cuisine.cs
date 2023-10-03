using System.Collections.Generic;
using MySqlConnector;

namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public string Name { get; set; }
    public int CuisineId { get; set; }
    public List<Restaurant> Restaurants { get; set; }
  }
}