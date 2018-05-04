using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Library.Interfaces
{
	public interface IRestaurants
	{
		int restaurant_id { get; set; }
		string names { get; set; }
		string address { get; set; }
		string city { get; set; }
		string state { get; set; }
		string zipcode { get; set; }
		string style { get; set; }
		int avg_rating { get; set; }
	}
}
