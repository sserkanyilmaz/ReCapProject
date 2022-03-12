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
        List<Car> _carDal;

        public InMemoryCarDal()
        {
            _carDal = new List<Car>
            {
                new Car { CarId = 1,BrandId=1, ColorId=1,DailyPrice=144,Description="Gayet hizli araba",ModelYear="2020" },
                new Car { CarId = 2,BrandId=1, ColorId=2,DailyPrice=123,Description="Gayet güzel araba",ModelYear="2010" },
                new Car { CarId = 3,BrandId=2, ColorId=3,DailyPrice=400,Description="Gayet pahali araba",ModelYear="2022" }
            };
            
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToBeDeleted = _carDal.SingleOrDefault(p=>p.CarId==car.CarId);
            _carDal.Remove(carToBeDeleted);
        }

        public List<Car> GetAll()
        {
            return _carDal;
        }

        public List<Car> GetById(int CarId)
        {
            return _carDal.Where(p=>p.CarId==CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToBeUpdate = _carDal.SingleOrDefault(p => p.CarId == car.CarId);
            carToBeUpdate.CarId=car.CarId;
            carToBeUpdate.BrandId=car.BrandId;
            carToBeUpdate.ColorId=car.ColorId;
            carToBeUpdate.DailyPrice=car.DailyPrice;
            carToBeUpdate.Description=car.Description;
            carToBeUpdate.ModelYear=car.ModelYear;

        }
    }
}
