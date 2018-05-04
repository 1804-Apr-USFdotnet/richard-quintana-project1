using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Library.Classes;

namespace RestaurantReviews.Library.Classes
{
	public class Serialization
	{
		Restaurants restaurant = new Restaurants();

		public void main()
		{
			StreamWriter sw = new StreamWriter(@"C:\revature\quintana-richard-project0\RestaurantReviews\RestaurantDB\Properties\Serialization.txt");
			restaurant.restaurant_id = 5;
			restaurant.names = "Taco Bell";
			restaurant.address = "16162 Loki Lane";
			restaurant.city = "Tampa";
			restaurant.state = "Fl";
			restaurant.zipcode = "33604";
			restaurant.avg_rating = 4;

			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(restaurant.GetType());
			x.Serialize(sw, restaurant);
			sw.Close();
			Restaurants restOut = (Restaurants)x.Deserialize(new StreamReader(@"C:\revature\quintana-richard-project0\RestaurantReviews\RestaurantDB\Properties\Serialization.txt"));
			Console.WriteLine(restOut.names);
		}
	}
}
