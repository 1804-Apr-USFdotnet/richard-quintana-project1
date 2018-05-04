using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviews.Library.Interfaces;
using Data;
using Library.Classes;

namespace RestaurantReviews.Library.Classes
{
	public class Functions : IFunctions
	{
		LibraryHelper libraryHelper = new LibraryHelper();

		public void SearchRestaurant(string NameOfRestaurant)
		{
			var results = libraryHelper.GetRestaurant();
			foreach (var Restaurants in results)
			{
				if (Restaurants.names.Contains(NameOfRestaurant))
				{
					Console.WriteLine("Restaurant name: " + Restaurants.names);
				}
			}
		}

		public void RestaurantDetails(string NameOfRestaurant)
		{
			var results = libraryHelper.GetRestaurant();
			foreach (var Restaurants in results)
			{
				if (Restaurants.names == NameOfRestaurant)
				{
					Console.WriteLine("Name: " + Restaurants.names + " Address: " + Restaurants.address + " City: " + Restaurants.city + " State: " + Restaurants.state + " Zipcode: " + Restaurants.zipcode + " Rating: " + Restaurants.avg_rating);
				}
			}
		}

		public void ShowAll()
		{
			var results = libraryHelper.GetRestaurant();
			foreach (var Restaurants in results)
				Console.WriteLine(Restaurants.names);
		}

		public void AllReviews(string NameOfRestaurant)
		{
			int restaurantID = 0;
			var results = libraryHelper.GetRestaurant();
			var resultsRev = libraryHelper.GetReviews();
			foreach (var Restaurants in results)
			{
				if (Restaurants.names == NameOfRestaurant)
				{
					restaurantID = Restaurants.restaurant_id;
					foreach (var review in resultsRev)
					{
						if (review.Review_Id == restaurantID)
						{
							Console.WriteLine("Customer: " + review.Customer + " Rating: " + review.Rating);
						}
					}
				}
			}
		}

		public void TopThree()
		{
			Dictionary<string, double> myDict = new Dictionary<string, double>();
			var results = libraryHelper.GetRestaurant();
			foreach (var restaurant in results)
			{
				myDict.Add(restaurant.names, AverageRating(restaurant.names));
			}
			var sortedDict = from entry in myDict orderby entry.Value ascending select entry;

			Console.WriteLine(sortedDict.ElementAt(sortedDict.Count() - 1) + ", " + sortedDict.ElementAt(sortedDict.Count() - 2) + ", " + sortedDict.ElementAt(sortedDict.Count() - 3));
		}

		public void GetAverageRating(string NameOfRestaurant)
		{
			int restID = 0;
			int result = 0;
			double result2 = 0;
			var results = libraryHelper.GetRestaurant();
			var resultsRev = libraryHelper.GetReviews();
			foreach (var restaurant in results)
			{
				if (restaurant.names == NameOfRestaurant)
				{
					restID = restaurant.restaurant_id;
					foreach (var review in resultsRev)
					{
						if (review.Review_Id == restID)
						{
							result += review.Rating;
						}
					}
				}
			}
			result2 = (double)result / 3;
			Console.WriteLine("Average Review: " + result2);
		}

		// help with getting top 3
		public double AverageRating(string NameOfRestaurant)
		{
			int restID = 0;
			int result = 0;
			double result2 = 0;
			var results = libraryHelper.GetRestaurant();
			var resultsRev = libraryHelper.GetReviews();
			foreach (var restaurant in results)
			{
				if (restaurant.names == NameOfRestaurant)
				{
					restID = restaurant.restaurant_id;
					foreach (var review in resultsRev)
					{
						if (review.Review_Id == restID)
						{
							result += review.Rating;
						}
					}
				}
			}
			result2 = (double)result / 3;
			return result2;
		}
	}
}

