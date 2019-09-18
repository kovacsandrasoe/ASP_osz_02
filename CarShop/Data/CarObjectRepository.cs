using CarShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data
{
    public class CarObjectRepository : ICarRepository
    {
        private List<Car> cars;
        public CarObjectRepository()
        {
            cars = new List<Car>();
            cars.Add(new Car()
            {
                Id = 1,
                Plate = "ABC-123",
                Type = "Peugeot 406",
                HorsePower = 120
            });

        }

        public void Add(Car newCar)
        {
            cars.Add(newCar);
        }

        public void Delete(Car carToDelete)
        {
            cars.Remove(carToDelete);
        }

        public void Delete(int carId)
        {
            Delete(GetById(carId));
        }

        public IEnumerable<Car> GetAll()
        {
            return cars;
        }

        public Car GetById(int id)
        {
            return cars.FirstOrDefault(x => x.Id == id);
        }
    }
}
