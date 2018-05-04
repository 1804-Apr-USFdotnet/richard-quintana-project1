using RestaurantReviews.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Library.Classes
{
	public class Restaurants : IRestaurants
	{
		// fields
		private int _restaurant_id;
		private string _names;
		private string _address;
		private string _city;
		private string _state;
		private string _zipcode;
		private string _style;
		private int _avg_rating;

		// constructors
		public Restaurants(int restaurant_id, string names, string address, string city, string state, string style, string zipcode)
		{
			_restaurant_id = restaurant_id;
			_names = names;
			_address = address;
			_city = city;
			_state = state;
			_zipcode = zipcode;
			_style = style;
			_avg_rating = avg_rating;
		}

		// implementations
		public int restaurant_id { get { return _restaurant_id; } set { _restaurant_id = value; } }
		public string names { get { return _names; } set { _names = value; } }
		public string address { get { return _address; } set { _address = value; } }
		public string city { get { return _city; } set { _city = value; } }
		public string state { get { return _state; } set { _state = value; } }
		public string zipcode { get { return _zipcode; } set { _zipcode = value; } }
		public string style { get { return _style; } set { _style = value; } }
		public int avg_rating { get { return _avg_rating; } set { _avg_rating = value; } }
		
		public Restaurants()
		{
			_restaurant_id = 0;
			_names = "";
			_address = "";
			_city = "";
			_state = "";
			_zipcode = "";
			_style = "";
			_avg_rating = 0;
		}
	}
}
