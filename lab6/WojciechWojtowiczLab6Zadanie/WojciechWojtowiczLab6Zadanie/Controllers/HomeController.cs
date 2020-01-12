using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WojciechWojtowiczLab6Zadanie.Models;

namespace WojciechWojtowiczLab6Zadanie.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// lista serów
        /// </summary>
        List<CheeseViewModels> cheese;

        /// <summary>
        /// lista miodu
        /// </summary>
        List<HoneyViewModels> honey;

        /// <summary>
        /// lista mleka
        /// </summary>
        List<MilkViewModels> milk;

        /// <summary>
        /// konstruktor
        /// </summary>
        public HomeController()
        {
            this.cheese = new List<CheeseViewModels>();
            cheese.Add(new CheeseViewModels("Ser kozi", 40, "~/images/kozi.jpg"));
            cheese.Add(new CheeseViewModels("Ser owczy", 60, "~/images/owczy.jpeg"));
            cheese.Add(new CheeseViewModels("Ser krowi", 50, "~/images/krowi.jpg"));
            this.honey = new List<HoneyViewModels>();
            honey.Add(new HoneyViewModels("Miód wielokwiatowy", 20, "~/images/wielokwiatowy.jpg"));
            honey.Add(new HoneyViewModels("Miód akacjowy", 40, "~/images/akacjowy.jpg"));
            honey.Add(new HoneyViewModels("Miód lipowy", 30, "~/images/lipowy.jpg"));
            this.milk = new List<MilkViewModels>();
            milk.Add(new MilkViewModels("Mleko krowie", 15, "~/images/mlekokrowie.jpg"));
            milk.Add(new MilkViewModels("Mleko owcze", 20, "~/images/mlekoowcze.jpg"));
            milk.Add(new MilkViewModels("Mleko kozie", 17, "~/images/mlekokozie.jpg"));
        }

        /// <summary>
        /// wyświetlenie wszyskich miodów
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult HoneyPage()
        {
            return View(this.honey);
        }

        /// <summary>
        /// wyświetlenie wszystkich mlek
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult MilkPage()
        {
            return View(this.milk);
        }

        /// <summary>
        /// wyświetlenie wszystkich serów
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CheesePage()
        {
            return View(this.cheese);
        }

        /// <summary>
        /// wyświetlenie formularza zakupu miodu
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult BuyHoney()
        {
            TempData["Order"] = "Formularz zakupu miodu";
            return View();
        }

        /// <summary>
        /// wyświetlenie podsumowania zamówenia miodu
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult BuyHoney(ClientFormModel userData)
        {
            string fullName = userData.FirstName + " " + userData.LastName;
            ViewBag.UserName = fullName;
            ViewBag.Weight = userData.Order;
            return View("BuyItemClient");
        }
        
        /// <summary>
        /// wyświetlenie formluarza zakupu mleka
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult BuyMilk()
        {
            TempData["Order"] = "Formularz zakupu mleka";
            return View();
        }

        /// <summary>
        /// wyświetlenie podsumowania zamówienia mleka
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult BuyMilk(ClientFormModel userData)
        {
            string fullName = userData.FirstName + " " + userData.LastName;
            ViewBag.UserName = fullName;
            ViewBag.Weight = userData.Order;
            return View("BuyItemClient");
        }

        /// <summary>
        /// wyświetlenie formularza zakupu sera
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult BuyCheese()
        {
            TempData["Order"] = "Formularz zakupu sera";
            return View();
        }

        /// <summary>
        /// wyświetlene podsumowania zamówienia sera
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult BuyCheese(ClientFormModel userData)
        {
            string fullName = userData.FirstName + " " + userData.LastName;
            ViewBag.UserName = fullName;
            ViewBag.Weight = userData.Order;
            return View("BuyItemClient");
        }

        /// <summary>
        /// pobranie miodu po jego nazwie
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetHoney(string name)
        {
            HoneyViewModels myHoney = this.honey.Where(a => a.Name.ToLower() == name.ToLower()).FirstOrDefault();
            return View(myHoney);
        }

        /// <summary>
        /// pobranie mleka po jego nazwie
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetMilk(string name)
        {
            MilkViewModels myMilk = this.milk.Where(a => a.Name.ToLower() == name.ToLower()).FirstOrDefault();
            return View(myMilk);
        }

        /// <summary>
        /// pobranie sera po jego nazwie
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCheese(string name)
        {
            CheeseViewModels myCheese = this.cheese.Where(a => a.Name.ToLower() == name.ToLower()).FirstOrDefault();
            return View(myCheese);
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

        /// <summary>
        /// opis strony
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult About()
        {
            ViewData["Message"] = "Opis strony.";

            return View();
        }

        /// <summary>
        /// kontakt
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Strona kontaktowa.";

            return View();
        }

        /// <summary>
        /// wyswietlenie infro o prywatnosci
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// wyswietlenie informacji o bledzie
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }        
    }
}
