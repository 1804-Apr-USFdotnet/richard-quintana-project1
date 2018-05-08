using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviews.Data;

namespace RestaurantReviews.Data.Classes
{
	public class LibraryHelper
	{
		private Restaurant_ReviewDBEntities db;
		public IEnumerable<Restaurant> GetRestaurant()
		{
			IEnumerable<Restaurant> result;
			using (var db = new Restaurant_ReviewDBEntities())
			{
				var dataList = db.Restaurants.ToList();
				result = dataList.Select(x => DataToLibrary(x)).ToList();
			}
			return result;
		}

		public IEnumerable<Reviews> GetReviews()
		{
			IEnumerable<Reviews> result;
			using (var db = new Restaurant_ReviewDBEntities())
			{
				var dataList = db.Reviews.ToList();
				result = dataList.Select(x => DataToLibraryRev(x)).ToList();
			}
			return result;
		}

		private Reviews DataToLibraryRev(Reviews x)
		{
			throw new NotImplementedException();
		}

		public void AddRestaurant(Restaurant item)
		{
			using (db = new Restaurant_ReviewDBEntities())
			{
				db.Restaurants.Add(LibraryToData(item));
				db.SaveChanges();
			}
		}

		// mapping

		public static Restaurant DataToLibrary(Data.Restaurant dataModel)
		{
			var libModel = new Restaurant()
			{
				ID = dataModel.ID,
				Name = dataModel.Name,
				Address = dataModel.Address,
				StyleOfFood = dataModel.StyleOfFood,
				Avg_Rating = (int)dataModel.Avg_Rating
			};
			return libModel;
		}

		public static Reviews DataToLibraryRev(Data.RestaurantReview dataModel)
		{
			var libModel = new Reviews()
			{
				ID = dataModel.ID,
				Review_ID = (int)dataModel.Review_ID,
				Customer = dataModel.Customer,
				Rating = (int)dataModel.Rating
			};
			return libModel;
		}

		public static Data.Restaurant LibraryToData(Restaurant libModel)
		{
			var dataModel = new Data.Restaurant()
			{
				Name = libModel.Name
			};
			return dataModel;
		}
	}
}
