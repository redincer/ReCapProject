﻿using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryProductDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear+"-"+car.Description);
            }
            
        }
    }
}