using RestaurantReviews.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
	public class Reviews : IReviews
	{
		// fields
		private int _Id;
		private int _Review_Id;
		private int _Rating;
		private string _Customer;

		// constructors
		public Reviews(int Review_Id, int Rating, string Customer)
		{
			_Id = Id;
			_Review_Id = Review_Id;
			_Rating = Rating;
			_Customer = Customer;
		}

		// implementations
		public int Id { get { return _Id; } set { _Id = value; } }
		public int Review_Id { get { return _Review_Id; } set { _Review_Id = value; } }
		public int Rating { get { return _Rating; } set { _Rating = value; } }
		public string Customer { get { return _Customer; } set { _Customer = value; } }

		public Reviews()
		{
			_Id = 0;
			_Review_Id = 0;
			_Customer = "";
			_Rating = 0;
		}
	}
}
