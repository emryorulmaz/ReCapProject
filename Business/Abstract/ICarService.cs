using Entities.Concerte;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
       // InMemory formatta GetById, GetAll, Add, Update, Delete
        List<Car> GetAll();
        //void GetById();
        //void Update();
        //void Delete();
        //void Add();
    }
}
