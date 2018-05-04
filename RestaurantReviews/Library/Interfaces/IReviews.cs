using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Library.Interfaces
{
	public interface IReviews
	{
		int Id { get; set; }
		int Review_Id { get; set; }
		int Rating { get; set; }
		string Customer { get; set; }
	}
}
