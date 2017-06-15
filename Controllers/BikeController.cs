using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeShop.Models.Entities;
using BikeShop.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BikeShop.Controllers
{
    public class BikeController : Controller
    {
        private IBikeRepository _bikeRepository;

        public BikeController(IBikeRepository bikeRepository)
        {
            _bikeRepository = bikeRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Bike> bikes = _bikeRepository.GetAll();
            return View(bikes);
        }

        public IActionResult Details(int id)
        {
            Bike b = _bikeRepository.Get(id);
            return View(b);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Bike b = _bikeRepository.Get(id);
            return View(b);
        }

        [HttpPost]
        public IActionResult Delete(Bike bike)
        {
            _bikeRepository.Delete(bike);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Bike b = _bikeRepository.Get(id);
            return View(b);
        }

        [HttpPost]
        public IActionResult Update(Bike bike)
        {
            if(ModelState.IsValid)
            {
                _bikeRepository.Update(bike);
                return RedirectToAction("Index");
            }
            return View(bike);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Bike bike)
        {
            if(ModelState.IsValid)
            {
                _bikeRepository.Save(bike);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
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

        public IActionResult Error()
        {
            return View();
        }
    }
}
