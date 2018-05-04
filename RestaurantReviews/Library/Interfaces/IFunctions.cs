﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviews.Library.Classes;
using System.Xml.Serialization;

namespace RestaurantReviews.Library.Interfaces
{
	interface IFunctions
	{
		void SearchRestaurant(string NameOfRestaurant);
		void RestaurantDetails(string NameOfRestaurant);
		void ShowAll();
		void AllReviews(string NameOfRestaurant);
		void TopThree();
		void GetAverageRating(string NameOfRestaurant);
	}
}
