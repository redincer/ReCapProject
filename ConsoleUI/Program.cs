using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
           //Added : carManager.Add(new Car{ID = 2,BrandId = 1,ColorId = 1,DailyPrice = 100,Description = "Fiat-Uno",ModelYear = "1995"});
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ID);
            }
            
        }
    }
}
