using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantlist;
            
            restaurantlist = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {

                restaurantlist.Add($"#{r.Rank}: {r.RestaurantName} Best Dish: {r.FavoriteDish} Location: {r.Address} Phone Number: {r.RestaurantPhone} Website: ({r.LinkToWebsite})");
            }

            return View(restaurantlist);
        }

        [HttpGet]
        public IActionResult NewRestaurant()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewRestaurant(Restaurant2 food)
        {
            
            TempStorage.AddAplication(food);
            return View("confirmation", food);
        }

        public IActionResult RestaurantList()
        {
            return View(TempStorage.Applications);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
