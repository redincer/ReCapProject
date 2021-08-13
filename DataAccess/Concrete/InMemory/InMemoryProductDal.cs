using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq;
namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryProductDal()
        {
            _cars = new List<Car>
            {
                new Car{ID = 1,BrandId = 2,ColorId = 3,DailyPrice = 22500,ModelYear = "1995",Description="Good"},
                new Car{ID = 2,BrandId = 1,ColorId = 1,DailyPrice = 120500,ModelYear = "1990",Description="Well"},
                new Car{ID = 3,BrandId = 3,ColorId = 16,DailyPrice = 32500,ModelYear = "1991",Description="Bad"},
                new Car{ID = 4,BrandId = 5,ColorId = 8,DailyPrice = 45500,ModelYear = "1996",Description="Notr"},
                new Car{ID = 5,BrandId = 7,ColorId = 23,DailyPrice = 20000,ModelYear = "1999",Description="Not Good"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.ID == car.ID);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.ID == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.ID == car.ID);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
