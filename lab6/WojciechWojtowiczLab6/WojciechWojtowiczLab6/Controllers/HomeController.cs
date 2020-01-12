using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WojciechWojtowiczLab6.Models;

namespace WojciechWojtowiczLab6.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Lista samochodów do wyświetlenia
        /// </summary>
        List<CarViewModel> cars;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public HomeController()
        {
            cars = new List<CarViewModel>();
            cars.Add(new CarViewModel("Focus", "Ford", 72000, "/focus.png"));
            cars.Add(new CarViewModel("Golf", "Volkswagen", 63000, "/golf.png"));
            cars.Add(new CarViewModel("Civic", "Honda", 48000, "/civic.png"));
            cars.Add(new CarViewModel("Megane", "Renualt", 29000, "/megane.png"));
        }

        /// <summary>
        /// Strona główna
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
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

        /// <summary>
        /// wyświetlenie informalcji o błędzie
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// Widok z ciekawymi linkami
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult IntrestingLinks()
        {
            return View();
        }

        /// <summary>
        /// Lista wszystkich samochodów z bazy danych
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllCars()
        {
            return View(cars);
        }

        /// <summary>
        /// Wyświetlenie listy modeli samochodów
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetListOfModels()
        {
            //Lista nazw modeli samochodów do wyświetlenia
            List<string> models = new List<string>();

            //pętla dodająca model do samochodu z listy
            foreach(CarViewModel car in cars)
            {
                models.Add(car.Model);
            }

            //Przekazanie listy modeli do widoku
            return View(models);
        }

        /// <summary>
        /// Pobranie samochodu po jego modelu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCarByModel(string model)
        {
            //wyszukanie samochodu po modelu
            CarViewModel car = cars.Where(c => c.Model.ToLower() == model.ToLower()).FirstOrDefault();
            //Przekazanie obiektu do widoku
            return View(car);
        }
        
        /// <summary>
        /// wyświetlenie formularza kontaktowego do wypełnienia
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ContactForm()
        {
            return View();
        }

        /// <summary>
        /// Wyśiwtlenie powitania po wypełnieiu formularza kontaktowego
        /// </summary>
        /// <param name="formViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ContactForm(ContactFormViewModel formViewModel)
        {
            string fullName = formViewModel.FirstName + " " + formViewModel.LastName;
            ViewBag.UserName = fullName;
            return View("ContactFormGreetings");
        }
    }
}
