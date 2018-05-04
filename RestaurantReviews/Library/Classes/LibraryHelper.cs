using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Library.Classes
{
	public class LibraryHelper
	{
		private RestaurantDBEntities db;
		public IEnumerable<Restaurants> GetRestaurant()
		{
			IEnumerable<Restaurants> result;
			using (var db = new RestaurantDBEntities())
			{
				var dataList = db.Restaurant.ToList();
				result = dataList.Select(x => DataToLibrary(x)).ToList();
			}
			return result;
		}

		public IEnumerable<Reviews> GetReviews()
		{
			IEnumerable<Reviews> result;
			using (var db = new RestaurantDBEntities())
			{
				var dataList = db.Review.ToList();
				result = dataList.Select(x => DataToLibraryRev(x)).ToList();
			}
			return result;
		}

		public void AddRestaurant(Restaurants item)
		{
			using (db = new RestaurantDBEntities())
			{
				db.Restaurant.Add(LibraryToData(item));
				db.SaveChanges();
			}
		}

		// mapping

		public static Restaurants DataToLibrary(Data.Restaurants dataModel)
		{
			var libModel = new Restaurants()
			{
				restaurant_id = dataModel.restaurant_id,
				names = dataModel.names,
				address = dataModel.address,
				city = dataModel.city,
				state = dataModel.state,
				zipcode = dataModel.zipcode,
				style = dataModel.style,
				avg_rating = dataModel.avg_rating
			};
			return libModel;
		}

		public static Reviews DataToLibraryRev(Data.RestaurantReview dataModel)
		{
			var libModel = new Reviews()
			{
				Id = dataModel.Id,
				Rating = dataModel.Rating,
				Customer = dataModel.Customer,
				Review_Id = dataModel.Review_Id
			};
			return libModel;
		}

		public static Data.Restaurants LibraryToData(Restaurants libModel)
		{
			var dataModel = new Data.Restaurants()
			{
				names = libModel.names
			};
			return dataModel;
		}
	}
}
