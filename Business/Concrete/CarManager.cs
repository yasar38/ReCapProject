﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p=>p.BrandId==id);
        }
        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetCarsByBrandId(c => c.ColorId == id).ToList();
        }
        public void Add(Car car)
        {
            if ((car.Description.Length >= 2) && (car.DailyPrice > 0))
            {
                _carDal.Add(car);
            }
            else
                Console.WriteLine("Bir sorun oluştu hatalı bilgi girildi açıklama kısmı 2 karakterden az fiyat 0 olamaz!!");
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarById(int id)
        {
            return _carDal.GetAll(p => p.CarId == id).ToList();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
