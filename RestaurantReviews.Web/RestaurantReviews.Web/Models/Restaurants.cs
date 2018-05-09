using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RestaurantReviews.Web.Models
{
	public class Restaurants
	{
		int ID { get; set; }
		[Required]
		string Name { get; set; }
		[Required]
		string Address { get; set; }
		[Required]
		string StyleOfFood { get; set; }
		[Required]
		int Avg_Rating { get; set; }
	}
}