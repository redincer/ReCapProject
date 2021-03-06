using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal) => this._carDal = carDal;
        
        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
                _carDal.Add(car);
            else
                Console.WriteLine("Min Length must 2 and car daily price must bigger than 0");
        }

        public void Delete(Car car)
        {
           _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> getCarDetails()
        {
            return _carDal.getCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p => p.BrandId ==brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p => p.ColorId == colorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
