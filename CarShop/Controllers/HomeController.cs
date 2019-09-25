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

        [HttpGet]
        public FileContentResult GetContent(int id)
        {
            var car = repo.GetById(id);
            return new FileContentResult
                (car.PictureData, car.ContentType);
        }

        [HttpPost]
        public IActionResult Add(Car newcar)
        {
            //image/jpeg
            newcar.ContentType = newcar.PictureInfo.ContentType;

            byte[] data = new byte[newcar.PictureInfo.Length];

            using (var stream = newcar.PictureInfo.OpenReadStream())
            {
                stream.Read(data, 0, (int)newcar.PictureInfo.Length);
            }

            newcar.PictureData = data;


            if (newcar.Plate == "AAA-111")
            {
                return StatusCode(306);
            }


            if (!ModelState.IsValid)
            {
                return View(nameof(Add), newcar);
            }
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
