using CarShop.Data;
using CarShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Controllers
{
    public class HomeController : Controller
    {
        ICarRepository repo;

        public HomeController(ICarRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(repo.GetAll());
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            repo.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Car newcar)
        {
            repo.Add(newcar);
            return RedirectToAction(nameof(Index));
            //return Index();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(repo.GetById(id));
        }

        public IActionResult Edit(Car car)
        {
            int id = car.Id;
            repo.Delete(id);
            repo.Add(car);
            return RedirectToAction(nameof(Index));
        }
    }
}
