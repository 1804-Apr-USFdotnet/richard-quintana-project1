using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Data.Interfaces
{
	public interface IReviews
	{
		int ID { get; set; }
		int Review_ID { get; set; }
		string Customer { get; set; }
		int Rating { get; set; }
	}
}
