﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface ICarDal
    {
        List<Car> GetAll();
        void Add(Car car);
        void GetById(int id);
        void Update(Car car);
        void Delete(Car car);
        Car GetById();
    }
}
