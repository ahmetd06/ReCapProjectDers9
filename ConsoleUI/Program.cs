using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
          
            CarManager carManager = new CarManager(new  EfCarDal());

            //Car car = new Car {  BrandId = 200, ColorId = 123, DailyPrice = 110, ModelYear = 2006, Description = "Cordoba" };
            //carManager.Add(car);

            //car = new Car { BrandId = 300, ColorId = 200, DailyPrice = 150, ModelYear = 2020, Description = "Focus" };
            //carManager.Add(car);

            ////var result = carManager.GetAll();

            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine("{0} {1} {2} {3} {4}", item.Id, item.BrandId, item.ModelYear, item.DailyPrice, item.Description);
            ////}

            ////var result2 = carManager.GetById(3);

            ////Console.WriteLine("id si 3 olan kayıt:{0}",result2.Description);

            var result3 = carManager.GetCarDetails();

            foreach (var item in result3)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.CarName, item.BrandName, item.ColorName, item.DailyPrice);
            }
        }
    }
}
