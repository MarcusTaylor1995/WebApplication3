using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {


            IndexViewModel tos = new IndexViewModel();
            //model.FavoriteBands = new List<string>();

            tos.Description = "Items being added to the store!";
            tos.Item = ("Nintendo Gamecube");
            tos.Item = ("Xbox One");
            tos.Item = ("Playstation 4");

            Database d1 = new Database();
            d1.Item = "Nintendo Gamecube";
            d1.Price = 99.99;
            d1.Unit = 15;
            d1.ContactName = "Elijah Smith";
            d1.ContactNumber = "706-213-0942";

            tos.Data.Add(d1);

            Database d2 = new Database
            {
                Item = "Xbox One",
                Price = 199.99,
                Unit = 20,
                ContactName = "Devon Jackson",
                ContactNumber = " 803-555-0042"
            };

            tos.Data.Add(d2);

            Database d3 = new Database
            {
                Item = "Playstation 4",
                Price = 299.99,
                Unit = 40,
                ContactName = " Corey Lewis ",
                ContactNumber = "803-706-8003",
            };

            tos.Data.Add(new Database());

            tos.Data.Add(d3); 

            return View(tos);

        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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

