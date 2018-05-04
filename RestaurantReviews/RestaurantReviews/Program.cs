using Data;
using Library.Classes;
using RestaurantReviews.Library.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews
{ 
	class MainClass
	{
		static void Main(string[] args)
		{
			/*
			Console.WriteLine("Enter new Restaurant name: ");
			var newName = Console.ReadLine();

			var libHelper = new LibraryHelper();
			libHelper.AddRestaurant(new Library.Classes.Restaurants() { name = newName });
			// saves changes, updates dbsets

			var results = libHelper.GetRestaurant();
			Console.WriteLine("All stored restaurants:");
			foreach (var restaurant in results)
				Console.WriteLine(restaurant.name);

			Console.ReadKey();
		}
		{
		*/

			Serialization ser = new Serialization();

			Functions func = new Functions();
			while (true)
            {
                Console.WriteLine(
@"
Please choose from the following options: 
1. Display all restaurants
2. Enter a restaurant name for their details
3. Enter a restaurant name for their reviews
4. Search for restaurants using any characters
5. Enter a restaurant name for their average rating
6. Show the top three restaurants based on ratings
0. To exit");
                var choice = Console.ReadLine();
                if (choice == "1")
                {
                    func.ShowAll();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Enter restaurant name: ");
                    string read = Console.ReadLine();
	//logger.Debug(read);
                    func.RestaurantDetails(read);
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Enter restaurant name: ");
                    string read = Console.ReadLine();
//logger.Debug(read);
                   func.AllReviews(read);
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Enter any characters: ");
                    string read = Console.ReadLine();
//logger.Debug(read);
                    func.SearchRestaurant(read);
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Enter restaurant name: ");
                    string read = Console.ReadLine();
//logger.Debug(read);
                   func.GetAverageRating(read);
                }
                else if (choice == "6")
                {
                 func.TopThree();
                }
                else if (choice == "0")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("You entered an invalid key");
                }
            }
        }
	}
}
