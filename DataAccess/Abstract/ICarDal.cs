using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        public void Add(Car car);
        public void Update(Car car);
        public void Delete(Car car);
        List<Car> GetALL();
        List<Car> GetById(int carId);


    }
}
