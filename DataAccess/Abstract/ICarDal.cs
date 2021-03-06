﻿using Entities.Concerte;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        //InMemory formatta GetById, GetAll, Add, Update, Delete

        void GetById(Car car);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);


    }
}
