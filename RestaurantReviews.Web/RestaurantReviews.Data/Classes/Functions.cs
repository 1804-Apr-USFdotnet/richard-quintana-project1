using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviews.Data.Interfaces;
using RestaurantReviews.Data;


namespace RestaurantReviews.Data.Classes
{
	public class Functions : IFunctions
	{
		LibraryHelper libraryHelper = new LibraryHelper();

		public void SearchRestaurant(string NameOfRestaurant)
		{
			var results = libraryHelper.GetRestaurant();
			foreach (var Restaurants in results)
			{
				if (Restaurants.Name.Contains(NameOfRestaurant))
				{
					Console.WriteLine("Restaurant name: " + Restaurants.Name);
				}
			}
		}

		public void RestaurantDetails(string NameOfRestaurant)
		{
			var results = libraryHelper.GetRestaurant();
			foreach (var Restaurants in results)
			{
				if (Restaurants.Name == NameOfRestaurant)
				{
					Console.WriteLine("Name: " + Restaurants.Name + " Address: " + Restaurants.Address + " Style of Food: " +  Restaurants.StyleOfFood + " Rating: " + Restaurants.Avg_Rating);
				}
			}
		}

		public void ShowAll()
		{
			var results = libraryHelper.GetRestaurant();
			foreach (var Restaurants in results)
				Console.WriteLine(Restaurants.Name);
		}

		public void AllReviews(string NameOfRestaurant)
		{
			int restaurantID = 0;
			var results = libraryHelper.GetRestaurant();
			var resultsRev = libraryHelper.GetReviews();
			foreach (var Restaurants in results)
			{
				if (Restaurants.Name == NameOfRestaurant)
				{
					restaurantID = Restaurants.ID;
					foreach (var review in resultsRev)
					{
						if (review.Review_ID == restaurantID)
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
				myDict.Add(restaurant.Name, AverageRating(restaurant.Name));
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
				if (restaurant.Name == NameOfRestaurant)
				{
					restID = restaurant.ID;
					foreach (var review in resultsRev)
					{
						if (review.Review_ID == restID)
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
				if (restaurant.Name == NameOfRestaurant)
				{
					restID = restaurant.ID;
					foreach (var review in resultsRev)
					{
						if (review.Review_ID == restID)
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
