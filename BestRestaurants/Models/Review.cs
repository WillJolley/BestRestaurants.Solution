using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Review
  {
    public int RestaurantId { get; set; }
    public string Description { get; set; }
    public int ReviewId { get; set; }
    public Restaurant Restaurant { get; set; }
  }
}