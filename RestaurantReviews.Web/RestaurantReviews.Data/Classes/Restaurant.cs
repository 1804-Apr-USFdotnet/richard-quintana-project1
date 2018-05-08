using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviews.Data.Interfaces;

namespace RestaurantReviews.Data.Classes
{
	public class Restaurant : IRestaurant
	{
		// fields
		private int _ID;
		private string _Name;
		private string _Address;
		private string _StyleOfFood;
		private int _Avg_Rating;

		// constructors
		public Restaurant(int ID, string Name, string Address, string StyleOfFood, int Avg_Rating)
		{
			_ID = ID;
			_Name = Name;
			_Address = Address;
			_StyleOfFood = StyleOfFood;
			_Avg_Rating = Avg_Rating;
		}

		// implementations
		public int ID { get { return _ID; } set { _ID = value; } }
		public string Name { get { return _Name; } set { _Name = value; } }
		public string Address { get { return _Address; } set { _Address = value; } }
		public string StyleOfFood { get { return _StyleOfFood; } set { _StyleOfFood = value; } }
		public int Avg_Rating { get { return _Avg_Rating; } set { _Avg_Rating = value; } }

		public Restaurant()
		{
			ID = 0;
			Name = "";
			Address = "";
			StyleOfFood = "";
			Avg_Rating = 0;
		}
	}
}