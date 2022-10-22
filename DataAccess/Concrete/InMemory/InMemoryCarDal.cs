using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
             new Car {CarId = 1, BrandId = 1, ColorId =1, DailyPrice = 5000000,ModelYear = 2021,Description = "Porsche"  },
             new Car {CarId = 2, BrandId = 2, ColorId =2, DailyPrice = 3500000,ModelYear = 2022,Description = "Mercedes - Benz Vito"  },

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetALL()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarToDelete.BrandId = car.BrandId;
            CarToDelete.CarId = car.CarId;
            CarToDelete.ColorId = car.ColorId;
            CarToDelete.DailyPrice = car.DailyPrice;
            CarToDelete.Description = car.Description;
        }
    }
}
