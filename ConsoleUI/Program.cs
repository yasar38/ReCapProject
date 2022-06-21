using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}

            //CarManager carManager = new CarManager(new EfCarDal());
            //Car car8 = new Car() { BrandId = 3, ColorId = 3, Description = "C", ModelYear = "2020", DailyPrice =0};
            //carManager.Add(car8);

            

            //CarManager carManager = new CarManager(new EfCarDal());
            //carManager.GetCarById(1);
            //foreach (var car in carManager.GetCarById(1))
            //{
            //    Console.WriteLine(car.DailyPrice);
            //}

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);

            }
            Console.ReadLine();
        }
    }
}
