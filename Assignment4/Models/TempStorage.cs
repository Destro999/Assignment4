using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public static class TempStorage 
    {
        private static List<Restaurant2> applications = new List<Restaurant2>();

        public static IEnumerable<Restaurant2> Applications => applications;

        public static void AddAplication(Restaurant2 application)
        {
            applications.Add(application);
        }

    }
}
