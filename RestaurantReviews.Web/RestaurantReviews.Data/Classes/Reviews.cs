using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviews.Data.Interfaces;

namespace RestaurantReviews.Data.Classes
{
	public class Reviews : IReviews
	{
		// fields
		private int _ID;
		private int _Review_ID;
		private string _Customer;
		private int _Rating;

		// constructors
		public Reviews(int ID, int Review_ID, int Rating, string Customer)
		{
			_ID = ID;
			_Review_ID = Review_ID;
			_Rating = Rating;
			_Customer = Customer;
		}

		// implementations
		public int ID { get { return _ID; } set { _ID = value; } }
		public int Review_ID { get { return _Review_ID; } set { _Review_ID = value; } }
		public int Rating { get { return _Rating; } set { _Rating = value; } }
		public string Customer { get { return _Customer; } set { _Customer = value; } }

		public Reviews()
		{
			ID = 0;
			Review_ID = 0;
			Rating = 0;
			Customer = "";
		}
	}
}
