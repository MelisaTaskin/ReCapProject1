﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{

    public class InMemoryCarDal : ICarDal
    {


        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=200,Description="Honda"},
                new Car{CarId=2,BrandId=2,ColorId=2,ModelYear=2001,DailyPrice=300,Description="Fiat" },
                new Car{CarId=3,BrandId=3,ColorId=3,ModelYear=2002,DailyPrice=400,Description="Ford" },
                new Car{CarId=4,BrandId=4,ColorId=4,ModelYear=2003,DailyPrice=500,Description="Volkswagen" },
                new Car{CarId=5,BrandId=5,ColorId=5,ModelYear=2004,DailyPrice=600,Description="Mercedes" }


            };
        }




        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //LİNQ

            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int carId)
        {
            Car carToFind = _cars.SingleOrDefault(c => c.CarId == c.CarId);
            return carToFind;

        }



        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == c.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;


        }

        void ICarDal.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
