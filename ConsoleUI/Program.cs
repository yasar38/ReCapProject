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
            CarTest();
            //BrandGetName();



            //-----------------Car Nesnesini Veri Tabanına Ekleme---
            //CarManager carManager = new CarManager(new EfCarDal());
            //Car car8 = new Car() { BrandId = 3, ColorId = 3, Description = "C", ModelYear = "2020", DailyPrice =0};
            //carManager.Add(car8);

            //-----------------İd ile Car Çağırma------------
            //CarManager carManager = new CarManager(new EfCarDal());
            //carManager.GetCarById(1);
            //foreach (var car in carManager.GetCarById(1))
            //{
            //    Console.WriteLine(car.DailyPrice);
            //}



        }

        //private static void BrandGetName()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.BrandName);
        //    }
        //}

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
