using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Assignment4.Models
{
    /// <summary>
    /// Suggestion Model
    /// </summary>
    public class Restaurant2
    {
        [Required]
        public string username { get; set; }

        [Required]
        public int Rank { get; set; }

        [Required]
        public string RestaurantName { get; set; }

        public string FavoriteDish { get; set; } = "It's all tasty!";

        [Required]
        public string Address { get; set; }

        public string RestaurantPhone { get; set; } 

        public string LinkToWebsite { get; set; } = "Coming Soon!";
    }

    /// <summary>
    /// Array Model with options to avoid null values
    /// Rank, Restaurant Name, and Address all need to be included. The other fields are optional.
    /// </summary>
    public class Restaurant
    {
        /// Rank set to read only
        public Restaurant(int rank)
        {
            Rank = rank;
        }

        [Required]
        public int Rank { get; set; }

        [Required]
        public string RestaurantName { get; set; }

        /// <summary>
        /// If the favorite dish is empty as you prepare to list out the results, list “It’s all tasty!” in its place.
        /// </summary>
        public string? FavoriteDish { get; set; } = "It's all tasty!";

        [Required]
        public string Address { get; set; }

        [Phone]
        public long? RestaurantPhone { get; set; } = 5555555555;

        /// <summary>
        /// If there is no website entered in the model, we should store as a default “Coming soon.” 
        /// </summary>
        public string? LinkToWebsite { get; set; } = "Coming Soon!";

        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                
                RestaurantName = "El Gallo Giro",
                FavoriteDish = "Pollo",
                Address = "650 West, 300 East Provo",
                RestaurantPhone = 8013096451,
                LinkToWebsite = "www.elgallogiro.com"
            };

            Restaurant r2 = new Restaurant(2)
            {
                
                RestaurantName = "Indian Palace",
                FavoriteDish = "Butter Chicken",
                Address = "650 West, State Street Provo",
                RestaurantPhone = 8017791966,
                LinkToWebsite = "www.indianpalace.com"
            };

            Restaurant r3 = new Restaurant(3)
            {
                
                RestaurantName = "Burger Supreme",
                FavoriteDish = "Pastrami Burger",
                Address = "650 West, University Ave. Provo",
                RestaurantPhone = 8013096451,
                ///LinkToWebsite = "www.BurgerSupreme.com"
            };

            Restaurant r4 = new Restaurant(4)
            {
                
                RestaurantName = "Sushi Ya",
                ///FavoriteDish = "California Roll",
                Address = "650 West, Bull Dog Ave. Provo",
                RestaurantPhone = 8013096451,
                LinkToWebsite = "www.SushiYa.com"
            };

            Restaurant r5 = new Restaurant(5)
            {

                RestaurantName = "Tucanos",
                FavoriteDish = "Chorizo",
                Address = "360 east, University Ave. Provo",
                RestaurantPhone = 8013096451,
                LinkToWebsite = "www.Tucanos.com"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }



    }
}
