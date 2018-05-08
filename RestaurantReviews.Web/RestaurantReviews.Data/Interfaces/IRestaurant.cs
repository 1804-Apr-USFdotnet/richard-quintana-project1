using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Data.Interfaces
{
	public interface IRestaurant
	{
		int ID { get; set; }
		string Name { get; set; }
		string Address { get; set; }
		string StyleOfFood { get; set; }
		int Avg_Rating { get; set; }
	}
}
