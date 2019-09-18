using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Models;

namespace CarShop.Data
{
    public class CarSQLRepository : ICarRepository
    {
        CarContext db;

        public CarSQLRepository(CarContext db)
        {
            this.db = db;
        }

        public void Add(Car newCar)
        {
            newCar.Id = 0;
            db.CarSQLTable.Add(newCar);
            db.SaveChanges();
        }

        public void Delete(Car carToDelete)
        {
            db.CarSQLTable.Remove(carToDelete);
            db.SaveChanges();
        }

        public void Delete(int carId)
        {
            var car = GetById(carId);
            Delete(car);
            db.SaveChanges();
        }

        public IEnumerable<Car> GetAll()
        {
            return db.CarSQLTable;
        }

        public Car GetById(int id)
        {
            return db.CarSQLTable.FirstOrDefault(x => x.Id == id);
        }
    }
}
