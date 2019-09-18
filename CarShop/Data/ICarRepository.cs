using CarShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data
{
    public interface ICarRepository
    {
        void Add(Car newCar);
        void Delete(Car carToDelete);
        void Delete(int carId);
        Car GetById(int id);
        IEnumerable<Car> GetAll();
    }
}
